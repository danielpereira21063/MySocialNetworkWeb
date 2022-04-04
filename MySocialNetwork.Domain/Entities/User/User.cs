using System.ComponentModel.DataAnnotations.Schema;

namespace MySocialNetwork.Domain.Entities.User
{
    public sealed class User : AbstractEntity
    {
        [Column(TypeName = "VARCHAR(250)")]
        public string? Name { get; set; }


        [Column(TypeName = "VARCHAR(250)")]
        public string? Email { get; set; }


        [Column(TypeName = "MEDIUMBLOB")]
        public byte[]? ProfilePicture { get; set; }


        [Column(TypeName = "INT UNSIGNED")]
        public int AdressId { get; set; }
        public Address? Address { get; set; }

        public List<Publication.Publication>? Publications { get; set; }
    }
}
