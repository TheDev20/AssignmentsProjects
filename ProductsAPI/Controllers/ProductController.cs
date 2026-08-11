using Microsoft.AspNetCore.Mvc;
using ProductsAPI.Reposittory.Interfaces;
using ProductsAPI.Services;
using ProductsAPI.Services.Interfaces;

namespace ProductsAPI.Controllers
{
    [ApiController]
    [Route("/api/products")]
    public class ProductsController : ControllerBase
    {
        private IProductServices _productServices;

        public ProductsController(IProductServices productServices)
        {
            _productServices = productServices;
        }

        [HttpGet("Id")]
        public ActionResult GetProduct(int id)
        {
            if (_productServices.GetProductById(id) == null)
            {
                return NotFound();
            }
            return Ok(_productServices.GetProductById(id));
        }
    }
}
