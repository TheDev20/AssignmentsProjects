using ProductsAPI.Models;
using ProductsAPI.Reposittory.Interfaces;

namespace ProductsAPI.Reposittory
{
    public class ProductRepo : IProductRepo
    {
        private List<Product> _products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Laptop",
                Price = 1000.0m,
            },
            new Product
            {
                Id = 2,
                Name = "Phone",
                Price = 700.0m,
            },
            new Product
            {
                Id = 3,
                Name = "Keyboard",
                Price = 100.0m,
            },
        };

        public Product? GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }
    }
}
