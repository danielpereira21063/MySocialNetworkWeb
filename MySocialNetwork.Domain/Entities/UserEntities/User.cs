using MySocialNetwork.Domain.Entities.PostEntities;
using MySocialNetwork.Domain.Enums;
using MySocialNetwork.Domain.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySocialNetwork.Domain.Entities.UserEntities
{
    [Table("Users")]
    public sealed class User : AbstractEntity
    {
        public User()
        {

        }
        public User(string? name, string? email, DateTime birthDate)
        {
            ValidateDomain();

            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public User(string? name, string? email, DateTime birthDate, byte[]? profilePicture)
        {
            ValidateDomain();

            Name = name;
            Email = email;
            BirthDate = birthDate;
            ProfilePicture = profilePicture;
        }

        [Column(TypeName = "VARCHAR(250)")]
        public string? Name { get; set; }


        [Column(TypeName = "VARCHAR(250)")]
        public string? Email { get; set; }

        public DateTime BirthDate { get; set; }

        [Column(TypeName = "CHAR(1)")]
        public Genre? Genre { get; set; }


        [Column(TypeName = "MEDIUMBLOB")]
        public byte[]? ProfilePicture { get; set; }

        public List<Comment>? Comments { get; set; }
        public List<Like>? Likes { get; set; }
        public List<Address>? Addresses { get; set; } = new List<Address>();
        public List<Post>? Posts { get; set; }

        private void ValidateDomain()
        {
            DomainException.When(Name?.Length == 0, "Nome é um campo obrigatório.");
            DomainException.When(Email?.Length == 0, "Email é um campo obrigatório.");
        }
    }
}
