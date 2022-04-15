using MySocialNetwork.Application.Interfaces;
using MySocialNetwork.Domain.ViewModel.Address;

namespace MySocialNetwork.Domain.Interfaces
{
    public interface IAddressService : IGenericService<AddressViewModel>
    {
        AddressViewModel? GetById(int userId, int id);
        List<AddressViewModel>? GetAll(int userId);
        List<AddressViewModel>? GetAllByUserId(int userId);
    }
}
