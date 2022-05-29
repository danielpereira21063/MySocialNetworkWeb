using MySocialNetwork.Domain.ViewModel.Post;
using MySocialNetwork.Domain.ViewModel.User;
using System.Text.Json.Serialization;

namespace MySocialNetwork.Domain.ViewModel.Comment
{
    public class CommentViewModel
    {
        public int Id { get; set; }
        public UserViewModel? User { get; set; }
        //public int UserId { get; set; }

        [JsonIgnore]
        public PostViewModel Post { get; set; }
        //public int PostId { get; set; }
        public string? Text { get; set; }
    }
}
