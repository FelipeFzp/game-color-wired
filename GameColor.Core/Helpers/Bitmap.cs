using GameColor.Core.Enums;
using System.Drawing;

namespace GameColor.Core.Helpers
{
    public static class Bitmap
    {
        public static Graphics ToGraphics(this System.Drawing.Bitmap image) =>
            Graphics.FromImage(image);

        public static void MarkPixel(this System.Drawing.Bitmap bitmap, int x, int y, Color color)
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
