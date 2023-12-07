namespace MovieTickets.OrderDTO
{
    public class CreateOrderDto
    { 
        public int Amount { get; set; }
        public int ? UserId { get; set; }
    }
}
