using App.Core.Entities.UserManagment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Persistance.SeedData.UserSeed
{
    public class CartItemSeedData : IEntityTypeConfiguration<CartItem>
    {
        public void Configure(EntityTypeBuilder<CartItem> builder)
        {
            builder.HasData(
            new CartItem
            {
                Id = 1,
                CartId = 1,
                ProductId = 1,
                Quantity = 2,                
            }
            );
        }
    }
}
