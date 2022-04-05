namespace MySocialNetwork.Domain.ViewModel.Comment
{
    public class CommentViewModel
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string? Text { get; set; }
    }
}
