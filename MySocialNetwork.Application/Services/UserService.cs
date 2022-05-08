using AutoMapper;
using MySocialNetwork.Application.Interfaces;
using MySocialNetwork.Domain.Entities.UserEntities;
using MySocialNetwork.Domain.Interfaces;
using MySocialNetwork.Domain.ViewModel.User;

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
            _userRepositoy?.Save(userEntity);
        }

        public List<UserViewModel>? GetAll(string? searchString)
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

        public UserViewModel? GetByEmail(string email)
        {
            var userEntity = _userRepositoy.FindByEmail(email);
            return _mapper.Map<UserViewModel>(userEntity);
        }

        public UserViewModel? GetById(int id)
        {
            var userEntity = _userRepositoy?.Find(id);
            return _mapper?.Map<UserViewModel>(userEntity);
        }

        public List<UserViewModel>? GetAll()
        {
            throw new NotImplementedException();
        }

        public byte[]? GetProfilePicture(int userId)
        {
            return _userRepositoy.FindProfilePicture(userId);
        }
    }
}
