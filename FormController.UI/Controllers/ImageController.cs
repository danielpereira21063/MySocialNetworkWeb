using FormController.UI.Services;
using static System.Windows.Forms.ImageList;

namespace FormController.UI.Controllers
{
    public class ImageController
    {
        private ImageService _imageService { get; set; }
        public ImageController()
        {
            _imageService = new ImageService();
        }

        public void SendProfilePictures(ImageCollection images)
        {
            //var usersId = new List<int>(); //retornar uma lista com o id de todos os usuários sem fotos de perfil
            //for (int i = 1; i <= 30; i++)
            //{
            //    usersId.Add(i);
            //}
            try
            {
                int userId = 1;

                var converter = new ImageConverter();
                foreach (var img in images)
                {
                    var byteImage = (byte[])converter.ConvertTo(img, typeof(byte[]));
                    var base64Image = Convert.ToBase64String(byteImage);
                    _imageService.SendImage($"/User/AddProfilePicture/{userId}", base64Image);
                    userId++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
