﻿using MySocialNetwork.Domain.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySocialNetwork.Domain.Entities.UserEntities
{
    [Table("Addresses")]
    public class Address : AbstractEntity
    {
        public Address()
        {

        }

        public Address(string? street, string? number, string? complement, string? city, string? state, string? postalCode, string? district)
        {
            ValidateDomain();
            Street = street;
            Number = number;
            Complement = complement;
            City = city;
            State = state;
            District = district;
            PostalCode = postalCode;
        }

        [Column(TypeName = "VARCHAR(100)")]
        public string? Street { get; set; }


        [Column(TypeName = "VARCHAR(10)")]
        public string? Number { get; set; }


        [Column(TypeName = "VARCHAR(100)")]
        public string? Complement { get; set; }


        [Column(TypeName = "VARCHAR(50)")]
        public string? City { get; set; }


        [Column(TypeName = "CHAR(2)")]
        public string? State { get; set; }


        [Column(TypeName = "CHAR(8)")]
        public string? PostalCode { get; set; }

        [Column(TypeName = "VARCHAR(32)")]
        public string? District { get; set; }

        public User? User { get; set; }

        public bool Main { get; set; }

        private void ValidateDomain()
        {
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
