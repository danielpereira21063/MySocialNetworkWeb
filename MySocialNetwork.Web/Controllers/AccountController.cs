using Microsoft.AspNetCore.Mvc;
using MySocialNetwork.Application.Interfaces;
using MySocialNetwork.Application.Services;
using MySocialNetwork.Domain.ViewModel.User;

namespace MySocialNetworkWeb.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService? _userService;

        public AccountController(IUserService? userService)
        {
            _userService = userService;
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(UserViewModel? data)
        {
            if(data == null)
            {
                return BadRequest();
            }

            _userService.Create(data);

            return Redirect("/");
        }
    }
}
