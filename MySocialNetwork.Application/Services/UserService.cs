using AutoMapper;
using MySocialNetwork.Application.Interfaces;
using MySocialNetwork.Domain.Entities.UserEntities;
using MySocialNetwork.Domain.Interfaces;
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
        private readonly IUserRepository? _userRepositoy;
        private readonly IMapper? _mapper;

        public UserService(IUserRepository? userRepository, IMapper? mapper)
        {
            _userRepositoy = userRepository;
            _mapper = mapper;
        }

        public void Create(UserViewModel? user)
        {
            var userEntity = _mapper?.Map<User>(user);
            _userRepositoy?.Create(userEntity);
        }

        public UserViewModel? GetUser(int id)
        {
            var userEntity = _userRepositoy?.Find(id);
            return _mapper?.Map<UserViewModel>(userEntity);
        }

        public IEnumerable<UserViewModel>? GetAll(string? searchString)
        {
            var usersEntity = _userRepositoy?.FindAll(searchString);
            return _mapper?.Map<List<UserViewModel>>(usersEntity);
        }

        public void Remove(UserViewModel? user)
        {
            var userEntity = _mapper?.Map<User>(user);
            _userRepositoy?.Remove(userEntity);
        }

        public void Update(UserViewModel? user)
        {
            var userEntity = _mapper?.Map<User>(user);
            _userRepositoy?.Update(userEntity);
        }
    }
}
