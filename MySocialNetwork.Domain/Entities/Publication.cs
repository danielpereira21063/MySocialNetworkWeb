namespace MySocialNetwork.Domain.Entities
{
    public sealed class Publication : AbstractEntity
    {
        public int UserId { get; set; }
        public string? Description { get; set; }
        public List<Image>? Image { get; set; }
    }
}
