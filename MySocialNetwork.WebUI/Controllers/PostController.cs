using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MySocialNetwork.Application.Interfaces;
using MySocialNetwork.Domain.Interfaces;
using MySocialNetwork.Domain.ValueObjects;
using MySocialNetwork.Domain.ViewModel.Image;
using MySocialNetwork.Domain.ViewModel.Post;
using MySocialNetwork.Domain.ViewModel.User;

namespace MySocialNetwork.WebUI.Controllers
{
    [Authorize]
    public class PostController : Controller
    {
        private readonly IPostService _postService;
        private readonly IUserService _userService;
        private readonly ILikeService _likeService;

        public PostController(IPostService postService, IUserService userService, ILikeService likeService)
        {
            _postService = postService;
            _userService = userService;
            _likeService = likeService;
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
        public IActionResult Create([FromBody] ObjectExamplePost data)
        {
            var postViewModel = _NewPostViewModelToPostViewModel(data);

            _postService.Create(postViewModel);

            return Ok();
        }

        private PostViewModel _NewPostViewModelToPostViewModel(ObjectExamplePost obj)
        {
            var postViewModel = new PostViewModel
            {
                Subtitle = obj.Subtitle,
                Images = new List<ImageViewModel>(),
                UserId = _userService.GetByEmail(User.Identity.Name).Id


            };

            foreach (var img in obj.Images)
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

            var idx = 0;
            foreach (var post in posts)
            {
                posts[idx].QtyLikes = _likeService.GetQtyLikes(post.Id);
                post.ImagesId = new List<int>();
                idx++;
            }

            return Ok(posts);
        }

        [HttpPut("/post/like/{postId}")]
        public IActionResult Like(int postId)
        {
            var user = _userService.GetByEmail(User.Identity.Name);
            if (user == null)
            {
                return NotFound("Usuário não encontrado.");
            }
            _postService.Like(user.Id, postId);
            return Ok();
        }
    }
}
