using Microsoft.AspNetCore.Mvc;
using WebApp1.Models;
using WebApp1.Services.Interfaces;

namespace WebApp1.Controllers
{
    [ApiController]
    [Route("/api/product")]
    public class ProductsController : ControllerBase
    {
        private IProductServices _productServices;

        public ProductsController(IProductServices productServices)
        {
            _productServices = productServices;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            if (_productServices.GetAllProducts() == null)
            {
                return NotFound();
            }
            return Ok(_productServices.GetAllProducts());
        }

        [HttpGet("{Id}")]
        public ActionResult GetProduct(int id)
        {
            if (_productServices.GetProductById(id) == null)
            {
                return NotFound();
            }
            return Ok(_productServices.GetProductById(id));
        }

        [HttpPost]
        public ActionResult CreateProduct(Product product)
        {
            _productServices.CreateProduct(product);
            return Created();
        }

        [HttpPut("{id}")]
        public ActionResult UpdateProduct(int id, Product product)
        {
            if (_productServices.GetProductById(id) == null)
            {
                return NotFound();
            }
            _productServices.UpdateProduct(id, product);

            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteProduct(int id)
        {
            if (_productServices.GetProductById(id) == null)
            {
                return NotFound();
            }
            _productServices.DeleteProduct(id);
            return Ok();
        }
    }
}
