using MySocialNetwork.Domain.Entities.UserEntities;
using MySocialNetwork.Domain.Interfaces.Abstractions;

namespace MySocialNetwork.Domain.Interfaces
{
    public interface IUserRepository : IUnitOfWork
    {
        User? Find(int id);
        User? FindByEmail(string email);
        void Save(User user);
        void Update(User user);
        void Remove(User user);
        List<User>? FindAll(string? searchString);
        Byte[]? FindProfilePicture(int userId);
    }
}
