using MySocialNetwork.Domain.ViewModel.Image;

namespace MySocialNetwork.WebUI.Models.ViewModels
{
    public class NewPostViewModel
    {
        public string? Subtitle { get; set; }
        public List<NewImageViewModel>? Images { get; set; }
    }
}
