using MySocialNetwork.Domain.Entities.UserEntities;

namespace MySocialNetwork.Domain.Interfaces
{
    public interface IUserRepository
    {
        User? Find(int id);
        void Create(User user);
        void Update(User user);
        void Remove(User user);
        IEnumerable<User>? FindAll(string? searchString);
    }
}
