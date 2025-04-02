using App.Core.Entities.UserManagment;

namespace App.Core.Entities.ProductManagment
{
    public class Rating
    {
        public int Id { get; set; }
        public int Score { get; set; } // int'mi olmalı bunun kararı verilmeli!


        // Navigation properties
        public int UserId { get; set; }
        public AppUser User { get; set; } = new();


        public int ProductId { get; set; }
        public Product Product { get; set; } = new();
    }
}
