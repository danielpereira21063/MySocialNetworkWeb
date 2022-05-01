using MySocialNetwork.Domain.Entities.UserEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySocialNetwork.Domain.Entities.PostEntities
{
    [Table("Posts")]
    public class Post : AbstractEntity
    {
#pragma warning disable CS8618 // Non-nullable property 'User' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public Post()
#pragma warning restore CS8618 // Non-nullable property 'User' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
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
