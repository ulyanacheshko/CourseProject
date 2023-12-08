using Microsoft.AspNetCore.Mvc;
using MovieTickets.OrderDTO;
using MovieTickets.Services;
using MovieTickets.Services.Contracts;

namespace TicketController.Controllers
{
    [ApiController]
    [Route("Ticket")]
    public class TicketController : ControllerBase
    {
        public readonly ITicketService _ticketService;
        public TicketController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TicketDto>> GetById(int id)
        {
            return await _ticketService.GetById(id);
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create([FromBody] TicketDto ticket)
        {
            return await _ticketService.Create(ticket);
        }

        [HttpGet("tickets")]
        public async Task<ActionResult<List<TicketDto>>> GetTickets()
        {
            var tickets = await _ticketService.GetTickets();
            return Ok(tickets);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] TicketDto ticketDto)
        {
            var updatedTicketDto = await _ticketService.Update(ticketDto);

            if (updatedTicketDto == null)
            {
                return NotFound();
            }

            return Ok(updatedTicketDto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _ticketService.Delete(id);

            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}