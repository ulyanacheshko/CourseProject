namespace MovieTickets.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public List<Ticket>? Tickets { get; set; }
        public int Amount { get; set; }
        public User? User { get; set; }
        public int? UserId { get; set; }
        public int? TicketId { get; set; }

    }
}