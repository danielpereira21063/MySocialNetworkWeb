using MySocialNetwork.Domain.Entities.PostEntities;
using MySocialNetwork.Domain.Interfaces;
using MySocialNetwork.Domain.ViewModel.Post;

namespace MySocialNetwork.Application.Services
{
    public class PostService : IPostService
    {
        public void Create(PostViewModel? entity)
        {
            throw new NotImplementedException();
        }

        public List<PostViewModel>? GetAll(int userId)
        {
            throw new NotImplementedException();
        }

        public List<PostViewModel>? GetAll()
        {
            throw new NotImplementedException();
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
