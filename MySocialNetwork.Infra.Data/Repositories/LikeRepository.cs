using MySocialNetwork.Domain.Entities.PostEntities;
using MySocialNetwork.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySocialNetwork.Infra.Data.Repositories
{
    public class LikeRepository : ILikeRepository
    {
        public Like? Create(Like like)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Like>? GetAllByPostId(int userId, int postId)
        {
            throw new NotImplementedException();
        }

        public Like? Remove(Like like)
        {
            throw new NotImplementedException();
        }

        public Like? Update(Like like)
        {
            throw new NotImplementedException();
        }
    }
}
