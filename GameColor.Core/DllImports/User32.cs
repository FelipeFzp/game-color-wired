using System;
using System.Runtime.InteropServices;

namespace GameColor.Core.DllImports
{
    public class User32
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct Rectangle
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowRect(IntPtr hWnd, ref Rectangle rect);

        [DllImport("user32.dll")]
        public static extern IntPtr OpenFile(IntPtr hWnd, ref Rectangle rect);
    }
}
