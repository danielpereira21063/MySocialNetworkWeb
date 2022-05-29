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
            _context.Likes.Add(like);
            return like;
        }


        public Like? Remove(Like like)
        {
            throw new NotImplementedException();
        }

        public Like? Update(Like like)
        {
            _context.Likes.Update(like);
            return like;
        }

        public int FindQtyLikes(int postIt)
        {
            return _context.Likes.Where(x => x.IsLiked).Count(x => x.Post.Id == postIt);
        }

        public Like? FindByPostId(int postId, int userId)
        {
            return _context.Likes.FirstOrDefault(x => x.Post.Id.Equals(postId) && x.User.Id.Equals(userId));
        }

        public Task<bool> Commit()
        {
            throw new NotImplementedException();
        }

        public Task RoolBack()
        {
            throw new NotImplementedException();
        }
    }
}
