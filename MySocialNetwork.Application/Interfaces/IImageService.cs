using MySocialNetwork.Domain.Entities.PostEntities;


namespace MySocialNetwork.Domain.Interfaces
{
    public interface IImageRepository
    {
        void Create(Image? image);
        void Update(Image? image);
        void Remove(Image? image);
    }
}
