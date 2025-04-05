namespace App.Core.Entities.ProductManagment
{
    public class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Slug { get; set; }
        public List<Product>? Products { get; set; }
    }
} 