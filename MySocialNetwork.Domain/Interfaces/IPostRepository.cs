using MySocialNetwork.Domain.Entities.PostEntities;

namespace MySocialNetwork.Domain.Interfaces
{
    public interface IPostRepository
    {
        IEnumerable<Post>? GetAllByUserId(int userId);
        Post? GetById(int userId, int postId);
        Post? Create(Post post);
        Post? Update(Post post);
        Post? Remove(Post post);
    }
}
