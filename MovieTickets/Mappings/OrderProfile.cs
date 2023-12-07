
using AutoMapper;
using MovieTickets.Entities;
using MovieTickets.OrderDTO;

namespace MovieTickets.Mappings
{
    public class OrderProfile : Profile
    {
        public OrderProfile() 
        {
            CreateMap<Order, OrderDto>().ReverseMap();
            CreateMap<Order, CreateOrderDto>().ReverseMap();
           
        }
    }
}
