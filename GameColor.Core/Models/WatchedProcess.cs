namespace GameColor.Core.Models
{
    public class WatchedProcess
    {
        public string Name { get; private set; }
        public int Left { get; private set; }
        public int Top { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public ColorExpression[] Expression { get; private set; }
        
        public WatchedProcess(string processName, int sourceX, int sourceY, int width, int height, params ColorExpression[] expression)
        {
            Left = sourceX;
            Top = sourceY;
            Width = width;
            Height = height;
            Name = processName;
            Expression = expression;
        }
    }
}
