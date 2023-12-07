using AutoMapper;
using MovieTickets.Entities;
using MovieTickets.OrderDTO;

namespace MovieTickets.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User, CreateUserDto>().ReverseMap();

        }
    }
}