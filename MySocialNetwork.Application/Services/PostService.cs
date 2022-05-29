using AutoMapper;
using MySocialNetwork.Domain.Entities.PostEntities;
using MySocialNetwork.Domain.Interfaces;
using MySocialNetwork.Domain.ViewModel.Post;

namespace MySocialNetwork.Application.Services
{
    public class PostService : IPostService
    {
        private readonly IMapper _mapper;
        private readonly IPostRepository _postRepository;
        private readonly ILikeRepository _likeRepository;
        private readonly IUserRepository _userRepository;

        public PostService(IMapper mapper, IPostRepository postRepository, ILikeRepository likeRepository, IUserRepository userRepository)
        {
            _mapper = mapper;
            _postRepository = postRepository;
            _likeRepository = likeRepository;
            _userRepository = userRepository;
        }

        public void Create(PostViewModel? entity)
        {
            var post = _mapper.Map<Post>(entity);

            //post.Images = _mapper.Map<List<Image>>(entity.Images);
            //post.User = _mapper.Map<User>(entity.User);

            _postRepository.Save(post);
        }

        public void Like(int userId, int postId)
        {
            var userLike = _likeRepository.FindByPostId(postId, userId);

            if (userLike == null)
            {
                var newLike = new Like()
                {
                    IsLiked = true,
                    Post = _postRepository.Find(postId),
                    User = _userRepository.Find(userId)
                };

                _likeRepository.Save(newLike);
                return;
            }

            userLike.IsLiked = !userLike.IsLiked;
            _likeRepository.Update(userLike);
        }

        public List<PostViewModel>? GetAll(int userId)
        {
            throw new NotImplementedException();
        }

        public List<PostViewModel>? GetAll()
        {
            var posts = _postRepository.FindAll();
            return _mapper.Map<List<PostViewModel>>(posts);
        }

        public PostViewModel? GetById(int userId, int postId)
        {
            throw new NotImplementedException();
        }

        public PostViewModel? GetById(int id)
        {
            return _mapper.Map<PostViewModel>(_postRepository.Find(id));
        }

        public void Remove(PostViewModel? entity)
        {
            throw new NotImplementedException();
        }

        public void Update(PostViewModel? entity)
        {
            throw new NotImplementedException();
        }
    }
}
