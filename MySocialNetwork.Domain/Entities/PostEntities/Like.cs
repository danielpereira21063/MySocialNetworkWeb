using MySocialNetwork.Domain.Entities.UserEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySocialNetwork.Domain.Entities.PostEntities
{
    public sealed class Like : AbstractEntity
    {
        [Column(TypeName = "INT UNSIGNED")]
        public int PostId { get; set; }
        public Post? Post { get; set; }

        //Liked by
        [Column(TypeName = "INT UNSIGNED")]
        public bool IsLiked { get; private set; }
        public int LikedById { get; set; }
        public User? LikedBy { get; set; }
    }
}
