using AutoMapper;
using HotelBooking.DataAccess.Repository;
using MovieTickets.DataAccess.Repository;
using MovieTickets.DataAccess.Repository.Contracts;
using MovieTickets.Entities;
using MovieTickets.OrderDTO;
using MovieTickets.Services.Contracts;

namespace MovieTickets.Services
{
    public class TicketService : ITicketService
    {
        public readonly ITicketRepository _ticketRepository;
        public readonly IMapper _mapper;

        public TicketService(ITicketRepository ticketRepository, IMapper mapper)
        {
            _ticketRepository = ticketRepository;
            _mapper = mapper;
        }

        public async Task<int> Create(TicketDto ticketDto)
        {
            var ticketToAdd = _mapper.Map<Ticket>(ticketDto);

            return await _ticketRepository.Create(ticketToAdd);
        }

        public async Task<bool> Delete(int id)
        {
            var ticketToDelete = await _ticketRepository.GetById(id);
            if (ticketToDelete == null)
            {
                return false;
            }
            await _ticketRepository.Delete(ticketToDelete);
            return true;
        }

        public async Task<List<TicketDto>> GetTickets()
        {
            var tickets = await _ticketRepository.GetTickets();
            return _mapper.Map<List<TicketDto>>(tickets);
        }

        public async Task<TicketDto> GetById(int id)
        {
            var ticket = await _ticketRepository.GetById(id);
            return _mapper.Map<TicketDto>(ticket);
        }

        public async Task<TicketDto> Update(TicketDto ticketDto)
        {
            var existingTicket = await _ticketRepository.GetById(ticketDto.Id);

            if (existingTicket == null)
            {
                return null;
            }

            _mapper.Map(ticketDto, existingTicket);

            await _ticketRepository.Update(existingTicket);

            return _mapper.Map<TicketDto>(existingTicket);
        }
    }
}