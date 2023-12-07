using AutoMapper;
using MovieTickets.DataAccess.Repository;
using MovieTickets.DataAccess.Repository.Contracts;
using MovieTickets.Entities;
using MovieTickets.OrderDTO;
using MovieTickets.Services.Contracts;

namespace MovieTickets.Services
{
    public class OrderService : IOrderService
    {
        public readonly IOrderRepository _orderRepository;
        public readonly IMapper _mapper;

        public OrderService(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public async Task<int> Create(OrderDto orderDto)
        {
            var orderToAdd = _mapper.Map<Order>(orderDto);

            return await _orderRepository.Create(orderToAdd);
        }

        public async Task<bool> Delete(int id)
        {
            var orderToDelete = await _orderRepository.GetById(id);
            if (orderToDelete == null)
            {
                return false;
            }
            await _orderRepository.Delete(orderToDelete);
            return true;
        }

        public async Task<List<OrderDto>> GetOrders()
        {
            var bookings = await _orderRepository.GetOrders();
            return _mapper.Map<List<OrderDto>>(bookings);
        }

        public async Task<OrderDto> GetById(int id)
        {
            var order = await _orderRepository.GetById(id);
            return _mapper.Map<OrderDto>(order);
        }

        public async Task<OrderDto> Update(OrderDto orderDto)
        {
            var existingOrder = await _orderRepository.GetById(orderDto.Id);

            if (existingOrder == null)
            {
                return null;
            }

            _mapper.Map(orderDto, existingOrder);

            await _orderRepository.Update(existingOrder);

            return _mapper.Map<OrderDto>(existingOrder);
        }
    }
}