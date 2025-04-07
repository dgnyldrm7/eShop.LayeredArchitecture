using App.Core.Entities.ProductManagment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Persistance.SeedData.ProductSeed
{
    public class AnswerSeedData : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            builder.HasData(
            new Answer
            {                
                Id = 1,
                SellerId = 1,
                QuestionId = 1,
                Message = "Evet, bu ürün yeşil renklidir efendim !!",
                CreatedAt = DateTime.UtcNow,
            }
          );
        }
    }
}
