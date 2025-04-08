using App.Core.Entities.ProductManagment;
using App.Services.Implementations.ProductService;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.UI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ProductService _productService;

        public List<Product>? Products { get; set; }

        public IndexModel(ProductService productService)
        {
            _productService = productService;
        }

        public async Task OnGet()
        {
            var products = await _productService.GetAllProductsAsync();

            Products = products.ToList();
        }
    }
}