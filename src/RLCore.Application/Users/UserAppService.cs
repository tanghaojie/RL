using Abp.Domain.Repositories;
using Abp.UI;
using RLCore.Encryption;
using RLCore.Users.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLCore.Users
{
    public class UserAppService : RLCoreAppServiceBase, IUserAppService
    {
        private readonly IRepository<User> _userRepository;

        public UserAppService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<int> Create(CreateInput input)
        {
            if (UsernameExist(input.Username))
            {
                throw new UserFriendlyException("用户名已存在");
            }
            var user = ObjectMapper.Map<User>(input);
            user.Password = Password.MD5(input.Password);
            return await _userRepository.InsertAndGetIdAsync(user);
        }

        public bool UsernameExist(string username)
        {
            return _userRepository.GetAll().Where(u => u.Username.ToUpper() == username.ToUpper()).Count() > 0;
        }
    }
}
