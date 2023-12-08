using Microsoft.AspNetCore.Mvc;
using MovieTickets.OrderDTO;
using MovieTickets.Services.Contracts;

namespace OrderController.Controllers
{
    [ApiController]
    [Route("Order")]
    public class OrderController : ControllerBase
    {
        public readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<OrderDto>> GetById(int id)
        {
            return await _orderService.GetById(id);
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create([FromBody] OrderDto order)
        {
            return await _orderService.Create(order);
        }

        [HttpGet("orders")]
        public async Task<ActionResult<List<OrderDto>>> GetOrders()
        {
            var orders = await _orderService.GetOrders();
            return Ok(orders);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] OrderDto orderDto)
        {
            var updatedOrderDto = await _orderService.Update(orderDto);

            if (updatedOrderDto == null)
            {
                return NotFound();
            }

            return Ok(updatedOrderDto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _orderService.Delete(id);

            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}