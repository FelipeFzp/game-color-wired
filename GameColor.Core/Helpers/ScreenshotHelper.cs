using System.Drawing;
using System.Drawing.Imaging;

namespace GameColor.Core.Helpers
{
    public static class ScreenshotHelper
    {
        public static Graphics ToGraphics(this Bitmap image) =>
            Graphics.FromImage(image);

        public static Bitmap TakeScreenshot(int width, int height, int left, int top)
        {
            var bitmap = new Bitmap(width, height, PixelFormat.Format32bppArgb);
            var graphics = bitmap.ToGraphics();
            graphics.CopyFromScreen(left, top, 0, 0, new Size(bitmap.Width, bitmap.Height), CopyPixelOperation.SourceCopy);

            return bitmap;
        }

        public static void MarkPixel(this Bitmap bitmap, int x, int y, Color color)
        {
            //left
            try { bitmap.SetPixel(x - 2, y, color); } catch { }
            try { bitmap.SetPixel(x - 1, y, color); } catch { }

            //top
            try { bitmap.SetPixel(x, y + 2, color); } catch { }
            try { bitmap.SetPixel(x, y + 1, color); } catch { }

            //right
            try { bitmap.SetPixel(x + 2, y, color); } catch { }
            try { bitmap.SetPixel(x + 1, y, color); } catch { }

            //bottom
            try { bitmap.SetPixel(x, y - 2, color); } catch { }
            try { bitmap.SetPixel(x, y - 1, color); } catch { }
        }
    }
}
