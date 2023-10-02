using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShiningShoppingApp.Interfaces;
using ShiningShoppingApp.Models;

namespace ShiningShoppingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;
        public UserController(IUserService service)
        {
            _service = service;
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
    }
}
