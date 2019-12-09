using Abp.Domain.Repositories;
using RLCore.RLAppService.ManagerLakeSidRelation.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.RLAppService.ManagerLakeSidRelation
{
    public class ManagerLakeSidRelationAppService : RLCoreAppServiceBase, IManagerLakeSidRelationAppService
    {
        private readonly IRepository<RL.ManagerLakeSidRelation> _Repository;
        public ManagerLakeSidRelationAppService(IRepository<RL.ManagerLakeSidRelation> repository)
        {
            _Repository = repository;
        }

        public void Add(AddInput input)
        {
            //_Repository.Insert(new RL.ManagerLakeSidRelation
            //{
            //    LakeSid = "11",
            //    ManagerId = 1
            //})
        }

    }
}
