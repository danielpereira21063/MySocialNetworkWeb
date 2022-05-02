using MySocialNetwork.Infra.Data.Context;
using static System.Windows.Forms.ImageList;

namespace FormController.UI.Controllers
{
    public class ImageController : Base
    {
        public static Image ByteArrayToImage(byte[] byteArray)
        {
            var ms = new MemoryStream(byteArray);
            return Image.FromStream(ms);
        }

        public static byte[] ImageToByteArray(Image image)
        {
            var ms = new MemoryStream();
            image.Save(ms, image.RawFormat);
            return ms.ToArray();
        }

        public void SendProfilePictures(ImageCollection images)
        {
            var converter = new ImageConverter();

            var usersId = new List<int>(); //retornar uma lista com o id de todos os usuários sem fotos de perfil
            foreach (var img in images)
            {
                var byteImage = (byte[])converter.ConvertTo(img, typeof(byte[]));
                var base64Image = Convert.ToBase64String(byteImage);
            }

        }
    }
}
