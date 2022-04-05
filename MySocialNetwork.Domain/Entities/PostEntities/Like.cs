using MySocialNetwork.Domain.Entities.UserEntities;
using MySocialNetwork.Domain.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySocialNetwork.Domain.Entities.PostEntities
{
    [Table("Likes")]
    public sealed class Like : AbstractEntity
    {
        public Like(int postId, int userId, bool isLiked)
        {
            ValidateDomain();

            PostId = postId;
            UserId = userId;
            IsLiked = isLiked;
        }

        public Like(int postId, int userId)
        {
            ValidateDomain();

            PostId = postId;
            IsLiked = true;
            UserId = userId;
        }

        [Column(TypeName = "INT UNSIGNED")]
        public int PostId { get; set; }
        public Post? Post { get; set; }

        //Liked by
        public bool IsLiked { get; private set; }

        [Column(TypeName = "INT UNSIGNED")]
        public int UserId { get; set; }
        public User? User { get; set; }

        public void ValidateDomain()
        {
            DomainException.When(PostId < 0, "Postagem não informada.");
            DomainException.When(UserId < 0, "Usuário não informado.");
        }
    }
}
