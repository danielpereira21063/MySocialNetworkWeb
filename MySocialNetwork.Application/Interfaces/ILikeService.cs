using MySocialNetwork.Domain.ViewModel.Like;

namespace MySocialNetwork.Domain.Interfaces
{
    public interface ILikeService
    {
        IEnumerable<LikeViewModel>? FindAll(int userId, int postId);
        LikeViewModel? Create(LikeViewModel? like);
        LikeViewModel? Update(LikeViewModel? like);
        LikeViewModel? Remove(LikeViewModel? like);
    }
}
