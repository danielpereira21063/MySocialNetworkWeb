using System.ComponentModel.DataAnnotations.Schema;

namespace MySocialNetwork.Domain.Entities.PostEntities
{
    [Table("Images")]
    public sealed class Image : AbstractEntity
    {
        public Image()
        {

        }

        [Column(TypeName = "MEDIUMBLOB")]
        public byte[]? File { get; set; }

        public Post? Post { get; set; }

    }
}

