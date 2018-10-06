using GameColor.Common.Enums;
using GameColor.Core.Enums;
using System.Drawing;

namespace GameColor.Core.Models
{
    public class ColorExpression
    {
        public int PixelIndex { get; private set; }
        public Color TargetColor { get; private set; }
        public AcceptedColor Status { get; private set; }
        public EvaluationStrategy Strategy { get; private set; }
        public int Priority { get; private set; }
        public int Tolerance { get; private set; }
        public ColorExpression(int pixelIndex, Color targetColor, AcceptedColor status, int priority, int tolerance, EvaluationStrategy strategy)
        {
            TargetColor = targetColor;
            PixelIndex = pixelIndex;
            Status = status;
            Priority = priority;
            Tolerance = tolerance;
            Strategy = strategy;
        }
        public ColorExpression(int pixelIndex, Color targetColor, int priority, int tolerance, EvaluationStrategy strategy)
        {
            TargetColor = targetColor;
            PixelIndex = pixelIndex;
            Priority = priority;
            Tolerance = tolerance;
            Strategy = strategy;
        }
    }
}
