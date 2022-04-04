using System.ComponentModel.DataAnnotations.Schema;

namespace MySocialNetwork.Domain.Entities
{
    public sealed class Image : AbstractEntity
    {
        public int PublicationId { get; set; }

        [Column(TypeName = "MEDIUMBLOB")]
        public byte[]? File { get; set; }
    }
}

