using App.Core.Entities.ProductManagment;
using App.Core.Interfaces;
using Microsoft.Extensions.Logging;

namespace App.Services.Implementations
{
    public class ProductService
    {
        private readonly ILogger<ProductService> _logger;

        private readonly IGenericRepository<Product> _productRepository;

        private readonly ICacheService _cacheService;

        public ProductService(IGenericRepository<Product> productRepository, ICacheService cacheService, ILogger<ProductService> logger)
        {
            _productRepository = productRepository;

            _cacheService = cacheService;
            _logger = logger;
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            string cacheKey = "products";

            List<Product>? cached =  _cacheService.Get<List<Product>>(cacheKey);

            if (cached != null)
            {
                _logger.LogInformation("Products are already in cache.");

                return cached;
            }

            var products = await _productRepository.GetAllAsync();

            _cacheService.Set(cacheKey, products.ToList(), TimeSpan.FromMinutes(5));

            _logger.LogInformation("Products are fetched from database and cached.");

            return products;
        }

        public async Task<Product?> GetProductByIdAsync(int id)
        {
            return await _productRepository.GetByIdAsync(id);
        }

        public async Task AddProductAsync(Product product)
        {
            await _productRepository.AddAsync(product);
        }

        public async Task UpdateProductAsync(Product product)
        {
            await _productRepository.UpdateAsync(product);
        }

        public async Task DeleteProductAsync(int id)
        {
            await _productRepository.DeleteAsync(id);
        }
    }
}