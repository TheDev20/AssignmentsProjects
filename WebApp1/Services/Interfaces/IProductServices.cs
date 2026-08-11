using WebApp1.Models;

namespace WebApp1.Services.Interfaces
{
    public interface IProductServices
    {
        Product? GetProductById(int id);

        public IEnumerable<Product>? GetAllProducts();

        public void CreateProduct(Product product);
        public void UpdateProduct(int id, Product product);

        public void DeleteProduct(int id);
    }
}
