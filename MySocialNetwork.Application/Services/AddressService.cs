using AutoMapper;
using MySocialNetwork.Domain.Entities.UserEntities;
using MySocialNetwork.Domain.Interfaces;
using MySocialNetwork.Domain.ViewModel.Address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public AddressViewModel? Create(AddressViewModel? address)
        {
            var addressEntity = _mapper?.Map<Address>(address);
            _addressRepository?.Create(addressEntity);
            return address;
        }

        public IEnumerable<AddressViewModel>? FindAllByUserId(int userId)
        {
            var addresses = _addressRepository?.FindAll(userId);
            return _mapper?.Map<List<AddressViewModel>>(addresses);
        }

        public AddressViewModel? Find(int userId, int id)
        {
           var address = _addressRepository?.Find(userId, id);

            return _mapper?.Map<AddressViewModel>(address);
        }

        public AddressViewModel? Remove(AddressViewModel? address)
        {
            var addressEntity = _mapper?.Map<Address>(address);
            _addressRepository?.Remove(addressEntity);
            return address;
        }

        public AddressViewModel? Update(AddressViewModel? address)
        {
            var addressEntity = _mapper?.Map<Address>(address);
            _addressRepository?.Update(addressEntity);
            return address;
        }
    }
}
