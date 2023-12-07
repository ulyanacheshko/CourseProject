using Microsoft.EntityFrameworkCore;
using MovieTickets.DataAccess.Configuration;
using MovieTickets.Entities;

namespace MovieTickets.DataAccess
{
    public class MovieTicketsDbContext : DbContext
    {
        public MovieTicketsDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new TicketConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}