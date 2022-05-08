using MySocialNetwork.Domain.ViewModel.User;

namespace MySocialNetwork.Application.Interfaces
{
    public interface IUserService : IGenericService<UserViewModel>
    {
        List<UserViewModel>? GetAll(string? searchString);
        UserViewModel? GetByEmail(string email);
        Byte[]? GetProfilePicture(int userId);
    }
}
