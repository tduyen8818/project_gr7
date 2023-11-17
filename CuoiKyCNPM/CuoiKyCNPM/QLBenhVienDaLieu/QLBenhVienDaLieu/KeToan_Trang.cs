using QLBenhVienDaLieu.Database.Function;
using QLBenhVienDaLieu.GiaoDien.KeToanTrangUI.HoaDonUI;
using QLBenhVienDaLieu.GiaoDien.KeToanTrangUI.ThongKeUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBenhVienDaLieu
{
    public partial class KeToan_Trang : Form
    {
        private string sDT;
        private SqlFunctionCaller sqlFunctionCaller;

        private Rectangle originalForm;

        public KeToan_Trang(string sDT, SqlFunctionCaller sqlFunctionCaller)
        {
            this.sDT = sDT;
            this.sqlFunctionCaller = sqlFunctionCaller;

            InitializeComponent();
           
            originalForm = new Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height);
            guna2CustomGradientPanel2.Region = Graphic.Draw.RoundedRectangle(0, 0, guna2CustomGradientPanel2.Width, guna2CustomGradientPanel2.Height, 20, 20);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            TaiKhoan_KT taiKhoanForm = new TaiKhoan_KT(sDT);
            this.Hide();
            taiKhoanForm.ShowDialog();
            this.Close();
        }

        private void btn_TrangChu_Click(object sender, EventArgs e)
        {

        }

        private void btn_LichLamViec_Click(object sender, EventArgs e)
        {
            LichLamViec_KT LichLamViec = new LichLamViec_KT(sDT);
            this.Hide();
            LichLamViec.ShowDialog();
            this.Close();
        }

        private void buttonHoaDon_Click(object sender, EventArgs e)
        {
            guna2CustomGradientPanel2.Controls.Clear();

            DanhSachHoaDon danhSachHoaDon = new DanhSachHoaDon(sqlFunctionCaller);

            danhSachHoaDon.TopLevel = false;
            danhSachHoaDon.Dock = DockStyle.Fill;

            guna2CustomGradientPanel2.Controls.Add(danhSachHoaDon);
            guna2CustomGradientPanel2.Tag = danhSachHoaDon;

            danhSachHoaDon.Show();
        }

        private void buttonThongKe_Click(object sender, EventArgs e)
        {
            guna2CustomGradientPanel2.Controls.Clear();

            ThongKeDoanhThu thongKeDoanhThu = new ThongKeDoanhThu(sqlFunctionCaller);

            thongKeDoanhThu.TopLevel = false;
            thongKeDoanhThu.Dock = DockStyle.Fill;

            guna2CustomGradientPanel2.Controls.Add(thongKeDoanhThu);
            guna2CustomGradientPanel2.Tag = thongKeDoanhThu;

            thongKeDoanhThu.Show();
        }

        private void KeToan_Trang_Resize(object sender, EventArgs e)
        {
            if (originalForm.Width != 0)
            {
                guna2CustomGradientPanel2.Region = Graphic.Draw.RoundedRectangle(0, 0, guna2CustomGradientPanel2.Width, guna2CustomGradientPanel2.Height, 20, 20);
            }
        }
    }
}
