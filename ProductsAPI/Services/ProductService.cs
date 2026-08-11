using ProductsAPI.Models;
using ProductsAPI.Reposittory.Interfaces;
using ProductsAPI.Services.Interfaces;

namespace ProductsAPI.Services
{
    public class ProductService : IProductServices
    {
        private IProductRepo repo;

        public ProductService(IProductRepo ProductRepo)
        {
            repo = ProductRepo;
        }

        public Product? GetProduct(Product product)
        {
            return repo.GetProductById(product.Id);
        }
    }
}
