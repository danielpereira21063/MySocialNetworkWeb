using MySocialNetwork.Domain.Entities.PostEntities;
using MySocialNetwork.Domain.ViewModel.Image;

namespace MySocialNetwork.Domain.Interfaces
{
    public interface IImageService
    {
        void Create(ImageViewModel? image);
        void Update(ImageViewModel? image);
        void Remove(ImageViewModel? image);
    }
}
