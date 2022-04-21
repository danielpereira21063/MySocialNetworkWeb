using MySocialNetwork.Domain.Entities.UserEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySocialNetwork.Domain.Entities.PostEntities
{
    [Table("Likes")]
    public class Like : AbstractEntity
    {

        [Column(TypeName = "INT UNSIGNED")]
        public Post? Post { get; set; }

        //Liked by
        public bool IsLiked { get; set; }

        [Column(TypeName = "INT UNSIGNED")]
        public User? User { get; set; }
    }
}
