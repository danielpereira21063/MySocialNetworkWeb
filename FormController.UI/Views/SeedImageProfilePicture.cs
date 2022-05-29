using FormController.UI.Controllers;
using FormController.UI.Util;

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

        private void CompressAndSave(string[] images, long quality = 80L)
        {
            var converter = new ImageConverter();
            //var param = new EncoderParameters(1);
            //param.Param[0] = new EncoderParameter(Encoder.Quality, quality);
            //var codec = ImageCodecInfo.GetImageDecoders().FirstOrDefault(c => c.FormatID == ImageFormat.Jpeg.Guid || c.FormatID == ImageFormat.Png.Guid);
            //var ms = new MemoryStream();

            foreach (var file in images)
            {
                var image = ExImage.ByteArrayToImage(File.ReadAllBytes(file));
                //image.Save(ms, codec, param);
                var byteImage = ExImage.ImageToByteArray(image);
                ImgListProfilePictures.Images.Add(ExImage.ByteArrayToImage(byteImage));
            }
        }
    }
}
