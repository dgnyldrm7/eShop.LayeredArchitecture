using App.Core.Entities.OrderManagment;
using App.Core.Entities.ProductManagment;
using App.Core.Entities.PromotionManagment;
using App.Core.Entities.SellerManagment;
using App.Core.Entities.UserManagment;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace App.Persistance.DbContext
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        {
        }

        //Order Management
        public DbSet<Order> orders { get; set; }
        public DbSet<OrderItem> orderItems { get; set; }
        public DbSet<Payment> payments { get; set; }
        public DbSet<Shipping> shippings { get; set; }
        public DbSet<Transaction> transactions { get; set; }

        //Product Management
        public DbSet<Answer> answers { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Comment> comments { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<ProductPhoto> productPhotos { get; set; }
        public DbSet<Question> questions { get; set; }
        public DbSet<Rating> ratings { get; set; }

        //Promotion Management
        public DbSet<Coupon> coupons { get; set; }
        public DbSet<UserCoupon> userCoupons { get; set; }

        //Seller Management
        public DbSet<Seller> sellers { get; set; }
        public DbSet<Moderator> moderators { get; set; }

        //User Management
        public DbSet<Address> addresses { get; set; }
        public DbSet<AppRole> appRoles { get; set; }
        public DbSet<AppUser> appUsers { get; set; }
        public DbSet<Cart> carts { get; set; }
        public DbSet<CartItem> cartItems { get; set; }
        public DbSet<Favorite> favorites { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}