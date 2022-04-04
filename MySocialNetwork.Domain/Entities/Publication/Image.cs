using System.ComponentModel.DataAnnotations.Schema;

namespace MySocialNetwork.Domain.Entities.Publication
{
    public sealed class Image : AbstractEntity
    {
        [Column(TypeName = "MEDIUMBLOB")]
        public byte[]? File { get; set; }

        [Column(TypeName = "INT UNSIGNED")]
        public int PublicationId { get; set; }

        public Publication? Publication { get; set; }
    }
}

