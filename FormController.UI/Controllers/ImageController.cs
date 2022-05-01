using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using static System.Windows.Forms.ImageList;
using System.Drawing.Imaging;

namespace FormController.UI.Controllers
{
    public class ImageController
    {
        private HttpClient client;

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

        public static void SendProfilePictures(ImageCollection images)
        {
            var converter = new ImageConverter();

            foreach (var img in images)
            {
                var imgByte = (byte[])converter.ConvertTo(img,typeof(byte[]));
            }

        }
    }
}
