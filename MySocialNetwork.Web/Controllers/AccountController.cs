using Microsoft.AspNetCore.Mvc;
using MySocialNetwork.Application.Interfaces;
using MySocialNetwork.Application.Services;
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

            ValidadeUSerData(data, passwordConfirmation);

            _userService?.Create(data);

            return Redirect("/");
        }


        private void ValidadeUSerData(UserViewModel? obj, string? passwordConfirmation = "")
        {
            DomainException.When(obj == null, "Erro ao recuperar informações dos dados enviados.");
            DomainException.When(obj?.Password != passwordConfirmation, "As senhas não são iguais.");
        }
    }
}
