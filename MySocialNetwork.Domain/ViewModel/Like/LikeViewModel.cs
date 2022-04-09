namespace MySocialNetwork.Domain.ViewModel.Like
{
    public class LikeViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
        public bool IsLiked { get; set; }
    }
}
