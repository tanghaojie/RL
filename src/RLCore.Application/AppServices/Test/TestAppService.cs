using Abp.Domain.Repositories;
using Abp.Web.Models;
using NetTopologySuite;
using RLCore.Entities.EF;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.AppServices.Test
{
    public class TestAppService : RLCoreAppServiceBase, ITestAppService
    {
        private readonly IRepository<TestEntityGeo2> _testRepository;

        public TestAppService(IRepository<TestEntityGeo2> testRepository)
        {
            _testRepository = testRepository;
        }
        public string Get(int i)
        {
            var geo = new NetTopologySuite.Geometries.Point(20, 20);
            geo.SRID = 4326;

            _testRepository.Insert(new TestEntityGeo2
            {
                PostId = i,
                Content = "content",
                Title = "title",
                Location = geo
            });
            return "success";
        }

        public (string, string) X(string path)
        {

            var mc = "";
            var wkt = "";
            return (mc, wkt);
        }

    }
}
