using MySocialNetwork.Application.Interfaces;
using MySocialNetwork.Domain.ViewModel.Comment;

namespace MySocialNetwork.Domain.Interfaces
{
    public interface ICommentService : IGenericService<CommentViewModel>
    {
        List<CommentViewModel> GetAll(int userId, int postId);
    }
}
