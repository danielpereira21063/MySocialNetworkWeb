using Microsoft.AspNetCore.Mvc;
using MySocialNetwork.Application.Interfaces;

namespace MySocialNetwork.API.Controllers
{
    public class UserController : Controller
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

            return Json(users);
        }

        [HttpGet("/User/GetByEmail")]
        public IActionResult GetUserByEmail(string email)
        {
            var user = _userService.GetByEmail(email);
            return Json(user);
        }
    }
}
