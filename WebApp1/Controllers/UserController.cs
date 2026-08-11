using Microsoft.AspNetCore.Mvc;
using WebApp1.Models;
using WebApp1.Services.Interfaces;

namespace WebApp1.Controllers
{
    [ApiController]
    [Route("/api/user")]
    public class UserController : ControllerBase
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public ActionResult CreateUser([FromBody] Users user)
        {
            _userService.CreateUser(user);
            // Logic to create a user
            Console.WriteLine(user.Name);
            Console.WriteLine(user.Id);
            Console.WriteLine(user.Email);
            Console.WriteLine(user.Password);

            return Ok();
        }
    }
}
