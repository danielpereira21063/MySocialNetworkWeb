using System.ComponentModel.DataAnnotations;

namespace MySocialNetwork.Domain.ViewModel.Address
{
    public class AddressViewModel
    {
        public AddressViewModel()
        {

        }

        [Display(Name = "Rua")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string? Street { get; set; }

        [Display(Name = "Número")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string? Number { get; set; }

        [Display(Name = "Complemento")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string? Complement { get; set; }

        [Display(Name = "Cidade")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string? City { get; set; }

        [Display(Name = "Estado")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string? State { get; set; }

        [Display(Name = "Bairro")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string? District { get; set; }

        [Display(Name = "CEP")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string? PostalCode { get; set; }
    }
}
