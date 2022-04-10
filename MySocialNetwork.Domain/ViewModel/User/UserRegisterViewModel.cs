using MySocialNetwork.Domain.ViewModel.Address;
using System.ComponentModel.DataAnnotations;

namespace MySocialNetwork.Domain.ViewModel.User
{
    public class UserRegisterViewModel
    {

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

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Informa uma senha")]
        [MinLength(8, ErrorMessage = "A senha deve ter no mínimo 8 caracteres.")]
        public string? Password { get; set; }

        [Display(Name = "Genêro")]
        [Required(ErrorMessage = "Informe seu genêro")]
        public string? Genre { get; set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Confirme sua senha")]
        public string? PasswordConfirmation { get; set; }

        public AddressViewModel Address { get; set; }

    }

}
