using MySocialNetwork.Domain.Entities.UserEntities;
using MySocialNetwork.Domain.ViewModel.Address;

namespace MySocialNetwork.Domain.Interfaces
{
    public interface IAddressService
    {
        AddressViewModel? Find(int userId, int id);
        IEnumerable<AddressViewModel>? FindAllByUserId(int userId);
        AddressViewModel? Create(AddressViewModel? address);
        AddressViewModel? Update(AddressViewModel? address);
        AddressViewModel? Remove(AddressViewModel? address);
    }
}
