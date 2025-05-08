using App.Core.Entities.ProductManagment;
using App.Core.Interfaces;
using App.Core.Interfaces.UnitOfWork;
using Microsoft.Extensions.Logging;

namespace App.Services.Services.Product
{
    public class ProductService
    {
        private readonly ILogger<ProductService> _logger;

        private readonly IGenericRepository<Product> _productRepository;

        private readonly IUnitOfWork unitOfWork;

        public ProductService(IGenericRepository<Product> productRepository, ILogger<ProductService> logger, IUnitOfWork unitOfWork)
        {
            _productRepository = productRepository;
            _logger = logger;
            this.unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            var products = await _productRepository.GetAllAsync();

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