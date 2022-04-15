using Microsoft.AspNetCore.Mvc;
using MySocialNetwork.Application.Interfaces;
using MySocialNetwork.Application.Utils;
using MySocialNetwork.Domain.Enums;

namespace MySocialNetwork.WebUI.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
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
