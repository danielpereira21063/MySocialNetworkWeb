using AutoMapper;
using MySocialNetwork.Domain.Entities.UserEntities;
using MySocialNetwork.Domain.Interfaces;
using MySocialNetwork.Domain.ViewModel.Address;

namespace MySocialNetwork.Application.Services
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository? _addressRepository;
        private readonly IMapper? _mapper;

        public AddressService(IAddressRepository? addressRepository, IMapper mapper)
        {
            _addressRepository = addressRepository;
            _mapper = mapper;
        }

        public void Create(AddressViewModel? entity)
        {
            throw new NotImplementedException();
        }

        public List<AddressViewModel>? GetAll(int userId)
        {
            throw new NotImplementedException();
        }

        public List<AddressViewModel>? GetAll()
        {
            throw new NotImplementedException();
        }

        public List<AddressViewModel>? GetAllByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        public AddressViewModel? GetById(int userId, int id)
        {
            throw new NotImplementedException();
        }

        public AddressViewModel? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(AddressViewModel? entity)
        {
            throw new NotImplementedException();
        }

        public void Update(AddressViewModel? entity)
        {
            throw new NotImplementedException();
        }
    }
}
