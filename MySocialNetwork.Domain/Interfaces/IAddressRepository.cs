using MySocialNetwork.Domain.Entities.UserEntities;
using MySocialNetwork.Domain.Interfaces.Abstractions;

namespace MySocialNetwork.Domain.Interfaces
{
    public interface IAddressRepository : IUnitOfWork
    {
        Address? Find(int userId, int id);
        IEnumerable<Address>? FindAll(int userId);
        Address? Save(Address? address);
        Address? Update(Address? address);
        Address? Remove(Address? address);
    }
}
