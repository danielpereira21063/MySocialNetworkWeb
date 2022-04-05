using MySocialNetwork.Domain.Entities.UserEntities;

namespace MySocialNetwork.Domain.Interfaces
{
    public interface IUserRepository
    {
        User? GetById(int id);
        IEnumerable<User>? GetAll();
    }
}
