using Microsoft.AspNetCore.Mvc;
using MySocialNetwork.Application.Interfaces;
using MySocialNetwork.Application.Utils;
using MySocialNetwork.Domain.Enums;
using MySocialNetwork.Domain.Validation;
using MySocialNetwork.Domain.ViewModel.User;

namespace MySocialNetwork.WebUI.Controllers
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
            ViewBag.Message = "";

            return View();
        }

        [HttpPost]
        public IActionResult Register(UserRegisterViewModel data)
        {
            _ValidadeUserData(data);

            //tratar isso de uma melhor forma
            if (data.Password != data.PasswordConfirmation)
            {
                ViewBag.Message = "As senhas não são iguais";

                return View(data);
            }

            var emailExists = _userService.GetByEmail(data.Email);

            if (emailExists != null)
            {
                ViewBag.Message = "Este email já foi cadastrado";

                return View(data);

            }

            var userVM = _UserRegisterViewModel_To_UserViewModel(data);

            _userService?.Create(userVM);

            return Redirect($"/Account/Welcome?userName={data.Name}");
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

        public IActionResult GetAllGenres()
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

            return Json(genres);
        }


        private void _ValidadeUserData(UserRegisterViewModel? obj)
        {
            DomainException.When(obj == null, "Erro ao recuperar informações dos dados enviados.");
        }

        private UserViewModel _UserRegisterViewModel_To_UserViewModel(UserRegisterViewModel obj)
        {
            var userVM = new UserViewModel()
            {
                Id = 0,
                Email = obj.Email,
                BirthDate = obj.BirthDate,
                Name = obj.Name,
                Genre = Enum.Parse<Genre>(obj.Genre)
            };
            userVM.Addresses.Add(obj.Address);

            return userVM;
        }
    }
}
