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
        public AddressViewModel? Create(AddressViewModel? address)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AddressViewModel>? GetAllByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        public AddressViewModel? GetById(int userId, int id)
        {
            throw new NotImplementedException();
        }

        public AddressViewModel? Remove(AddressViewModel? address)
        {
            throw new NotImplementedException();
        }

        public AddressViewModel? Update(AddressViewModel? address)
        {
            throw new NotImplementedException();
        }
    }
}
