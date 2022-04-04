using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySocialNetwork.Domain.Entities.Publication
{
    public sealed class Like : AbstractEntity
    {
        [Column(TypeName = "INT UNSIGNED")]
        public int IdPublication { get; set; }

        [Column(TypeName = "INT UNSIGNED")]
        public int UserIdLikedBy { get; set; }
        public User.User? LikedBy { get; set; }
    }
}
