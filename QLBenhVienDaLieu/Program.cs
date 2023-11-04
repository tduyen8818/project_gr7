using QLBenhVienDaLieu.GiaoDien.Ho_So_Benh_Nhan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLBenhVienDaLieu
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BenhNhan_Trang("0111111111"));
        }
    }
}
