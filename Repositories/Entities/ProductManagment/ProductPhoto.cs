namespace App.Core.Entities.ProductManagment
{
    public class ProductPhoto
    {
        public int Id { get; set; }
        public string Url { get; set; } = default!;
        public int ProductId { get; set; }
        public Product Product { get; set; } = new();
    }
} 