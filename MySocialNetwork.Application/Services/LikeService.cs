using MySocialNetwork.Domain.Interfaces;
using MySocialNetwork.Domain.ViewModel.Like;

namespace MySocialNetwork.Application.Services
{
    public class LikeService : ILikeService
    {
        private readonly ILikeRepository _likeRepository;

        public LikeService(ILikeRepository likeRepository)
        {
            _likeRepository = likeRepository;
        }

        public void Create(LikeViewModel? entity)
        {
            throw new NotImplementedException();
        }

        public List<LikeViewModel>? GetAll(int userId, int postId)
        {
            throw new NotImplementedException();
        }

        public List<LikeViewModel>? GetAll()
        {
            throw new NotImplementedException();
        }

        public LikeViewModel? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(LikeViewModel? entity)
        {
            throw new NotImplementedException();
        }

        public void Update(LikeViewModel? entity)
        {
            throw new NotImplementedException();
        }

        public int GetQtyLikes(int postId)
        {
            return _likeRepository.FindQtyLikes(postId);
        }
    }
}
