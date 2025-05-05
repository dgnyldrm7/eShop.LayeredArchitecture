using App.Core.Entities.ProductManagment;
using App.Core.Interfaces;
using App.Core.Interfaces.UnitOfWork;
using Microsoft.Extensions.Logging;

namespace App.Services.Implementations.ProductService
{
    public class ProductService
    {
        private readonly ILogger<ProductService> _logger;

        private readonly IGenericRepository<Product> _productRepository;

        private readonly ICacheService _cacheService;

        private readonly IUnitOfWork unitOfWork;

        public ProductService(IGenericRepository<Product> productRepository, ICacheService cacheService, ILogger<ProductService> logger, IUnitOfWork unitOfWork)
        {
            _productRepository = productRepository;
            _cacheService = cacheService;
            _logger = logger;
            this.unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            string cacheKey = "products";

            List<Product>? cached = _cacheService.Get<List<Product>>(cacheKey);

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
            _productRepository.Add(product);

            await unitOfWork.SaveChangesAsync(CancellationToken.None);
        }

        public async Task UpdateProductAsync(Product product)
        {
            _productRepository.Update(product);

            await unitOfWork.SaveChangesAsync(CancellationToken.None);
        }

        public async Task DeleteProductAsync(int id)
        {
            _productRepository.Delete(id);

            await unitOfWork.SaveChangesAsync(CancellationToken.None);
        }
    }
}