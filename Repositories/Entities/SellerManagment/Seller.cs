using App.Core.Common.Entities;
using App.Core.Entities.ProductManagment;
using App.Core.Entities.PromotionManagment;

namespace App.Core.Entities.SellerManagment
{
    public class Seller : EntityBase<int>
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? LogoUrl { get; set; }
        public string? BannerUrl { get; set; }
        public List<Answer>? Answers { get; set; }
        public List<Product>? Products { get; set; }
        public List<Coupon>? Coupons { get; set; }
    }
}