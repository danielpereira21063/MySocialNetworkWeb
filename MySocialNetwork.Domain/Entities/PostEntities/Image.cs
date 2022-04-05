using MySocialNetwork.Domain.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySocialNetwork.Domain.Entities.PostEntities
{
    [Table("Images")]
    public sealed class Image : AbstractEntity
    {
        public Image(int postId, byte[]? file)
        {
            ValidateDomain();

            PostId = postId;
            File = file;
        }

        [Column(TypeName = "MEDIUMBLOB")]
        public byte[]? File { get; private set; }

        [Column(TypeName = "INT UNSIGNED")]
        public int PostId { get; set; }

        public Post? Post { get; set; }


        private void ValidateDomain()
        {
            DomainException.When(PostId < 0, "Postagem não informada, impossível enviar imagem.");
            DomainException.When(File?.Length < 0, "Imagem não informada.");
        }
    }
}

