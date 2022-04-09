using MySocialNetwork.Domain.ViewModel.User;

namespace MySocialNetwork.Application.Interfaces
{
    public interface IUserService
    {
        List<UserViewModel>? GetAll(string? searchString);
        UserViewModel? GetUser(int id);
        UserViewModel? GetByEmail(string email);
        void Create(UserViewModel user);
        void Update(UserViewModel user);
        void Remove(UserViewModel user);
    }
}
