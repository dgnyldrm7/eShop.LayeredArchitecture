using App.Core.Entities.ProductManagment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Persistance.Configurations.ProductConfiguration
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasKey(s => s.Id);

            builder.HasOne(s => s.Answer)
                .WithOne(s => s.Question)
                .HasForeignKey<Answer>(s => s.QuestionId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}