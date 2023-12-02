using System;
namespace MovieTickets.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Order> Orders { get; set; }
        public int OrderId { get; set; }

    }
}