using MySocialNetwork.Application.Interfaces;
using MySocialNetwork.Domain.ViewModel.Post;

namespace MySocialNetwork.Domain.Interfaces
{
    public interface IPostService : IGenericService<PostViewModel>
    {
        List<PostViewModel>? GetAll(int userId);
        PostViewModel? GetById(int userId, int postId);
    }
}
