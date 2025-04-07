namespace App.Core.Entities.UserManagment
{
    public class Cart
    {
        public int Id { get; set; }
        public string UserId { get; set; } = default!;
        public List<CartItem> CartItems { get; set; }
        public AppUser AppUser { get; set; }
        //public int TotalPrice => CartItems.Sum(item => item.TotalPrice);
    }
}