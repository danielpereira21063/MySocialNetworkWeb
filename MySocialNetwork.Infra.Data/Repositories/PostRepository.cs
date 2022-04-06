using MySocialNetwork.Domain.Entities.PostEntities;
using MySocialNetwork.Domain.Interfaces;

namespace MySocialNetwork.Infra.Data.Repositories
{
    public class PostRepository : IPostRepository
    {
        public Post? Create(Post post)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post>? FindAll(int userId)
        {
            throw new NotImplementedException();
        }

        public Post? Find(int userId, int postId)
        {
            throw new NotImplementedException();
        }

        public Post? Remove(Post post)
        {
            throw new NotImplementedException();
        }

        public Post? Update(Post post)
        {
            throw new NotImplementedException();
        }
    }
}
