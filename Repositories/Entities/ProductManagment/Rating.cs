using App.Core.Entities.UserManagment;

namespace App.Core.Entities.ProductManagment
{
    public class Rating
    { 
        public int Id { get; set; }
        public int Score { get; set; }
        public int UserId { get; set; }
        public AppUser? AppUser { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }
}