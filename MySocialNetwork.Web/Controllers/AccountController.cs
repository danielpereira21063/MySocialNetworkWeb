using Microsoft.AspNetCore.Mvc;
using MySocialNetwork.Application.Interfaces;
using MySocialNetwork.Application.Services;
using MySocialNetwork.Domain.Interfaces;
using MySocialNetwork.Domain.Validation;
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

        public IActionResult Index()
        {
            return RedirectToAction(nameof(Login));
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
        public IActionResult Register(UserViewModel data, string? passwordConfirmation)
        {

            ValidadeUserData(data, passwordConfirmation);

            _userService?.Create(data);

            return Redirect($"/Account/Welcome?userName=" + data.Name);
        }

        [HttpGet("/Account/Welcome")]
        public IActionResult Welcome(string userName)
        {

            if (string.IsNullOrEmpty(userName))
            {
                return Redirect("/");
            }

            ViewData["userName"] = userName;

            return View("../Account/Welcome");
        }


        private void ValidadeUserData(UserViewModel? obj, string? passwordConfirmation = "")
        {
            DomainException.When(obj == null, "Erro ao recuperar informações dos dados enviados.");
            DomainException.When(obj?.Password != passwordConfirmation, "As senhas não são iguais.");
        }
    }
}
