using MySocialNetwork.Domain.Entities.UserEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySocialNetwork.Domain.Entities.PostEntities
{
    public sealed class Comment : AbstractEntity
    {
        [Column(TypeName = "INT UNSIGNED")]
        public int PostId { get; private set; }
        public Post? Post { get; set; }

        [Column(TypeName = "TEXT")]
        public string? Text { get; private set; }


        //Commented by
        [Column(TypeName = "INT UNSIGNED")]
        public int CommentedById { get; set; }

        public User? CommentedBy { get; set; }

    }
}
