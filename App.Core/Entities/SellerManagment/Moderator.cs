using App.Core.Common.Entities;

namespace App.Core.Entities.SellerManagment
{
    public class Moderator : EntityBase<int>
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
