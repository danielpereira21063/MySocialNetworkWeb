using MySocialNetwork.Domain.Entities.PostEntities;

namespace MySocialNetwork.Domain.Interfaces
{
    public interface ILikeRepository
    {
        IEnumerable<Like>? FindAll(int userId, int postId);
        Like? Save(Like like);
        Like? Update(Like like);
        Like? Remove(Like like);
        int FindQtyLikes(int postId);
    }
}
