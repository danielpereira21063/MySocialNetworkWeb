using MySocialNetwork.Domain.Entities.PostEntities;
using MySocialNetwork.Domain.Interfaces;

namespace MySocialNetwork.Infra.Data.Repositories
{
    public class LikeRepository : ILikeRepository
    {
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
    }
}
