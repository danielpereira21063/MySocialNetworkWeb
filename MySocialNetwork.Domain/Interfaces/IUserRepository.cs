using MySocialNetwork.Domain.Entities.UserEntities;

namespace MySocialNetwork.Domain.Interfaces
{
    public interface IUserRepository
    {
        User? Find(int id);
        User? FindByEmail(string email);
        void Save(User user);
        void Update(User user);
        void Remove(User user);
        List<User>? FindAll(string? searchString);
    }
}
