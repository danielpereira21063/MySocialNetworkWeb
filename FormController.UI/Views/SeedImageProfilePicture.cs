using FormController.UI.Controllers;
using System.Drawing.Imaging;

namespace FormController.UI.Views
{
    public partial class SeedImageProfilePicture : Form
    {
        private ImageController _imageController;
        public SeedImageProfilePicture()
        {
            InitializeComponent();
            _imageController = new ImageController();
        }

        private void BtnLoadProfilePictures_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Multiselect = true;
                openFileDialog.ValidateNames = true;
                openFileDialog.Filter = "JPG|*jpg|JPEG|*.jpeg|PNG|*.png";

                var showDialog = openFileDialog.ShowDialog();
                if (showDialog != DialogResult.OK && showDialog != DialogResult.Cancel)
                {
                    throw new Exception("Erro ao carregar imagem.");
                }


                int qtyImages = openFileDialog.FileNames.Count();
                qtyProfilePicturesLoaded.Text = $"{qtyImages} imagens carregadas";

                CompressAndSave(openFileDialog.FileNames);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SendProfilePictures_Click(object sender, EventArgs e)
        {
            var images = ImgListProfilePictures.Images;

            if (images.Count == 0)
            {
                MessageBox.Show("Nenhuma imagem foi selecionada.");
                return;
            }


            _imageController.SendProfilePictures(images);
        }

        private void CompressAndSave(string[] images, long quality = 40L)
        {
            var param = new EncoderParameters(1);
            var converter = new ImageConverter();
            param.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);
            var codec = ImageCodecInfo.GetImageDecoders().FirstOrDefault(c => c.FormatID == ImageFormat.Jpeg.Guid || c.FormatID == ImageFormat.Png.Guid);
            var ms = new MemoryStream();

            foreach (var file in images)
            {
                var image = ImageController.ByteArrayToImage(File.ReadAllBytes(file));
                image.Save(ms, codec, param);
                var byteImage = ImageController.ImageToByteArray(image);
                ImgListProfilePictures.Images.Add(ImageController.ByteArrayToImage(byteImage));
            }
        }
    }
}
