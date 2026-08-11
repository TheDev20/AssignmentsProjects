using WebApp1.Models;
using WebApp1.Repository.Interfaces;
using WebApp1.Services.Interfaces;

namespace WebApp1.Services
{
    public class ProductService : IProductServices
    {
        private IProductRepo repo;

        public ProductService(IProductRepo ProductRepo)
        {
            repo = ProductRepo;
        }

        public Product? GetProductById(int id)
        {
            return repo.GetProductById(id);
        }

        public IEnumerable<Product>? GetAllProducts()
        {
            return repo.GetAllProducts();
        }

        public void CreateProduct(Product product)
        {
            repo.CreateProduct(product);
        }

        public void UpdateProduct(int id, Product product)
        {
            repo.UpdateProduct(id, product);
        }

        public void DeleteProduct(int id)
        {
            repo.DeleteProduct(id);
        }
    }
}
