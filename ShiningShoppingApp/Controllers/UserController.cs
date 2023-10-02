using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShiningShoppingApp.Interfaces;
using ShiningShoppingApp.Models;
using System.Runtime.InteropServices;

namespace ShiningShoppingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;
        private readonly ICartService _cartService;
        public UserController(IUserService service , ICartService cartService)
        {
            _service = service;
            _cartService = cartService;
        }
        [HttpPost("Login")]
        public ActionResult Login(Login loginDTO)
        {
            var result = _service.Login(loginDTO);
            if (result == null)
            {
                return BadRequest();
            }
            return Ok(result);
        }

        [HttpPost("Register")]
        public ActionResult Register(Users loginDTO )
        {
            Console.WriteLine("Hello Register");
            var result = _service.Register(loginDTO);
            if (result == null){
                return BadRequest();
            }
            return Ok(result);
         }
        [HttpGet("{Id}/cart")]
        public ActionResult CartDetailsByUserId(int Id)
        {
            var cartDetails = _cartService.GetCart(Id);
            if (cartDetails == null)
            {
                return NotFound("No record found");
            }
            return Ok(cartDetails);
        }

        [HttpPost("{Id}/cart")]
        public ActionResult AddCartDetailsByUserId(int Id, CartProducts cartProduct)
        {
            var cartDetails = _cartService.AddCart(Id,cartProduct);
            if (cartDetails == null)
            {
                return NotFound("No record found");
            }
            return Created("",cartDetails);
        }
        [HttpPut("{Id}/cart")]
        public ActionResult UpdateCartByUserId(int Id, List<CartProducts> cartProduct)
        {
            var cartDetails = _cartService.UpdateCart(Id, cartProduct);
            if (cartDetails == null)
            {
                return NotFound("No record found");
            }
            return Ok(cartDetails);
        }
    }
}
