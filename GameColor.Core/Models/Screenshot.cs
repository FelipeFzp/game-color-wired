using GameColor.Core.DllImports;
using System.Drawing;

namespace GameColor.Core.Models
{
    public class Screenshot
    {
        public Bitmap Bitmap { get; private set; }
        public User32.Rectangle Rectangle { get; private set; }
        public Screenshot(Bitmap image, User32.Rectangle rectangle)
        {
            Bitmap = image;
            Rectangle = rectangle;
        }
    }
}
