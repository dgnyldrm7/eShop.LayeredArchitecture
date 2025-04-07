using App.Core.Entities.ProductManagment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Persistance.SeedData.ProductSeed
{
    public class QuestionSeedData : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasData(
            new Question
            {                
                Id = 1,
                ProductId = 1,
                UserId = "1",
                AnswerId = 1,
                Message = "Bu ürün orijinal mi?",
                IsAnswered = true,
            }
            );
        }
    }
}
