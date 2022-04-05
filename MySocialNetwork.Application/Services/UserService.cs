using MySocialNetwork.Application.Interfaces;
using MySocialNetwork.Domain.ViewModel.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySocialNetwork.Application.Services
{
    public class UserService : IUserService
    {
        public void Add(UserViewModel? user)
        {
            throw new NotImplementedException();
        }

        public UserViewModel? GetUser(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserViewModel>? GetUsers()
        {
            throw new NotImplementedException();
        }

        public void Remove(UserViewModel? user)
        {
            throw new NotImplementedException();
        }

        public void Update(UserViewModel? user)
        {
            throw new NotImplementedException();
        }
    }
}
