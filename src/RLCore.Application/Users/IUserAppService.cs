using Abp.Application.Services;
using RLCore.Users.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RLCore.Users
{
    public interface IUserAppService : IApplicationService
    {
        Task<int> Create(CreateInput input);

        UserOutput GetInfo();

        bool UsernameExist(string username);

        void ChangePassword(string newPass);

        void ChangeInfo(ChangeInfoInput input);
    }
}
