using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShiningShoppingApp.Interfaces;
using System.Security.Cryptography.X509Certificates;

namespace ShiningShoppingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartService _service;
        public CartController(ICartService service)
        {
            _service = service;
        }
      
    }
}
