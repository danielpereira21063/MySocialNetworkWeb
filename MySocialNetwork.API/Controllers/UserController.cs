using Microsoft.AspNetCore.Mvc;
using MySocialNetwork.Application.Interfaces;

namespace MySocialNetwork.API.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("/User/GetAll")]
        public IActionResult GetAllUsers(string searchString)
        {
            var users = _userService.GetAll(searchString);

            return Ok(users);
        }

        [HttpGet("/User/GetByEmail")]
        public IActionResult GetUserByEmail(string email)
        {
            var user = _userService.GetByEmail(email);
            return Ok(user);
        }
    }
}
