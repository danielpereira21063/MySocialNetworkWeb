using MySocialNetwork.Domain.ViewModel.Comment;

namespace MySocialNetwork.Domain.Interfaces
{
    public interface ICommentService
    {
        IEnumerable<CommentViewModel> FindAll(int userId, int postId);
        CommentViewModel? Create(CommentViewModel comment);
        CommentViewModel? Update(CommentViewModel comment);
        CommentViewModel? Remove(CommentViewModel comment);
    }
}
