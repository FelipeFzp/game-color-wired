using System.Drawing;

namespace GameColor.Core.Models
{
    public class ColorExpression
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public Color TargetColor { get; private set; }
        public Color ResultColor { get; private set; }
        public int Tolerance { get; private set; }
        public ColorExpression(int x, int y, Color targetColor, Color resultColor, int tolerance)
        {
            X = x;
            Y = y;
            TargetColor = targetColor;
            ResultColor = resultColor;
            Tolerance = tolerance;
        }
    }
}
