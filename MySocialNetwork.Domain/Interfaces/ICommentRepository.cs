using MySocialNetwork.Domain.Entities.PostEntities;
using MySocialNetwork.Domain.Interfaces.Abstractions;

namespace MySocialNetwork.Domain.Interfaces
{
    public interface ICommentRepository : IUnitOfWork
    {
        List<Comment> FindAll(int userId, int postId);
        Comment? Save(Comment comment);
        Comment? Update(Comment comment);
        Comment? Remove(Comment comment);
    }
}
