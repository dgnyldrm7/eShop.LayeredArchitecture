using App.Core.Entities.SellerManagment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Persistance.Configurations.SellerConfiguration
{
    public class ModeratorConfiguration : IEntityTypeConfiguration<Moderator>
    {
        public void Configure(EntityTypeBuilder<Moderator> builder)
        {
            builder.HasKey(m => m.Id);

            builder.ToTable("Moderators");
        }
    }
}