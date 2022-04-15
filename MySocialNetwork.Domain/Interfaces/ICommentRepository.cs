using MySocialNetwork.Domain.Entities.PostEntities;

namespace MySocialNetwork.Domain.Interfaces
{
    public interface ICommentRepository
    {
        List<Comment> FindAll(int userId, int postId);
        Comment? Save(Comment comment);
        Comment? Update(Comment comment);
        Comment? Remove(Comment comment);
    }
}
