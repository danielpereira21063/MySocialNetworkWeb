using MySocialNetwork.Domain.Entities.PostEntities;

namespace MySocialNetwork.Domain.Interfaces
{
    public interface IPostRepository
    {
        IEnumerable<Post>? FindAll(int userId);
        Post? Find(int userId, int postId);
        Post? Save(Post post);
        Post? Update(Post post);
        Post? Remove(Post post);
    }
}
