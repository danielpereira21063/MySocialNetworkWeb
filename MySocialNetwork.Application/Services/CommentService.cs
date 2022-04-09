using MySocialNetwork.Domain.Interfaces;
using MySocialNetwork.Domain.ViewModel.Comment;

namespace MySocialNetwork.Application.Services
{
    public class CommentService : ICommentService
    {


        public CommentViewModel? Create(CommentViewModel comment)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CommentViewModel> FindAll(int userId, int postId)
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
