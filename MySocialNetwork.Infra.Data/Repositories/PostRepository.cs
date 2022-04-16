using MySocialNetwork.Domain.Entities.PostEntities;
using MySocialNetwork.Domain.Interfaces;
using MySocialNetwork.Infra.Data.Context;

namespace MySocialNetwork.Infra.Data.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly ApplicationDbContext _context;

        public PostRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Post? Save(Post post)
        {
            _context.Add(post);
            return post;
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
