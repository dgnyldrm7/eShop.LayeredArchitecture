using App.Core.Entities.OrderManagment;
using App.Core.Entities.ProductManagment;
using Microsoft.AspNetCore.Identity;

namespace App.Core.Entities.UserManagment
{
    public class AppUser : IdentityUser
    {
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public List<Question>? Questions { get; set; }
        public List<Rating>? Ratings { get; set; }
        public List<Address>? Addresses { get; set; }
        public List<Order>? Orders { get; set; }
        public List<Cart>? Carts { get; set; }
        public List<Comment>? Comments { get; set; }
    }
}