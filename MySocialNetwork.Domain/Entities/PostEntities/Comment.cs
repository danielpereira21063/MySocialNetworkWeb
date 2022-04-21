using MySocialNetwork.Domain.Entities.UserEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySocialNetwork.Domain.Entities.PostEntities
{
    [Table("Comments")]
    public class Comment : AbstractEntity
    {
        public Comment()
        {

        }

        [Column(TypeName = "INT UNSIGNED")]
        public Post? Post { get; set; }

        [Column(TypeName = "TEXT")]
        public string? Text { get; set; }


        //Commented by
        [Column(TypeName = "INT UNSIGNED")]

        public User? User { get; set; }
    }
}
