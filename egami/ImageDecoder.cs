using System.Drawing;

namespace egami
{
    public static class ImageDecoder
    {
        public static Bitmap ImageToBitmap(Image image)
        {
            return new Bitmap(image);
        }
    }
}