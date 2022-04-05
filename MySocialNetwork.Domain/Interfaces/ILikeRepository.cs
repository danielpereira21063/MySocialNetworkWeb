using MySocialNetwork.Domain.Entities.PostEntities;

namespace MySocialNetwork.Domain.Interfaces
{
    public interface ILikeRepository
    {
        IEnumerable<Like>? GetAllByPostId(int userId, int postId);
        Like? Create(Like like);
        Like? Update(Like like);
        Like? Remove(Like like);
    }
}
