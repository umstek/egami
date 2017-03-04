using System.Drawing;

namespace egami
{
    public class Resizer
    {
        public static Bitmap Resize2(Image image, sbyte power)
        {
            var source = new Bitmap(image);
            if (power == 0) return source;

            // source.LockBits(new Rectangle(new Point(), source.Size), ImageLockMode.ReadOnly, image.PixelFormat);

            var upscale = power > 0;
            var scale = upscale ? 1 << power : 1 << -power;

            var destination = upscale
                ? new Bitmap(image.Width * scale, image.Height * scale, image.PixelFormat)
                : new Bitmap(image.Width / scale, image.Height / scale, image.PixelFormat);

            // destination.LockBits(new Rectangle(new Point(), destination.Size), ImageLockMode.WriteOnly, image.PixelFormat);

            if (upscale)
                for (var i = 0; i < source.Width; i++)
                for (var j = 0; j < source.Height; j++)
                for (var k = 0; k < scale; k++)
                for (var l = 0; l < scale; l++)
                    destination.SetPixel(i * scale + k, j * scale + l, source.GetPixel(i, j));
            else // downscale
                for (var i = 0; i < destination.Width; i++)
                for (var j = 0; j < destination.Height; j++)
                    destination.SetPixel(i, j, source.GetPixel(i * scale, j * scale));

            return destination;
        }
    }
}