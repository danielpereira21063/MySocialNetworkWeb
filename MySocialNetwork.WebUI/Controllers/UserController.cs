using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MySocialNetwork.Application.Interfaces;
using MySocialNetwork.Domain.Enums;

namespace MySocialNetwork.WebUI.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public IActionResult Account()
        {
            return View();
        }

        [HttpGet("/User/Profile/{userId}")]
        public IActionResult Profile(int userId)
        {
            var user = _userService.GetById(userId);

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        public IActionResult GetUserProfileById(int userId)
        {
            var user = _userService.GetById(userId);

            return Json(user);
        }

        [HttpGet("/User/GetLogged")]
        public IActionResult GetLoggedUser()
        {
            var userViewModel = _userService.GetByEmail(User.Identity.Name);

            return Json(new
            {
                id = userViewModel.Id,
                firstName = userViewModel.Name.Split(" ")[0],
                fullName = userViewModel.Name ?? "",
                genre = Enum.Parse<Genre>(userViewModel.Genre.ToString()).ToString(),
                birthDate = userViewModel.BirthDate
            });
        }
    }
}
