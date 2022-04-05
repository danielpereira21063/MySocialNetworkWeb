using MySocialNetwork.Domain.Entities.PostEntities;
using MySocialNetwork.Domain.ViewModel.Like;

namespace MySocialNetwork.Domain.Interfaces
{
    public interface ILikeService
    {
        IEnumerable<LikeViewModel>? GetAllByPostId(int userId, int postId);
        LikeViewModel? Create(LikeViewModel? like);
        LikeViewModel? Update(LikeViewModel? like);
        LikeViewModel? Remove(LikeViewModel? like);
    }
}
