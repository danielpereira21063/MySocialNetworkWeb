using MySocialNetwork.Domain.Entities.PostEntities;

namespace MySocialNetwork.Domain.Interfaces
{
    public interface ILikeRepository
    {
        Like? Save(Like like);
        Like? Update(Like like);
        Like? Remove(Like like);
        Like? FindByPostId(int postId,int userId);
        int FindQtyLikes(int postId);
    }
}
