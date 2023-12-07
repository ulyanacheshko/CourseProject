using MovieTickets.Entities;

namespace MovieTickets.DataAccess.Repository.Contracts
{
    public interface IOrderRepository
    {
        Task<Order> GetById(int id);
        Task<List<Order>> GetOrders();
        Task<int> Create(Order order);
        Task Update(Order order);
        Task Delete(Order order);
    }
}
