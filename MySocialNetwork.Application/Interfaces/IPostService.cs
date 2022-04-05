using MySocialNetwork.Domain.Entities.PostEntities;
using MySocialNetwork.Domain.ViewModel.Post;

namespace MySocialNetwork.Domain.Interfaces
{
    public interface IPostService
    {
        IEnumerable<PostViewModel>? GetAllByUserId(int userId);
        PostViewModel? GetById(int userId, int postId);
        PostViewModel? Create(PostViewModel? post);
        PostViewModel? Update(PostViewModel? post);
        PostViewModel? Remove(Post? post);
    }
}
