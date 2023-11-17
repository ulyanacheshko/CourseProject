namespace MovieTickets.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public String MovieTitle { get; set; }
        public DateTime MovieDateTime { get; set; }
        public int Amount { get; set; }
        public int seatNumber { get; set;}

    }
}