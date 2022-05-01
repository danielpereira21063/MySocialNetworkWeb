using MySocialNetwork.Application.Interfaces;
using MySocialNetwork.Domain.ViewModel.Like;

namespace MySocialNetwork.Domain.Interfaces
{
    public interface ILikeService : IGenericService<LikeViewModel>
    {
        List<LikeViewModel>? GetAll(int userId, int postId);
        int GetQtyLikes(int postId);
    }
}
