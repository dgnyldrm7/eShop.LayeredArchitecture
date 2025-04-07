using App.Core.Entities.ProductManagment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Persistance.SeedData.ProductSeed
{
    public class CommentSeedData : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasData(
            new Comment
            {
                Id = 1,
                Message = "Bu ürün çok güzel, tavsiye ederim.",
                ProductId = 1,
                UserId = "1",
                CreatedAt = DateTime.UtcNow,
            }
            );
        }
    }
}