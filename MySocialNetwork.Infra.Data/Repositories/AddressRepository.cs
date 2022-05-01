using MySocialNetwork.Domain.Entities.UserEntities;
using MySocialNetwork.Domain.Interfaces;

namespace MySocialNetwork.Infra.Data.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        public Address? Save(Address? address)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Address>? FindAll(int userId)
        {
            throw new NotImplementedException();
        }

        public Address? Find(int userId, int id)
        {
            throw new NotImplementedException();
        }

#pragma warning disable CS8767 // Nullability of reference types in type of parameter 'address' of 'Address? AddressRepository.Remove(Address address)' doesn't match implicitly implemented member 'Address? IAddressRepository.Remove(Address? address)' (possibly because of nullability attributes).
        public Address? Remove(Address address)
#pragma warning restore CS8767 // Nullability of reference types in type of parameter 'address' of 'Address? AddressRepository.Remove(Address address)' doesn't match implicitly implemented member 'Address? IAddressRepository.Remove(Address? address)' (possibly because of nullability attributes).
        {
            throw new NotImplementedException();
        }

#pragma warning disable CS8767 // Nullability of reference types in type of parameter 'address' of 'Address? AddressRepository.Update(Address address)' doesn't match implicitly implemented member 'Address? IAddressRepository.Update(Address? address)' (possibly because of nullability attributes).
        public Address? Update(Address address)
#pragma warning restore CS8767 // Nullability of reference types in type of parameter 'address' of 'Address? AddressRepository.Update(Address address)' doesn't match implicitly implemented member 'Address? IAddressRepository.Update(Address? address)' (possibly because of nullability attributes).
        {
            throw new NotImplementedException();
        }
    }
}
