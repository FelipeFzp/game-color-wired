using GameColor.Common.Enums;
using System.Drawing;

namespace GameColor.Core.Helpers
{
    public static class Bitmap
    {
        public static Graphics ToGraphics(this System.Drawing.Bitmap image) =>
            Graphics.FromImage(image);

        public static void MarkPixel(this System.Drawing.Bitmap bitmap, int x, int y, AcceptedColor color)
        {
            var knownColor = Color.Transparent;
            switch (color)
            {
                case AcceptedColor.Red:
                    knownColor = Color.LimeGreen;
                    break;
                case AcceptedColor.Green:
                    knownColor = Color.Yellow;
                    break;
                case AcceptedColor.Blue:
                    knownColor = Color.Red;
                    break;
                case AcceptedColor.Yellow:
                    knownColor = Color.Yellow;
                    break;
                case AcceptedColor.Magenta:
                    knownColor = Color.Purple;
                    break;
                case AcceptedColor.LightBlue:
                    knownColor = Color.Aqua;
                    break;
            }

            //left
            try { bitmap.SetPixel(x - 2, y, knownColor); } catch { }
            try { bitmap.SetPixel(x - 1, y, knownColor); } catch { }

            //top
            try { bitmap.SetPixel(x, y + 2, knownColor); } catch { }
            try { bitmap.SetPixel(x, y + 1, knownColor); } catch { }

            //right
            try { bitmap.SetPixel(x + 2, y, knownColor); } catch { }
            try { bitmap.SetPixel(x + 1, y, knownColor); } catch { }

            //bottom
            try { bitmap.SetPixel(x, y - 2, knownColor); } catch { }
            try { bitmap.SetPixel(x, y - 1, knownColor); } catch { }
        }
    }
}
