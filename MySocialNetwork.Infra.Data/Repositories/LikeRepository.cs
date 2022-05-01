using MySocialNetwork.Domain.Entities.PostEntities;
using MySocialNetwork.Domain.Interfaces;
using MySocialNetwork.Infra.Data.Context;

namespace MySocialNetwork.Infra.Data.Repositories
{
    public class LikeRepository : ILikeRepository
    {
        private readonly ApplicationDbContext _context;

        public LikeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Like? Save(Like like)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Like>? FindAll(int userId, int postId)
        {
            throw new NotImplementedException();
        }

        public Like? Remove(Like like)
        {
            throw new NotImplementedException();
        }

        public Like? Update(Like like)
        {
            throw new NotImplementedException();
        }

        public int FindQtyLikes(int postIt)
        {
            return _context.Likes.Count(x => x.Post.Id == postIt);
        }
    }
}
