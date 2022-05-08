namespace FormController.UI.Util
{
    public static class ExImage
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

    }
}
