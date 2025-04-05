using App.Core.Entities.OrderManagment;
using App.Core.Entities.ProductManagment;
using Microsoft.AspNetCore.Identity;

namespace App.Core.Entities.UserManagment
{
    public class AppUser : IdentityUser<string>
    {
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public bool IsActive { get; set; }
        public List<Question>? Questions { get; set; } // Kullanıcının sorduğu sorular
        public List<Rating>? Ratings { get; set; } // Kullanıcının yaptığı puanlamalar
        public List<Address>? Addresses { get; set; } // Kullanıcının adresleri
        public List<Order>? Orders { get; set; }     // Kullanıcının verdiği siparişler
        public List<Cart>? Carts { get; set; }        // Kullanıcının sepetleri
        public List<Comment>? Comments { get; set; } // Kullanıcının yaptığı yorumlar
    }
}