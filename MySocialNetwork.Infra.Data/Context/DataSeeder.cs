using MySocialNetwork.Domain.Entities.PostEntities;
using MySocialNetwork.Domain.Entities.UserEntities;
using MySocialNetwork.Domain.Enums;

namespace MySocialNetwork.Infra.Data.Context
{
    public class DataSeeder
    {
        private readonly ApplicationDbContext? _context;

        public DataSeeder(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Seed()
        {
#pragma warning disable CS8604 // Possible null reference argument for parameter 'source' in 'bool Queryable.Any<Post>(IQueryable<Post> source)'.
#pragma warning disable CS8604 // Possible null reference argument for parameter 'source' in 'bool Queryable.Any<Image>(IQueryable<Image> source)'.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8604 // Possible null reference argument for parameter 'source' in 'bool Queryable.Any<User>(IQueryable<User> source)'.
#pragma warning disable CS8604 // Possible null reference argument for parameter 'source' in 'bool Queryable.Any<Address>(IQueryable<Address> source)'.
#pragma warning disable CS8604 // Possible null reference argument for parameter 'source' in 'bool Queryable.Any<Like>(IQueryable<Like> source)'.
#pragma warning disable CS8604 // Possible null reference argument for parameter 'source' in 'bool Queryable.Any<Comment>(IQueryable<Comment> source)'.
            bool hasData = _context.Users.Any() || _context.Comments.Any() || _context.Posts.Any() || _context.Addresses.Any() || _context.Likes.Any() || _context.Images.Any();
#pragma warning restore CS8604 // Possible null reference argument for parameter 'source' in 'bool Queryable.Any<Comment>(IQueryable<Comment> source)'.
#pragma warning restore CS8604 // Possible null reference argument for parameter 'source' in 'bool Queryable.Any<Like>(IQueryable<Like> source)'.
#pragma warning restore CS8604 // Possible null reference argument for parameter 'source' in 'bool Queryable.Any<Address>(IQueryable<Address> source)'.
#pragma warning restore CS8604 // Possible null reference argument for parameter 'source' in 'bool Queryable.Any<User>(IQueryable<User> source)'.
#pragma warning restore CS8602 // Dereference of a possibly null reference.
#pragma warning restore CS8604 // Possible null reference argument for parameter 'source' in 'bool Queryable.Any<Image>(IQueryable<Image> source)'.
#pragma warning restore CS8604 // Possible null reference argument for parameter 'source' in 'bool Queryable.Any<Post>(IQueryable<Post> source)'.
            if (hasData)
            {
                return;
            }

            var users = new List<User>();
            var comments = new List<Comment>();
            var posta = new List<Post>();
            var address = new List<Address>();
            var likes = new List<Like>();
            var images = new List<Image>();

            users.Add(new User
            {
                Name = "Daniel Pereira Sanches",
                Email = "daniel@email.com",
                BirthDate = DateTime.Now,
                Genre = Enum.Parse<Genre>("M"),
            });

            users.Add(new User
            {
                Name = "Vanessa Pereira Sanches",
                Email = "vanessa@email.com",
                BirthDate = DateTime.Now,
                Genre = Enum.Parse<Genre>("F"),
            });

            users.Add(new User
            {
                Name = "Maria de Oliveira",
                Email = "maria@email.com",
                BirthDate = DateTime.Now,
                Genre = Enum.Parse<Genre>("F"),
            });

            users.Add(new User
            {
                Name = "Ferando da Silva",
                Email = "fernando@email.com",
                BirthDate = DateTime.Now,
                Genre = Enum.Parse<Genre>("M"),
            });

            users.Add(new User
            {
                Name = "João Matheus",
                Email = "joao@email.com",
                BirthDate = DateTime.Now,
                Genre = Enum.Parse<Genre>("M"),
            });

            users.Add(new User
            {
                Name = "Filipe Moreira",
                Email = "filipe@email.com",
                BirthDate = DateTime.Now,
                Genre = Enum.Parse<Genre>("M"),
            });
        }
    }
}
