using MySocialNetwork.Domain.Enums;
using MySocialNetwork.Domain.ViewModel.Address;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MySocialNetwork.Domain.ViewModel.User
{
    public class UserViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string? Name { get; set; }

        [Display(Name = "Email")]
        public string? Email { get; set; }

        [Display(Name = "Data de nascimento")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Genêro")]
        [Required(ErrorMessage = "Informe seu genêro")]
        public Genre? Genre { get; set; }

        [JsonIgnore]
        public byte[]? ProfilePicture { get; set; }

        public List<AddressViewModel> Addresses { get; set; } = new List<AddressViewModel>();
    }
}
