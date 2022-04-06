using MySocialNetwork.Domain.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySocialNetwork.Domain.Entities.UserEntities
{
    [Table("Addresses")]
    public sealed class Address : AbstractEntity
    {
        public Address(int userId, string? street, string? number, string? complement, string? city, string? state, string? postalCode, string? district)
        {
            ValidateDomain();

            UserId = userId;
            Street = street;
            Number = number;
            Complement = complement;
            City = city;
            State = state;
            District = district;
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

        [Column(TypeName = "VARCHAR(32)")]
        public string? District { get; private set; }

        [Column(TypeName = "INT UNSIGNED")]
        public int UserId { get; set; }

        public User? User { get; set; }

        public bool Main { get; private set; }

        private void ValidateDomain()
        {
            DomainException.When(UserId < 0, "Usuário não informado.");
            DomainException.When(PostalCode?.Length == 8, "CEP é um campo obrigatório.");
            DomainException.When(City?.Length == 0, "Cidade é um campo obrigatório.");
            DomainException.When(Number?.Length == 0, "Número é um campo obrigatório.");
            DomainException.When(State?.Length == 0, "Estado é um campo obrigatório.");
            DomainException.When(Complement?.Length == 0, "Complemento é um campo obrigatório.");
            DomainException.When(State?.Length != 2, "O Estado deve ser composto por 2 caracteres.");
            DomainException.When(PostalCode?.Length != 8, "CEP inválido.");
        }
    }
}
