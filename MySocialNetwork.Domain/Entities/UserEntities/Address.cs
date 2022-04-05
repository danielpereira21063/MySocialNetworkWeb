using MySocialNetwork.Domain.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySocialNetwork.Domain.Entities.UserEntities
{
    public sealed class Address : AbstractEntity
    {
        public Address()
        {
        }

        public Address(string? street, string? number, string? complement, string? city, string? state, string? postalCode)
        {
            ValidateDomain();

            Street = street;
            Number = number;
            Complement = complement;
            City = city;
            State = state;
            PostalCode = postalCode;
        }

        [Column(TypeName = "VARCHAR(100)")]
        public string? Street { get; private set; }


        [Column(TypeName = "VARCHAR(10)")]
        public string? Number { get; private set; }


        [Column(TypeName = "VARCHAR(100)")]
        public string? Complement { get; private set; }


        [Column(TypeName = "VARCHAR(50)")]
        public string? City { get; private set; }


        [Column(TypeName = "CHAR(2)")]
        public string? State { get; private set; }


        [Column(TypeName = "CHAR(8)")]
        public string? PostalCode { get; private set; }


        [Column(TypeName = "INT UNSIGNED")]
        public int UserId { get; set; }

        public User? User { get; set; }

        public bool Main { get; private set; }

        public void ValidateDomain()
        {
            DomainException.When(State?.Length != 2, "O Estado deve ser composto por 2 caracteres.");
            DomainException.When(PostalCode?.Length != 8, "CEP inválido.");
        }
    }
}
