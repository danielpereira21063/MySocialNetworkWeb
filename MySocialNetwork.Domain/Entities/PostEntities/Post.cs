using MySocialNetwork.Domain.Entities.UserEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySocialNetwork.Domain.Entities.PostEntities
{
    [Table("Posts")]
    public class Post : AbstractEntity
    {
        public Post()
        {

        }
        public int UserId { get; set; }

        public virtual User User { get; set; }
        [Column(TypeName = "TEXT")]
        public string? Subtitle { get; set; }

        [Column(TypeName = "INT UNSIGNED")]
        public List<Image>? Images { get; set; }
        public List<Like>? Likes { get; set; }
        public List<Comment>? Comments { get; set; }
    }
}
