using System.ComponentModel.DataAnnotations.Schema;

namespace MySocialNetwork.Domain.Entities.PostEntities
{
    public sealed class Image : AbstractEntity
    {
        [Column(TypeName = "MEDIUMBLOB")]
        public byte[]? File { get; private set; }

        [Column(TypeName = "INT UNSIGNED")]
        public int PostId { get; set; }

        public Post? Post { get; set; }
    }
}

