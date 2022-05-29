using MySocialNetwork.Domain.Entities.PostEntities;
using MySocialNetwork.Domain.Interfaces.Abstractions;

namespace MySocialNetwork.Domain.Interfaces
{
    public interface IPostRepository : IUnitOfWork
    {
        List<Post>? FindAll(int userId);
        List<Post>? FindAll();
        Post? Find(int userId, int postId);
        Post? Find(int postId);
        Post? Save(Post post);
        Post? Update(Post post);
        Post? Remove(Post post);
    }
}
