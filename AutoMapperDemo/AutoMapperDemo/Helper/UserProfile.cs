using AutoMapper;
using AutoMapperDemo.Models;

namespace AutoMapperDemo.Helper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserViewModel>();
        }
    }
}