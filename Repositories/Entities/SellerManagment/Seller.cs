using App.Core.Entities.ProductManagment;

namespace App.Core.Entities.SellerManagment
{
    public class Seller
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string UserName { get; set; } = default!;
        public string Password { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Phone { get; set; } = default!;
        public string Address { get; set; } = default!;
        public string LogoUrl { get; set; } = default!;
        public string BannerUrl { get; set; } = default!;

        // Navigation properties
        public List<Answer> Answers { get; set; } = new();
    }
}