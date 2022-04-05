using MySocialNetwork.Domain.Entities.UserEntities;
using MySocialNetwork.Domain.ViewModel.Address;

namespace MySocialNetwork.Domain.Interfaces
{
    public interface IAddressService
    {
        AddressViewModel? GetById(int userId, int id);
        IEnumerable<AddressViewModel>? GetAllByUserId(int userId);
        AddressViewModel? Create(AddressViewModel? address);
        AddressViewModel? Update(AddressViewModel? address);
        AddressViewModel? Remove(AddressViewModel? address);
    }
}
