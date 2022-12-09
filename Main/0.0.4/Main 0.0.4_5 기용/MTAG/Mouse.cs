using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;



namespace MTAG
{
    internal class Mouse
    {
        public static Mouse mouse;
        public Mouse()
        {
            mouse = this;
        }



        [DllImport("user32.dll", SetLastError = true)] private static extern IntPtr GetDesktopWindow();
        [DllImport("user32.dll", SetLastError = true)] private static extern IntPtr GetWindowDC(IntPtr window);
        [DllImport("gdi32.dll",  SetLastError = true)] private static extern uint GetPixel(IntPtr dc, int x, int y);



        private const UInt32 SPI_SETMOUSESPEED = 0x0071;
        [DllImport("User32.dll")]
        private static extern Boolean SystemParametersInfo(
            UInt32 uiAction,
            UInt32 uiParam,
            UInt32 pvParam,
            UInt32 fWinIni);



        public Color GetPointColor(Point p)
        {
            IntPtr desk = GetDesktopWindow();
            IntPtr dc   = GetWindowDC(desk);
            int    pxl  = (int)GetPixel(dc, p.X, p.Y);

            return Color.FromArgb(
                255,
                (byte)((pxl >> 0)  & 0xff),
                (byte)((pxl >> 8)  & 0xff),
                (byte) (pxl >> 16) & 0xff);
        }



        public void SetMouseSpeed(int s)
        {
            SystemParametersInfo(SPI_SETMOUSESPEED, 0, (uint)s, 0);
        }



        public void SetMousePosition(Point p)
        {
            Cursor.Position = p;
        }



        public void SetMouseActivityArea(Form f, int a)
        {
            Cursor.Clip = ((a == 1) ? new Rectangle(f.Location, f.Size) : default);
        }
    }
}
