using ProductsAPI.Models;

namespace ProductsAPI.Reposittory.Interfaces
{
    public interface IProductRepo
    {
        public Product? GetProductById(int id);
    }
}
