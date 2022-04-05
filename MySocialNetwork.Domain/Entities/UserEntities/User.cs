using MySocialNetwork.Domain.Entities.PostEntities;
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

        private void ValidateDomain()
        {
            DomainException.When(Name?.Length == 0, "Nome é um campo obrigatório.");
            DomainException.When(Email?.Length == 0, "Email é um campo obrigatório.");
        }
    }
}
