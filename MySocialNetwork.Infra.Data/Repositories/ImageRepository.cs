using MySocialNetwork.Domain.Entities.PostEntities;
using MySocialNetwork.Domain.Interfaces;

namespace MySocialNetwork.Infra.Data.Repositories
{
    public class ImageRepository : IImageRepository
    {
        public Task<bool> Commit()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Image>? FindAll(int postId)
        {
            throw new NotImplementedException();
        }

        public Task RoolBack()
        {
            throw new NotImplementedException();
        }
    }
}
