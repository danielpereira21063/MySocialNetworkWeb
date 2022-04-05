using MySocialNetwork.Domain.Entities.PostEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySocialNetwork.Domain.Entities.UserEntities
{
    public sealed class User : AbstractEntity
    {
        [Column(TypeName = "VARCHAR(250)")]
        public string? Name { get; private set; }


        [Column(TypeName = "VARCHAR(250)")]
        public string? Email { get; private set; }

        public DateTime BirthDate { get; private set; }


        [Column(TypeName = "MEDIUMBLOB")]
        public byte[]? ProfilePicture { get; private set; }

        public List<Comment>? Comments { get; set; }
        public List<Like>? Likes { get; set; }
        public List<Address>? Addresses { get; set; }

        public List<Post>? Posts { get; set; }
    }
}
