using System.ComponentModel.DataAnnotations;

namespace MySocialNetwork.WebUI.Models.ViewModels
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
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Insira uma senha")]
        [MinLength(8, ErrorMessage = "A senha deve ter no mínimo 8 caracteres.")]
        public string? Password { get; set; }

        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "As senhas não são iguais")]
        [Required(ErrorMessage = "Confirme sua senha")]
        public string? PasswordConfirmation { get; set; }


        [Display(Name = "Genêro")]
        [Required(ErrorMessage = "Informe seu genêro")]
        public string? Genre { get; set; }

        //public AddressViewModel Address { get; set; }
    }
}
