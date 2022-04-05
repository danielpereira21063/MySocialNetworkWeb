using MySocialNetwork.Domain.ViewModel.Comment;

namespace MySocialNetwork.Domain.ViewModel.Post
{
    public class PostViewModel
    {
        public int Id { get; set; }
        public string? Subtitle { get; set; }
        public int NumberOfLikes { get; set; }
        public List<CommentViewModel>? Comments { get; set; }
    }
}
