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

        public PostService(IMapper mapper, IPostRepository postRepository)
        {
            _mapper = mapper;
            _postRepository = postRepository;
        }

        public void Create(PostViewModel? entity)
        {
            var post = _mapper.Map<Post>(entity);

            //post.Images = _mapper.Map<List<Image>>(entity.Images);
            //post.User = _mapper.Map<User>(entity.User);

            _postRepository.Save(post);
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
            throw new NotImplementedException();
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
