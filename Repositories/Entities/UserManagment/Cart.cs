using App.Core.Common.Entities;

namespace App.Core.Entities.UserManagment
{
    public class Cart : EntityBase<int>
    {
        public string? UserId { get; set; }
        public List<CartItem>? CartItems { get; set; }
        public AppUser? AppUser { get; set; }
        //public int TotalPrice => CartItems.Sum(item => item.TotalPrice);
    }
}