using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MySocialNetwork.Application.Interfaces;
using MySocialNetwork.Domain.Interfaces;
using MySocialNetwork.Domain.ValueObjects;
using MySocialNetwork.Domain.ViewModel.Comment;
using MySocialNetwork.Domain.ViewModel.Image;
using MySocialNetwork.Domain.ViewModel.Post;

namespace MySocialNetwork.WebUI.Controllers
{
    [Authorize]
    public class PostController : Controller
    {
        private readonly IPostService _postService;
        private readonly ILikeService _likeService;
        private readonly ICommentService _commentService;
        private readonly IUserService _userService;

        public PostController(IPostService postService, IUserService userService, ILikeService likeService, ICommentService commentService)
        {
            _postService = postService;
            _likeService = likeService;
            _commentService = commentService;
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

        [HttpPost("/post/comment/{postId}")]
        public IActionResult Comment(int postId, [FromBody] string comment)
        {
            var newComment = new CommentViewModel()
            {
                Post = _postService.GetById(postId),
                Text = comment,
                User = _userService.GetByEmail(User.Identity.Name)
            };

            _commentService.Create(newComment);
            return Ok();
        }
    }
}
