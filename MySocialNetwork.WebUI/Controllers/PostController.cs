using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MySocialNetwork.Application.Interfaces;
using MySocialNetwork.Domain.Interfaces;
using MySocialNetwork.Domain.ViewModel.Image;
using MySocialNetwork.Domain.ViewModel.Post;
using MySocialNetwork.WebUI.Models.ViewModels;

namespace MySocialNetwork.WebUI.Controllers
{
    [Authorize]
    public class PostController : Controller
    {
        private readonly IPostService _postService;
        private readonly IUserService _userService;

        public PostController(IPostService postService, IUserService userService)
        {
            _postService = postService;
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([FromBody] NewPostViewModel model)
        {
            var postViewModel = _NewPostViewModelToPostViewModel(model);

            _postService.Create(postViewModel);

            return Ok();
        }

        private PostViewModel _NewPostViewModelToPostViewModel(NewPostViewModel model)
        {
            var postViewModel = new PostViewModel
            {
                Subtitle = model.Subtitle,
                Images = new List<ImageViewModel>(),
                UserId = _userService.GetByEmail(User.Identity.Name).Id
            };

            foreach (var img in model.Images)
            {
                postViewModel.Images.Add(new ImageViewModel
                {
                    File = Convert.FromBase64String(img.File)
                });
            }

            return postViewModel;
        }

        public IActionResult GetAll()
        {
            var posts = _postService.GetAll();
            return Json(posts);
        }
    }
}
