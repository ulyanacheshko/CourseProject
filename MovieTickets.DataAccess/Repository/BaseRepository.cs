
namespace MovieTickets.DataAccess.Repository
{
    public class BaseRepository
    {
        public readonly MovieTicketsDbContext _movieTicketsDbContext;

        public BaseRepository (MovieTicketsDbContext movieTicketsDbContext)
        {
            _movieTicketsDbContext = movieTicketsDbContext;
        }
    }
}
