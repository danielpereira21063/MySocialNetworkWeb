using MySocialNetwork.Domain.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySocialNetwork.Domain.ViewModel.User
{
    public class UserRegisterViewModel
    {
        public UserRegisterViewModel()
        {
            ValidadeModel();
        }

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
        [Required(ErrorMessage = "Informe uma senha.")]
        [MinLength(8, ErrorMessage = "A senha deve conter ao menos 8 caracteres.")]


        public string? Password { get; set; }
        public string? ConfirmPassword { get; set; }


        private void ValidadeModel()
        {
            DomainException.When(Password != ConfirmPassword, "As senhas não são iguais.");
        }
    }
}
