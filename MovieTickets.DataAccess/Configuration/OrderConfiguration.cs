using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieTickets.Entities;

namespace MovieTickets.DataAccess.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders", "dbo").HasKey(x => x.OrderId);
            builder.HasMany(_ => _.Tickets).WithOne(_ => _.Order).HasForeignKey(_ => _.OrderId);
        }
    }

}
