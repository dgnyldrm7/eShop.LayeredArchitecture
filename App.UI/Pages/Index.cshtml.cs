using App.Core.Entities.ProductManagment;
using App.Services.Implementations;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.UI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private readonly ProductService _productService;

        public List<Product>? Products { get; set; }

        public IndexModel(ILogger<IndexModel> logger, ProductService productService)
        {
            _logger = logger;

            _productService = productService;
        }

        public async Task OnGet()
        {
            var products = await _productService.GetAllProductsAsync();

            Products = products.ToList();
        }
    }
}