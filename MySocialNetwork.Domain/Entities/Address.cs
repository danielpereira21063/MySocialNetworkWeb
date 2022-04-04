using System.ComponentModel.DataAnnotations.Schema;

namespace MySocialNetwork.Domain.Entities
{
    public sealed class Address : AbstractEntity
    {
        public Address()
        {
            ValidateDomain();
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
        public string? Region { get; set; }

        [Column(TypeName = "CHAR(8)")]
        public string? PostalCode { get; set; }



        public void ValidateDomain()
        {
            if (Region?.Length > 2)
            {
                throw new Exception("Erro");
            }

            if(PostalCode?.Length > 2)
            {
                throw new Exception("Erro");
            }
        }
    }
}
