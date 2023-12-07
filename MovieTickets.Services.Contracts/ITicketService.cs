using MovieTickets.OrderDTO;

namespace MovieTickets.Services.Contracts
{
    public interface ITicketService
    {
        Task<TicketDto> GetById(int id);
        Task<int> Create(TicketDto ticketDto);
        Task<List<TicketDto>> GetTickets();
        Task<TicketDto> Update(TicketDto ticketDto);
        Task<bool> Delete(int id);
    }
}