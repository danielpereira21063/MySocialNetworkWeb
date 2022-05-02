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

        [HttpPost("/User/AddProfilePicture/{userId}")]
        public IActionResult AddProfilePicture(int userId, [FromBody] string base64Image)
        {
            var user = _userService.GetById(userId);

            if (user == null)
            {
                return NotFound("Usuário não encontrado.");
            }

            var byteImage = Convert.FromBase64String(base64Image);

            user.ProfilePicture = byteImage;

            _userService.Update(user);

            return Ok(user);
        }
    }
}
