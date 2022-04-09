using MySocialNetwork.Domain.Enums;
using MySocialNetwork.Domain.ViewModel.Address;
using System.ComponentModel.DataAnnotations;

namespace MySocialNetwork.Domain.ViewModel.User
{
    public class UserViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Informe seu nome.")]
        [MinLength(3, ErrorMessage = "O nome deve conter ao menos 3 caracteres.")]

        public string? Name { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Informe seu email.")]
        [MinLength(3, ErrorMessage = "O email deve conter ao menos 3 caracteres.")]
        public string? Email { get; set; }

        [Display(Name = "Data de nascimento")]
        [Required(ErrorMessage = "Informe sua data de nascimento.")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Genêro")]
        [Required(ErrorMessage = "Informe seu genêro")]
        public Genre? Genre { get; set; }

        public List<AddressViewModel> Addresses { get; set; } = new List<AddressViewModel>();
    }
}
