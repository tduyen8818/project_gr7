using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace QLBenhVienDaLieu.Graphic
{
    internal class Draw
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int xLeftTop, int yLeftTop, int xRightBottom, int yRightBottom, int width, int height);

        public static Region RoundedRectangle(int xLeftTop, int yLeftTop, int xRightBottom, int yRightBottom, int width, int height)
        {
            return Region.FromHrgn(CreateRoundRectRgn(xLeftTop, yLeftTop, xRightBottom, yRightBottom, width, height));
        }
    }
}
