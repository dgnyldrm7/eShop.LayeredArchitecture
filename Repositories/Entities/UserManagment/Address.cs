using App.Core.Common.Entities;

namespace App.Core.Entities.UserManagment
{
    public class Address : EntityBase<int>
    {
        public string? City { get; set; }
        public string? District { get; set; }
        public string? Street { get; set; }
        public string? ZipCode { get; set; }
        public string? PhoneNumber { get; set; }
        public string? ReceiverName { get; set; }
        public bool IsDefault { get; set; }
        public string? UserId { get; set; }
        public AppUser? AppUser { get; set; }
    }
}