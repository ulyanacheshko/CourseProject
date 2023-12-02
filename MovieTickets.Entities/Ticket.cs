namespace MovieTickets.Entities
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public Movie Movie { get; set; }
        public int MovieId { get; set; }
        public DateTime MovieDateTime { get; set; }
        public int HallNumber { get; set; }
        public int SeatNumber { get; set; }
        public Order Order { get; set; }
        public int OrderId { get; set; }
      
    }
}