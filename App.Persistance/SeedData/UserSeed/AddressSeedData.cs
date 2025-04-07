using App.Core.Entities.UserManagment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Persistance.SeedData.UserSeed
{
    public class AddressSeedData : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasData(
            new Address
            {                
                Id = 1,
                UserId = "1",
                City = "New York",
                District = "Manhattan",
                Street = "5th Avenue",
                ZipCode = "10001",
                PhoneNumber = "123-456-7890",
                ReceiverName = "John Doe",
                IsDefault = true,                
            }
            );
        }
    }
}