using MySocialNetwork.Domain.Entities.PostEntities;
using MySocialNetwork.Domain.Interfaces.Abstractions;

namespace MySocialNetwork.Domain.Interfaces
{
    public interface ILikeRepository : IUnitOfWork
    {
        Like? Save(Like like);
        Like? Update(Like like);
        Like? Remove(Like like);
        Like? FindByPostId(int postId, int userId);
        int FindQtyLikes(int postId);
    }
}
