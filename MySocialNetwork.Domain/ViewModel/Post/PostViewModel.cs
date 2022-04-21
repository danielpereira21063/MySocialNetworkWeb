using MySocialNetwork.Domain.ViewModel.Comment;
using MySocialNetwork.Domain.ViewModel.Image;
using MySocialNetwork.Domain.ViewModel.Like;
using MySocialNetwork.Domain.ViewModel.User;

namespace MySocialNetwork.Domain.ViewModel.Post
{
    public class PostViewModel
    {
        public int Id { get; set; }
        public string? Subtitle { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public UserViewModel User { get; set; }
        public List<CommentViewModel>? Comments { get; set; }
        public List<LikeViewModel>? Likes { get; set; }
        public List<ImageViewModel>? Images { get; set; }
    }
}
