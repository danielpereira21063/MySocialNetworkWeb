using MySocialNetwork.Domain.Entities.UserEntities;
using MySocialNetwork.Domain.ViewModel.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySocialNetwork.Application.Interfaces
{
    public interface IUserService
    {
        IEnumerable<UserViewModel>? GetAll(string? searchString);
        UserViewModel? GetUser(int id);
        void Create(UserViewModel user);
        void Update(UserViewModel user);
        void Remove(UserViewModel user);
    }
}
