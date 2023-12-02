using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieTickets.Entities;

namespace MovieTickets.DataAccess.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users", "dbo").HasKey(x => x.UserId);
            builder.HasMany(_ => _.Orders).WithOne(_ => _.User).HasForeignKey(_ => _.UserId);

        }
    }

}
