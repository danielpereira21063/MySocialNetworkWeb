using MySocialNetwork.Domain.Interfaces;
using MySocialNetwork.Domain.ViewModel.Like;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySocialNetwork.Application.Services
{
    public class LikeService : ILikeService
    {
        public LikeViewModel? Create(LikeViewModel? like)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LikeViewModel>? FindAll(int userId, int postId)
        {
            throw new NotImplementedException();
        }

        public LikeViewModel? Remove(LikeViewModel? like)
        {
            throw new NotImplementedException();
        }

        public LikeViewModel? Update(LikeViewModel? like)
        {
            throw new NotImplementedException();
        }
    }
}
