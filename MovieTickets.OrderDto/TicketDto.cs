using MovieTickets.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTickets.OrderDTO
{
    public class TicketDto : CreateTicketDto
    {
        public int Id { get; set; }
    }
}
