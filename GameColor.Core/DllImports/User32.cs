using System;
using System.Diagnostics;
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

        [DllImport("user32.dll")]
        public static extern bool ShowWindowAsync(HandleRef hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr WindowHandle);

        public const int SW_SHOWNORMAL = 1;
        public const int SW_SHOWMINIMIZED = 2;
        public const int SW_SHOWMAXIMIZED = 3;
        public const int SW_RESTORE = 9;
        public static void BringProcessTo(Process process, int position)
        {
            if (process == null)
                return;

            ShowWindowAsync(new HandleRef(null, process.MainWindowHandle), position);
            SetForegroundWindow(process.MainWindowHandle);
        }
    }
}
