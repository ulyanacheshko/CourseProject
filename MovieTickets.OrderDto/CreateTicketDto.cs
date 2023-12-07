namespace MovieTickets.OrderDTO
{
    public class CreateTicketDto
    {
        public DateTime MovieDateTime { get; set; }
        public int HallNumber { get; set; }
        public int SeatNumber { get; set; }
    }
}