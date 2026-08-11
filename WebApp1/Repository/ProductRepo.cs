using System.Collections.Generic;
using System.Linq;
using WebApp1.Models;
using WebApp1.Repository.Interfaces;

namespace WebApp1.Repository
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

        public IEnumerable<Product>? GetAllProducts()
        {
            return _products;
        }

        public void CreateProduct(Product product)
        {
            _products.Add(product);
        }

        public void UpdateProduct(int id, Product product)
        {
            var existingProduct = _products.FirstOrDefault(p => p.Id == id);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Price = product.Price;
            }
        }

        public void DeleteProduct(int id)
        {
            var productToDelete = _products.FirstOrDefault(p => p.Id == id);
            if (productToDelete != null)
            {
                _products.Remove(productToDelete);
            }
        }
    }
}
