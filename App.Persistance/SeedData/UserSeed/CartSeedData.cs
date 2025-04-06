using App.Core.Entities.UserManagment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Persistance.SeedData.UserSeed
{
    public class CartSeedData : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.HasData(
            new Cart
            {
                Id = 1,
                UserId = 1,
            }    
            );
        }
    }
}
