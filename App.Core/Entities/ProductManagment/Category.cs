using App.Core.Common.Entities;

namespace App.Core.Entities.ProductManagment
{
    public class Category : EntityBase<int>
    {
        public string? Name { get; set; }
        public string? Slug { get; set; }
        public List<Product>? Products { get; set; }
    }
} 