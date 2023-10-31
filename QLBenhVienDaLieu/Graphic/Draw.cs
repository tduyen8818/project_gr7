using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

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
