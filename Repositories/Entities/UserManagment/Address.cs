namespace App.Core.Entities.UserManagment
{
    public class Address
    {
        public int Id { get; set; }
        public string City { get; set; } = default!;
        public string District { get; set; } = default!;
        public string Street { get; set; } = default!;
        public string ZipCode { get; set; } = default!;
        public string PhoneNumber { get; set; } = default!;
        public string ReceiverName { get; set; } = default!;
        public bool IsDefault { get; set; } = false;
        public int UserId { get; set; }
        public AppUser AppUser { get; set; } = new();
    }
}