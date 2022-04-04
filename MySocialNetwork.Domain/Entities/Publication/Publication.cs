using System.ComponentModel.DataAnnotations.Schema;

namespace MySocialNetwork.Domain.Entities.Publication
{
    public sealed class Publication : AbstractEntity
    {
        public int UserId { get; set; }
        
        [Column(TypeName = "TEXT")]
        public string? Description { get; set; }
        public List<Image>? Images { get; set; }
        public List<Like>? Likes { get; set; }
        public List<Comment>? Comments { get; set; }
    }
}
