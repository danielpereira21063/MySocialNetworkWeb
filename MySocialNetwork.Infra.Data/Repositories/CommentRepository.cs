using MySocialNetwork.Domain.Entities.PostEntities;
using MySocialNetwork.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySocialNetwork.Infra.Data.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        public Comment? Create(Comment comment)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comment> GetAllByPostId(int userId, int postId)
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
    }
}
