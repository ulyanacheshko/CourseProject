using MovieTickets.OrderDTO;

namespace MovieTickets.Services.Contracts
{
    public interface IOrderService
    {
        Task<OrderDto> GetById(int id);
        Task<int> Create(OrderDto orderDto);
        Task<List<OrderDto>> GetOrders();
        Task<OrderDto> Update(OrderDto orderDto);
        Task<bool> Delete(int id);
    }
}