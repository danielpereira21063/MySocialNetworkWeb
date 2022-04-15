using MySocialNetwork.Domain.Entities.PostEntities;
using MySocialNetwork.Domain.Interfaces;

namespace MySocialNetwork.Infra.Data.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        public Comment? Save(Comment comment)
        {
            throw new NotImplementedException();
        }

        public List<Comment> FindAll(int userId, int postId)
        {
            throw new NotImplementedException();
        }

        public Comment? Remove(Comment comment)
        {
            throw new NotImplementedException();
        }

        public Comment? Update(Comment comment)
        {
            throw new NotImplementedException();
        }
    }
}
