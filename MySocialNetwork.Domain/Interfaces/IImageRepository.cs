using MySocialNetwork.Domain.Entities.PostEntities;
using MySocialNetwork.Domain.Interfaces.Abstractions;

namespace MySocialNetwork.Domain.Interfaces
{
    public interface IImageRepository : IUnitOfWork
    {
        IEnumerable<Image>? FindAll(int postId);
    }
}
