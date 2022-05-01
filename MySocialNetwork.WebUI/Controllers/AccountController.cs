using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MySocialNetwork.Application.Interfaces;
using MySocialNetwork.Application.Utils;
using MySocialNetwork.Domain.Account;
using MySocialNetwork.Domain.Enums;
using MySocialNetwork.Domain.Validation;
using MySocialNetwork.Domain.ValueObjects;
using MySocialNetwork.Domain.ViewModel.User;
using MySocialNetwork.WebUI.Models.ViewModels;

namespace MySocialNetwork.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService? _userService;
        private readonly IAuthenticate _authentication;

        public AccountController(IUserService? userService, IAuthenticate authenticate)
        {
            _userService = userService;
            _authentication = authenticate;
        }

        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login(string returnUrl)
        {
            return View(new LoginViewModel { ReturnUrl = returnUrl });
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            var result = await _authentication.Authenticate(model.Email, model.Password);

            if (!result)
            {
                ModelState.AddModelError(string.Empty, "Email ou senha incorretos");
                return View(model);
            }

            if (string.IsNullOrEmpty(model.ReturnUrl))
            {
                return Redirect("/");
            }

            return Redirect(model.ReturnUrl);
        }

        public IActionResult Register()
        {
            ViewBag.Message = "";
            var genres = GetAllGenres();

            ViewBag.Genres = new SelectList(genres, "value", "description");

            return View();
        }

        [HttpPost]
        public IActionResult Register(ObjectExampleUser data)
        {
            _ValidadeUserData(data);

            //tratar isso de uma melhor forma
            if (data.Password != data.PasswordConfirmation)
            {
                ViewBag.Message = "As senhas não são iguais";
                return View(data);
            }

            bool emailExists = _userService?.GetByEmail(data.Email) != null;

            if (emailExists)
            {
                ViewBag.Message = "Este email já foi cadastrado";
                return View(data);
            }

            var result = _authentication.RegisterUser(data.Email, data.Password).Result;

            if (!result)
            {
                ViewBag.Message = "Ocorreu um erro ao registrar seu usuário!\nPor favor, entre em contato com o desenvolvedor e informe o problema.";
                return View(data);
            }

            var newUserViewModel = _ObjectExampleUser_To_UserViewModel(data);

            _userService?.Create(newUserViewModel);

            bool userHasBeenRegistered = _userService?.GetByEmail(data.Email) != null;

            if (!userHasBeenRegistered)
            {
                ViewBag.Message = "Ocorreu um erro ao registrar seu usuário!\nPor favor, entre em contato com o desenvolvedor e informe o problema.";
                return View(data);
            }

            return Redirect($"/Account/Welcome?userName={data?.Name}");
        }

        public async Task<IActionResult> Logout()
        {
            await _authentication.Logout();

            return Redirect("/");
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

        public List<object> GetAllGenres()
        {
            var genres = new List<object>();
            var enumGenres = ExEnum.GetCombo<Genre>();

            foreach (var genre in enumGenres)
            {
                genres.Add(new
                {
                    description = genre.Key.ToString(),
                    value = genre.Value.ToString()
                });
            }

            return genres;
        }

        private void _ValidadeUserData(ObjectExampleUser? obj)
        {
            DomainException.When(obj == null, "Erro ao recuperar informações dos dados enviados.");
        }

        private UserViewModel _ObjectExampleUser_To_UserViewModel(ObjectExampleUser obj)
        {
            var userVM = new UserViewModel()
            {
                Id = 0,
                Email = obj.Email,
                BirthDate = obj.BirthDate,
                Name = obj.Name,
                Genre = Enum.Parse<Genre>(obj.Genre)
            };
            //userVM.Addresses.Add(obj.Address);

            return userVM;
        }
    }
}
