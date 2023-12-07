using MovieTickets.DataAccess.Repository.Contracts;
using Microsoft.EntityFrameworkCore;
using MovieTickets.Entities;

namespace MovieTickets.DataAccess.Repository
{
    public class OrderRepository : BaseRepository, IOrderRepository
    {
        public OrderRepository(MovieTicketsDbContext movieTicketsDbContext) : base(movieTicketsDbContext)
        {

        }

        public async Task<int> Create(Order order)
        {
            _movieTicketsDbContext.Orders.AddAsync(order);
            await _movieTicketsDbContext.SaveChangesAsync();
            return order.Id;
        }

        public async Task Delete(Order order)
        {
            _movieTicketsDbContext.Orders.Remove(order);
            await _movieTicketsDbContext.SaveChangesAsync();
        }

        public async Task<List<Order>> GetOrders()
        {
            return await _movieTicketsDbContext.Orders.ToListAsync();
        }

        public async Task<Order> GetById(int id)
        {
            return await _movieTicketsDbContext.Orders.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Update(Order order)
        {
            _movieTicketsDbContext.Orders.Update(order);
            await _movieTicketsDbContext.SaveChangesAsync();
        }
    }
}
