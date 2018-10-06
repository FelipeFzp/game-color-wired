using ColorMine.ColorSpaces;

namespace GameColor.Core.Helpers
{
    public static class ColorHelper
    {
        public static Lab CreateLabFromRgb(int r, int g, int b)
        {
            var rgb = new Rgb();
            rgb.R = r;
            rgb.G = g;
            rgb.B = b;

            return rgb.To<Lab>();
        }
    }
}
