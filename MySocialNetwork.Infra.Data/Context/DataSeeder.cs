using MySocialNetwork.Domain.Entities.PostEntities;
using MySocialNetwork.Domain.Entities.UserEntities;

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
            bool hasData = _context.Users.Any() || _context.Comments.Any() || _context.Posts.Any() || _context.Addresses.Any() || _context.Likes.Any() || _context.Images.Any();
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
        }
    }
}
