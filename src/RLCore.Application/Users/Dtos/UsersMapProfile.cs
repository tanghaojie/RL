using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.Users.Dtos
{
    public class UsersMapProfile : Profile
    {
        public UsersMapProfile()
        {
            CreateMap<CreateInput, User>();
            CreateMap<User, UserOutput>();
            //CreateMap<UserDto, User>()
            //    .ForMember(x => x.Roles, opt => opt.Ignore())
            //    .ForMember(x => x.CreationTime, opt => opt.Ignore());

            //CreateMap<CreateUserDto, User>();
            //CreateMap<CreateUserDto, User>().ForMember(x => x.Roles, opt => opt.Ignore());
        }
    }
}
