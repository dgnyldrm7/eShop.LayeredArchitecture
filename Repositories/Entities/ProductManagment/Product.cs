namespace App.Core.Entities.ProductManagment
{
    public sealed class Product
    {
        public int Id { get; set; }

        public string Name { get; set; } = default!;

        public string Slug { get; set; } = default!;

        public string Description { get; set; } = default!;

        public bool IsActive { get; set; } = true;

        public int Stock { get; set; }

        public string BranName { get; set; } = default!;

        public string FirstPhotoUrl { get; set; } = default!;

        public decimal RegularPrice { get; set; }

        public decimal DiscountPrice { get; set; }


        // Navigation properties
        public List<ProductPhotos> Images { get; set; } = new();

        public List<Rating> Rating { get; set; } = new();

        public List<Comment> Comments { get; set; } = new();

        public Category Category { get; set; } = new();
    }
}
