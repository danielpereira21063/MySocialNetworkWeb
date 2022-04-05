using MySocialNetwork.Domain.ViewModel.User;

namespace MySocialNetwork.Domain.ViewModel.Comment
{
    public class CommentViewModel
    {
        public int Id { get; set; }
        public UserViewModel? User { get; set; }
        public int PostId { get; set; }
        public string? Text { get; set; }
    }
}
