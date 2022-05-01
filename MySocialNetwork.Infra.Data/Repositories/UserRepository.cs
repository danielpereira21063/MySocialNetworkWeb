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

        public User? Find(int id)
        {
#pragma warning disable CS8604 // Possible null reference argument for parameter 'source' in 'User? Queryable.FirstOrDefault<User>(IQueryable<User> source, Expression<Func<User, bool>> predicate)'.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            return _context.Users.FirstOrDefault(x => x.Id.Equals(id));
#pragma warning restore CS8602 // Dereference of a possibly null reference.
#pragma warning restore CS8604 // Possible null reference argument for parameter 'source' in 'User? Queryable.FirstOrDefault<User>(IQueryable<User> source, Expression<Func<User, bool>> predicate)'.
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
#pragma warning disable CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8604 // Possible null reference argument for parameter 'source' in 'User? Queryable.FirstOrDefault<User>(IQueryable<User> source, Expression<Func<User, bool>> predicate)'.
            return _context.Users.FirstOrDefault(x => x.Email.Equals(email));
#pragma warning restore CS8604 // Possible null reference argument for parameter 'source' in 'User? Queryable.FirstOrDefault<User>(IQueryable<User> source, Expression<Func<User, bool>> predicate)'.
#pragma warning restore CS8602 // Dereference of a possibly null reference.
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }

        List<User>? IUserRepository.FindAll(string? searchString)
        {
            if (string.IsNullOrEmpty(searchString))
            {
#pragma warning disable CS8604 // Possible null reference argument for parameter 'source' in 'List<User> Enumerable.ToList<User>(IEnumerable<User> source)'.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                return _context.Users.ToList();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
#pragma warning restore CS8604 // Possible null reference argument for parameter 'source' in 'List<User> Enumerable.ToList<User>(IEnumerable<User> source)'.
            }

#pragma warning disable CS8604 // Possible null reference argument for parameter 'source' in 'IQueryable<User> Queryable.Where<User>(IQueryable<User> source, Expression<Func<User, bool>> predicate)'.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            return _context.Users
                .Where(x => x.Name.StartsWith(searchString) || x.Email.StartsWith(searchString))
                .ToList();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
#pragma warning restore CS8602 // Dereference of a possibly null reference.
#pragma warning restore CS8602 // Dereference of a possibly null reference.
#pragma warning restore CS8604 // Possible null reference argument for parameter 'source' in 'IQueryable<User> Queryable.Where<User>(IQueryable<User> source, Expression<Func<User, bool>> predicate)'.
        }
    }
}
