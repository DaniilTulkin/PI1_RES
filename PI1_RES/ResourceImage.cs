using System.Windows.Media.Imaging;

namespace PI1_RES
{
    /// <summary>
    /// Gets the embedded resources image from the cbb.res assembly based on user provided file name with extension.
    /// </summary>
    public static class ResourceImage
    {
        #region public methods

        public static BitmapImage GetIcon(string name)
        {
            // Create the resource reader stream.
            var stream = ResourceAssembly.GetAssembly().GetManifestResourceStream(ResourceAssembly.GetNamespace() + "Images.Icons." + name);
            var image = new BitmapImage();

            // Contruct and return image
            image.BeginInit();
            image.StreamSource = stream;
            image.EndInit();

            // Return constructed BitmapImage
            return image;
        }

        #endregion
    }
}
