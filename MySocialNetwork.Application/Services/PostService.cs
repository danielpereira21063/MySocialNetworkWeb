using MySocialNetwork.Domain.Entities.PostEntities;
using MySocialNetwork.Domain.Interfaces;
using MySocialNetwork.Domain.ViewModel.Post;

namespace MySocialNetwork.Application.Services
{
    public class PostService : IPostService
    {
        public PostViewModel? Create(PostViewModel? post)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PostViewModel>? FindAllByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        public PostViewModel? Find(int userId, int postId)
        {
            throw new NotImplementedException();
        }

        public PostViewModel? Remove(Post? post)
        {
            throw new NotImplementedException();
        }

        public PostViewModel? Update(PostViewModel? post)
        {
            throw new NotImplementedException();
        }
    }
}
