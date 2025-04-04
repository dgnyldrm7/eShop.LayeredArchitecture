namespace App.Core.Entities.UserManagment
{
    public class Cart
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public List<CartItem> CartItems { get; set; } = new();
        public AppUser AppUser { get; set; } = new();
        public int TotalPrice => CartItems.Sum(item => item.TotalPrice);
    }
}