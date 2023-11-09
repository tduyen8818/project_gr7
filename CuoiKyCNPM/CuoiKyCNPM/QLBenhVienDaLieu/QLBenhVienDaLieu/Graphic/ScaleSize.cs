using System.Drawing;
using System.Windows.Forms;

namespace QLBenhVienDaLieu.Graphic
{
    internal class ScaleSize
    {
        public static void Resize(Rectangle originalFormSize, Rectangle originalControlSize, Control control, Form form)
        {


            float xRatio = form.Width / (float)originalFormSize.Width;
            float yRatio = form.Height / (float)originalFormSize.Height;

            int newX = (int)(originalControlSize.Location.X * xRatio);
            int newY = (int)(originalControlSize.Location.Y * yRatio);

            int newWidth = (int)(originalControlSize.Width * xRatio);
            int newHeight = (int)(originalControlSize.Height * yRatio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);

        }

        public static void Resize(Rectangle originalFormSize, Rectangle originalControlSize, Control control, Form form, float sizeTextInitial)
        {


            float xRatio = form.Width / (float)originalFormSize.Width;
            float yRatio = form.Height / (float)originalFormSize.Height;

            int newX = (int)(originalControlSize.Location.X * xRatio);
            int newY = (int)(originalControlSize.Location.Y * yRatio);

            int newWidth = (int)(originalControlSize.Width * xRatio);
            int newHeight = (int)(originalControlSize.Height * yRatio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);

            if (control.Font != null)
            {
                control.Font = new Font(control.Font.Name, sizeTextInitial * (xRatio == 1 ? yRatio : xRatio), control.Font.Style);
            }

        }

        public static void Resize(Rectangle originalControlSize1, Rectangle originalControlSize, Control control, Control control1)
        {
            float xRatio = control1.Width / (float)originalControlSize1.Width;
            float yRatio = control1.Height / (float)originalControlSize1.Height;

            int newX = (int)(originalControlSize.Location.X * xRatio);
            int newY = (int)(originalControlSize.Location.Y * yRatio);

            int newWidth = (int)(originalControlSize.Width * xRatio);
            int newHeight = (int)(originalControlSize.Height * yRatio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);

        }


        public static void ResizeX(Rectangle originalFormSize, Rectangle originalControlSize, Control control, Form form)
        {
            float xRatio = form.Width / (float)originalFormSize.Width;


            int newX = (int)(originalControlSize.Location.X * xRatio);


            int newWidth = (int)(originalControlSize.Width * xRatio);


            control.Location = new Point(newX, control.Location.Y);
            control.Size = new Size(newWidth, control.Height);

        }

        public static void ResizeY(Rectangle originalFormSize, Rectangle originalControlSize, Control control, Form form)
        {
            float yRatio = form.Height / (float)originalFormSize.Height;

            int newY = (int)(originalControlSize.Location.Y * yRatio);

            int newHeight = (int)(originalControlSize.Height * yRatio);



            control.Location = new Point(control.Location.X, newY);
            control.Size = new Size(control.Width, newHeight);

        }
    }
}
