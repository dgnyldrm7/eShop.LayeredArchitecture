using App.Core.Entities.UserManagment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Persistance.Configurations.UserConfiguration
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.HasKey(c => c.Id);

            builder.ToTable("Carts");

            builder.HasOne(c => c.AppUser)
                   .WithMany(u => u.Carts)
                   .HasForeignKey(c => c.UserId);
        }
    }
}
