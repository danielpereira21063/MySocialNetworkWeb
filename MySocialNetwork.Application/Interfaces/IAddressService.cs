using MySocialNetwork.Domain.Entities.UserEntities;
using MySocialNetwork.Domain.ViewModel.Address;

namespace MySocialNetwork.Domain.Interfaces
{
    public interface IAddressRepository
    {
        Address? GetById(int userId, int id);
        IEnumerable<AddressViewModel>? GetAllByUserId(int userId);
        Address? Create(AddressViewModel? address);
        Address? Update(AddressViewModel? address);
        Address? Remove(AddressViewModel? address);
    }
}
