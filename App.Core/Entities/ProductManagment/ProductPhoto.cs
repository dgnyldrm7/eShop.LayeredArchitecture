using App.Core.Common.Entities;

namespace App.Core.Entities.ProductManagment
{
    public class ProductPhoto : EntityBase<int>
    {
        public string Url { get; set; } = default!;
        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }
} 