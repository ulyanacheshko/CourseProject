using MovieTickets.Entities;

namespace MovieTickets.DataAccess.Repository.Contracts
{
    public interface ITicketRepository
    {
        Task<Ticket> GetById(int id);
        Task<List<Ticket>> GetTickets();
        Task<int> Create(Ticket ticket);
        Task Update(Ticket ticket);
        Task Delete(Ticket ticket);
    }
}
