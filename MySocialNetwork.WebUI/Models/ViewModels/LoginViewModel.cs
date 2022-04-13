using System.ComponentModel.DataAnnotations;

namespace MySocialNetwork.WebUI.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informe seu email")]
        public string Email { get; set; }
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
    }
}
