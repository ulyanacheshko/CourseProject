namespace MovieTickets.Entities
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public String MovieTitle { get; set; }
        public DateTime MovieDateTime { get; set; }
        public int HallNumber { get; set; }

    }
}