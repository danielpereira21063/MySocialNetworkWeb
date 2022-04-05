using MySocialNetwork.Domain.Entities.UserEntities;

namespace MySocialNetwork.Domain.Interfaces
{
    public interface IAddressRepository
    {
        Address? GetById(int userId, int id);
        IEnumerable<Address>? GetAllByUserId(int userId);
        Address? Create(Address address);
        Address? Update(Address address);
        Address? Remove(Address address);
    }
}
