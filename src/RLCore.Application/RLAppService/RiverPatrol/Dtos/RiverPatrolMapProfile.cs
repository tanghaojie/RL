using AutoMapper;
using NetTopologySuite.Geometries;
using RLCore.Services.Extension;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.RLAppService.RiverPatrol.Dtos
{
    public class RiverPatrolMapProfile : Profile
    {
        public RiverPatrolMapProfile()
        {
            CreateMap<StartInput, RL.RiverPatrol>().ForMember(u => u.StartPoint, options => options.MapFrom(src => src.Point.ToPoint()));
            CreateMap<RL.RiverPatrol, RiverPatrolOutput>().ForMember(tar => tar.Track, opt => opt.MapFrom(src => Convert(src)));
        }

        public TrackCls Convert(RL.RiverPatrol rp)
        {
            var x = rp.TrackPointIndexAndSecondWithoutASecond;
            var len = x.Length;
            var list = new List<IndexAndSecond>();
            if (len > 0)
            {
                for (int i = 0; i < len; i += 2)
                {
                    list.Add(new IndexAndSecond
                    {
                        Index = x[i],
                        Second = x[i + 1]
                    });
                }
            }
            return new TrackCls
            {
                Track = rp.Track?.ToString(),
                IndexAndSeconds = list?.ToArray()
            };
        }
    }

    //public class TypeConvertert1 : ITypeConverter<XYCoordinate, Point>
    //{
    //    public Point Convert(XYCoordinate source, Point destination, ResolutionContext context)
    //    {
    //        return source == null ? null : new Point(source.X, source.Y);
    //    }
    //}
}
