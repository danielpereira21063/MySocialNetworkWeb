using MySocialNetwork.Domain.Entities.UserEntities;
using MySocialNetwork.Domain.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySocialNetwork.Domain.Entities.PostEntities
{
    [Table("Comments")]
    public sealed class Comment : AbstractEntity
    {
        public Comment(int postId, int userId, string text)
        {
            ValidateDomain();

            PostId = postId;
            UserId = userId;
            Text = text;
        }

        [Column(TypeName = "INT UNSIGNED")]
        public int PostId { get; private set; }
        public Post? Post { get; set; }

        [Column(TypeName = "TEXT")]
        public string? Text { get; private set; }


        //Commented by
        [Column(TypeName = "INT UNSIGNED")]
        public int UserId { get; set; }

        public User? User { get; set; }

        private void ValidateDomain()
        {
            DomainException.When(PostId < 0, "Postagem não informada.");
            DomainException.When(Text?.Length == 0, "Escreva algo.");
        }

    }
}
