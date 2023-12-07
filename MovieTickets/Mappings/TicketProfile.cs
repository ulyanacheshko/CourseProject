
using AutoMapper;
using MovieTickets.Entities;
using MovieTickets.OrderDTO;

namespace MovieTickets.Mappings
{
    public class TicketProfile : Profile
    {
        public TicketProfile()
        {
            CreateMap<Ticket, TicketDto>().ReverseMap();
            CreateMap<Ticket, CreateTicketDto>().ReverseMap();

        }
    }
}
