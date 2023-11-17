using Microsoft.EntityFrameworkCore;
using MovieTickets.Entities;

namespace MovieTickets.DataAccess
{
    public class MovieTicketsDbContext : DbContext
    {
        public MovieTicketsDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Movie> Movies { get; set; }
    }
}