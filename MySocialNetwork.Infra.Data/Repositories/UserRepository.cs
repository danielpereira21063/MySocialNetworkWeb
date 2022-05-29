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
        }

        public User? Find(int id)
        {
            return _context.Users.FirstOrDefault(x => x.Id.Equals(id));
        }

        public void Remove(User? user)
        {
            throw new NotImplementedException();
        }

        public void Update(User? user)
        {
            var userEntity = _context.Users.FirstOrDefault(x => x.Id.Equals(user.Id));
            userEntity.ProfilePicture = user.ProfilePicture;
            _context.Users.Update(userEntity);
        }

        public User? FindByEmail(string email)
        {
            return _context.Users.FirstOrDefault(x => x.Email.Equals(email));
        }

        List<User>? IUserRepository.FindAll(string? searchString)
        {
            if (string.IsNullOrEmpty(searchString))
            {
                return _context.Users.ToList();
            }

            return _context.Users
                .Where(x => x.Name.StartsWith(searchString) || x.Email.StartsWith(searchString))
                .ToList();
        }

        public byte[]? FindProfilePicture(int userId)
        {
            var user = _context.Users.FirstOrDefault(x => x.Id.Equals(userId));
            if (user == null)
            {
                return null;
            }

            return user.ProfilePicture;
        }

        public Task<bool> Commit()
        {
            throw new NotImplementedException();
        }

        public Task RoolBack()
        {
            throw new NotImplementedException();
        }
    }
}
