namespace MovieTickets.Entities
{
    public class Movie
    {
        public int MovieId { get; set; }
        public String MovieTitle { get; set; }
        public int MovieDuration { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}