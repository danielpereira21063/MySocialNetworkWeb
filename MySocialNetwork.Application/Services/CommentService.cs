using MySocialNetwork.Domain.Interfaces;
using MySocialNetwork.Domain.ViewModel.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySocialNetwork.Application.Services
{
    public class CommentService : ICommentService
    {
        public CommentViewModel? Create(CommentViewModel comment)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CommentViewModel> GetAllByPostId(int userId, int postId)
        {
            throw new NotImplementedException();
        }

        public CommentViewModel? Remove(CommentViewModel comment)
        {
            throw new NotImplementedException();
        }

        public CommentViewModel? Update(CommentViewModel comment)
        {
            throw new NotImplementedException();
        }
    }
}
