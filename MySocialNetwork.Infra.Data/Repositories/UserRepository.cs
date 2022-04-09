using MySocialNetwork.Domain.Entities.UserEntities;
using MySocialNetwork.Domain.Interfaces;
using MySocialNetwork.Infra.Data.Context;

namespace MySocialNetwork.Infra.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext? _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Save(User user)
        {
            _context?.Add(user);
            _context?.SaveChanges();
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

        public User? FindByEmail(string email)
        {
            return _context.Users.FirstOrDefault(x => x.Email.Equals(email));
        }
    }
}
