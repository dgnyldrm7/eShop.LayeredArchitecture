using App.Core.Entities.SellerManagment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Persistance.SeedData.SellerSeed
{
    public class ModeratorSeedData : IEntityTypeConfiguration<Moderator>
    {
        public void Configure(EntityTypeBuilder<Moderator> builder)
        {
            builder.HasData(
            new Moderator
            {
                Id = 1,
                Name = "Hasan"
            }
            );
        }
    }
}