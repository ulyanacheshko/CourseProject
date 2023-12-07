using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieTickets.Entities;

namespace MovieTickets.DataAccess.Configuration
{
    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.ToTable("Tickets", "dbo").HasKey(x => x.Id);
            builder.HasOne(_ => _.Order).WithMany(_ => _.Tickets).HasForeignKey(_ => _.OrderId);

        }
    }

}