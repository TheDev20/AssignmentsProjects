using ProductsAPI.Models;
using ProductsAPI.Reposittory.Interfaces;

namespace ProductsAPI.Services.Interfaces
{
    public interface IProductServices
    {
        public Product? GetProduct(Product product);
        object GetProductById(int id);
    }
}
