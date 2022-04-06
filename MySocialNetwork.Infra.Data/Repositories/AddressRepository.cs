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

        public Address? Remove(Address address)
        {
            throw new NotImplementedException();
        }

        public Address? Update(Address address)
        {
            throw new NotImplementedException();
        }
    }
}
