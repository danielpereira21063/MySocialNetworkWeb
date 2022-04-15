using MySocialNetwork.Domain.Interfaces;
using MySocialNetwork.Domain.ViewModel.Comment;

namespace MySocialNetwork.Application.Services
{
    public class CommentService : ICommentService
    {
        public void Create(CommentViewModel? entity)
        {
            throw new NotImplementedException();
        }

        public List<CommentViewModel> GetAll(int userId, int postId)
        {
            throw new NotImplementedException();
        }

        public List<CommentViewModel>? GetAll()
        {
            throw new NotImplementedException();
        }

        public CommentViewModel? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(CommentViewModel? entity)
        {
            throw new NotImplementedException();
        }

        public void Update(CommentViewModel? entity)
        {
            throw new NotImplementedException();
        }
    }
}
