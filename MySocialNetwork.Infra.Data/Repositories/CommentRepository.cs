using MySocialNetwork.Domain.Entities.PostEntities;
using MySocialNetwork.Domain.Interfaces;
using MySocialNetwork.Infra.Data.Context;

namespace MySocialNetwork.Infra.Data.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly ApplicationDbContext _context;

        public CommentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Comment? Save(Comment comment)
        {
            comment.Post = _context.Posts.FirstOrDefault(x => x.Id.Equals(comment.Post.Id));
            comment.User = _context.Users.FirstOrDefault(x => x.Id.Equals(comment.User.Id));

            _context.Comments.Add(comment);
            return comment;
        }

        public List<Comment> FindAll(int userId, int postId)
        {
            throw new NotImplementedException();
        }

        public Comment? Remove(Comment comment)
        {
            throw new NotImplementedException();
        }

        public Comment? Update(Comment comment)
        {
            throw new NotImplementedException();
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
