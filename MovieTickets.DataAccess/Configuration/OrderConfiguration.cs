using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieTickets.Entities;

namespace MovieTickets.DataAccess.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders", "dbo").HasKey(x => x.Id);
            builder.HasMany(_ => _.Tickets).WithOne(_ => _.Order).HasForeignKey(_ => _.OrderId);
            builder.HasOne(_ => _.User).WithMany(_ => _.Orders).HasForeignKey(_ => _.UserId);
        }
    }

}
