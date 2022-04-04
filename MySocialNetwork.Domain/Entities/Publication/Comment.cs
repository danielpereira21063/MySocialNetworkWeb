using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySocialNetwork.Domain.Entities.Publication
{
    public sealed class Comment
    {
        [Column(TypeName = "INT UNSIGNED")]
        public int PublicationId { get; set; }
        public Publication? Publication;


        [Column(TypeName = "INT UNSIGNED")]
        public int UserIdCommentedBy { get; set; }

        public User.User? ComentedBy { get; set; }

        [Column(TypeName = "TEXT")]
        public string? Text { get; set; }
    }
}
