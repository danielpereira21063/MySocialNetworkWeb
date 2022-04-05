using MySocialNetwork.Domain.Entities.PostEntities;


namespace MySocialNetwork.Domain.Interfaces
{
    public interface IImageRepository
    {
        IEnumerable<Image>? GetAllByPostId(int postId);
    }
}
