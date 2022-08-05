using Microsoft.EntityFrameworkCore;
using MySocialNetwork.Domain.Entities.PostEntities;
using MySocialNetwork.Domain.Interfaces;
using MySocialNetwork.Infra.Data.Context;

namespace MySocialNetwork.Infra.Data.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly ApplicationDbContext _context;

        public PostRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Post? Save(Post post)
        {
            _context.Posts.Add(post);
            _context.SaveChanges();
            return post;
        }

        public List<Post>? FindAll(int userId)
        {
            throw new NotImplementedException();
        }

        public Post? Find(int userId, int postId)
        {
            throw new NotImplementedException();
        }

        public Post? Remove(Post post)
        {
            throw new NotImplementedException();
        }

        public Post? Update(Post post)
        {
            throw new NotImplementedException();
        }

        public List<Post>? FindAll()
        {
            return _context.Posts
                .Include(x => x.User)
                .Include(x => x.Comments)
                .Include(x => x.Likes)
                .ThenInclude(x => x.User)
                .Include(x => x.Images)
                .OrderBy(x => x.CreatedAt)
                .Take(24).ToList();
        }

        public Post? Find(int postId)
        {
            return _context.Posts.FirstOrDefault(x => x.Id.Equals(postId));
        }

        public async Task<bool> Commit()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public Task RoolBack()
        {
            return Task.CompletedTask;
        }
    }
}
