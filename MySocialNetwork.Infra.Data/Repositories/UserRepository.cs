using MySocialNetwork.Domain.Entities.UserEntities;
using MySocialNetwork.Domain.Interfaces;

namespace MySocialNetwork.Infra.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        public IEnumerable<User>? GetAll(string searchString)
        {
            throw new NotImplementedException();
        }

        public User? GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
