using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.UI;
using GeoAPI.Geometries;
using Microsoft.Extensions.FileProviders;
using NetTopologySuite.Geometries;
using RLCore.Cache;
using RLCore.Dtos;
using RLCore.Extensions;
using RLCore.RLAppService.RiverPatrol.Dtos;

namespace RLCore.RLAppService.RiverPatrol
{
    [AbpAuthorize]
    public class RiverPatrolAppService : RLCoreAppServiceBase, IRiverPatrolAppService
    {
        private readonly IRepository<RL.RiverPatrol> _riverPatrolRepository;

        public static string RiverPatrolFolder { get; set; }
        public FileSystem.FileSystem FileSystem { get; set; }


        public RiverPatrolAppService(IRepository<RL.RiverPatrol> riverPatrolRepository)
        {
            _riverPatrolRepository = riverPatrolRepository;
        }


        public async Task<int> Start(StartInput input)
        {
            if ((await GetCurrent()) != null)
            {
                throw new UserFriendlyException(400, "Patrolling in progress");
            }
            var entity = ObjectMapper.Map<RL.RiverPatrol>(input);
            entity.StartDate = DateTime.Now;
            entity.UserId = (int)AbpSession.UserId;

            var id = await _riverPatrolRepository.InsertAndGetIdAsync(entity);

            DeleteUploadPointsCacheDirectory(id);

            return id;
        }

        public async Task UploadPoints(UploadPointsInput input)
        {
            var points = input.Points;
            if (points == null || points.Length <= 0)
            {
                return;
            }
            var id = input.Id;
            if ((await GetCurrent()).Id != id)
            {
                throw new UserFriendlyException(400, "Error request parameter");
            }
            var full = UploadPointsCacheDirectory(id);
            var fullFilename = $"{full}/{DateTime.Now.ToFileTime()}";
            using (var fs = new FileStream(fullFilename, FileMode.OpenOrCreate, FileAccess.Write))
            {
                foreach (var p in input.Points)
                {
                    if (p.SecondSinceStart < 0)
                    {
                        throw new UserFriendlyException(400, "Error request parameter");
                    }
                    var str = $"{p.SecondSinceStart}\t{p.X}\t{p.Y}\r\n";
                    var data = Encoding.Default.GetBytes(str);
                    fs.Write(data, 0, data.Length);
                }
                fs.Flush();
            }
        }

        private void DeleteUploadPointsCacheDirectory(int id)
        {
            var cacheDir = UploadPointsCacheDirectory(id);
            if (Directory.Exists(cacheDir))
            {
                Directory.Delete(cacheDir, true);
            }
        }
        private string UploadPointsCacheDirectory(int id)
        {
            var full = $"{WorkDirectory}/UploadPoints/{id}";
            if (!Directory.Exists(full))
            {
                Directory.CreateDirectory(full);
            }
            return full;
        }
        private string WorkDirectory {
            get {
                var tmp = FileSystem.TempPath;
                var full = $"{tmp}/{RLCoreConsts.RiverPatrolBaseFolderName}";
                if (!Directory.Exists(full))
                {
                    Directory.CreateDirectory(full);
                }
                return full;
            }
        }

        public async Task<RiverPatrolOutput> End(EndInput input)
        {
            var entity = await _riverPatrolRepository.FirstOrDefaultAsync(input.Id);
            if (entity == null)
            {
                throw new UserFriendlyException(400, "Error request parameter");
            }
            if (entity.State == RL.PatrolState.Patrolling)
            {
                var (track, interval) = GetTrack(input.Id);
                Point endP = null;
                if (input.Point != null)
                {
                    endP = new Point(input.Point.X, input.Point.Y);
                }
                entity.EndPoint = endP;
                entity.EndDate = DateTime.Now;
                entity.State = RL.PatrolState.Finished;
                entity.Track = track;
                entity.TrackPointIndexAndSecondWithoutASecond = interval;
            }
            else if (entity.State == RL.PatrolState.Finished)
            {
            }
            else { throw new Exception(); }

            return ObjectMapper.Map<RiverPatrolOutput>(entity);
        }

        private (LineString, int[]) GetTrack(int id)
        {
            var cacheDir = UploadPointsCacheDirectory(id);
            var dirInfo = new DirectoryInfo(cacheDir);
            if (!dirInfo.Exists)
            {
                return (null, null);
            }
            var files = dirInfo.GetFiles();
            if (files == null || files.Length <= 0)
            {
                return (null, null);
            }
            var points = new List<XYTCoordinate>();
            foreach (var file in files)
            {
                using (StreamReader sr = new StreamReader(file.FullName, Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        var d = line.Split('\t');
                        points.AddSorted(new XYTCoordinate
                        {
                            SecondSinceStart = int.Parse(d[0]),
                            X = double.Parse(d[1]),
                            Y = double.Parse(d[2]),
                        });
                    }
                }
            }

            var indexAndIntervals = new List<int>();
            var len = points.Count;
            if (len > 0)
            {
                if (points[0].SecondSinceStart != 1)
                {
                    indexAndIntervals.Add(0);
                    indexAndIntervals.Add(points[0].SecondSinceStart);
                }
                for (int i = 1; i < len; i++)
                {
                    var index = i - 1;
                    var ts = points[i].SecondSinceStart - points[index].SecondSinceStart;
                    if (ts != 1)
                    {
                        indexAndIntervals.Add(index);
                        indexAndIntervals.Add(ts);
                    }
                }
            }
            return (new LineString(points.ToArray().Select(x => new Coordinate(x.X, x.Y)).ToArray()), indexAndIntervals.ToArray());
        }

        public async Task<RiverPatrolOutput> GetCurrent()
        {
            var userId = (int)AbpSession.UserId;
            var entity = await _riverPatrolRepository.FirstOrDefaultAsync(x => x.UserId == userId && x.State == RL.PatrolState.Patrolling);
            return ObjectMapper.Map<RiverPatrolOutput>(entity);
        }

        public async Task Delete(int id)
        {
            await _riverPatrolRepository.DeleteAsync(id);
        }


    }

}
