namespace MySocialNetwork.Domain.ValueObjects
{
    public class ObjectExamplePost
    {
        public int UserId { get; set; }
        public string? Subtitle { get; set; }
        public List<ObjectExampleImage>? Images { get; set; }
    }
}
