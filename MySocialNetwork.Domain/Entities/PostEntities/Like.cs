using MySocialNetwork.Domain.Entities.UserEntities;
using MySocialNetwork.Domain.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySocialNetwork.Domain.Entities.PostEntities
{
    [Table("Likes")]
    public sealed class Like : AbstractEntity
    {
        public Like(int postId, int likedById, bool isLiked)
        {
            ValidateDomain();

            PostId = postId;
            LikedById = likedById;
            IsLiked = isLiked;
        }

        public Like(int postId, int likedById)
        {
            ValidateDomain();

            PostId = postId;
            IsLiked = true;
            LikedById = likedById;
        }

        [Column(TypeName = "INT UNSIGNED")]
        public int PostId { get; set; }
        public Post? Post { get; set; }

        //Liked by
        [Column(TypeName = "INT UNSIGNED")]
        public bool IsLiked { get; private set; }
        public int LikedById { get; set; }
        public User? LikedBy { get; set; }

        public void ValidateDomain()
        {
            DomainException.When(PostId < 0, "Postagem não informada.");
            DomainException.When(LikedById < 0, "Usuário não informado.");
        }
    }
}
