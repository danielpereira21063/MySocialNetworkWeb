using MySocialNetwork.Domain.Entities.PostEntities;

namespace MySocialNetwork.Domain.Interfaces
{
    public interface ICommentRepository
    {
        IEnumerable<Comment> GetAllByPostId(int userId, int postId);
        Comment? Create(Comment comment);
        Comment? Update(Comment comment);
        Comment? Remove(Comment comment);
    }
}
