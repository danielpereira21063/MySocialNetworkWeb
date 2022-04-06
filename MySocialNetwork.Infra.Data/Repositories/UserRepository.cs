using MySocialNetwork.Domain.Entities.UserEntities;
using MySocialNetwork.Domain.Interfaces;
using MySocialNetwork.Infra.Data.Context;

namespace MySocialNetwork.Infra.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext? _userContext;

        public UserRepository(ApplicationDbContext context)
        {
            _userContext = context;
        }

        public void Save(User user)
        {
            _userContext?.Add(user);
            _userContext?.SaveChanges();
        }

        public IEnumerable<User>? FindAll(string? searchString)
        {
            throw new NotImplementedException();
        }

        public User? Find(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(User? user)
        {
            throw new NotImplementedException();
        }

        public void Update(User? user)
        {
            throw new NotImplementedException();
        }
    }
}
