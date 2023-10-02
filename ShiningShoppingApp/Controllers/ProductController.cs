using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShiningShoppingApp.Interfaces;
using ShiningShoppingApp.Models;

namespace ShiningShoppingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;
        public ProductController(IProductService service)
        {
            _service = service;
        }
        [HttpPost("add")]
        public ActionResult AddProduct(Product productDetails)
        {
            var result = _service.Add(productDetails);
            if (result == null)
            {
                return BadRequest();
            }
            return Ok(result);
        }

       /* [HttpGet]
        public ActionResult GetProduct(int productId)
        {
            Console.WriteLine("Hello Register");
            var result = _service.GetById(productId);
            if (result == null)
            {
                return BadRequest();
            }
            return Ok(result);
        }
       */
        [HttpGet]
        public ActionResult GetProducts()
        {
            var result = _service.GetAll();
            if (result == null)
            {
                return BadRequest();
            }
            return Ok(result);
        }
    }
}
