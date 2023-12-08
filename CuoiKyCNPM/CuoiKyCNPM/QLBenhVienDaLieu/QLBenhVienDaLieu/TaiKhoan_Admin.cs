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
    public partial class TaiKhoan_Admin : Form
    {
        public TaiKhoan_Admin()
        {
            InitializeComponent();
        }

        private void btn_LichLamViec_Click(object sender, EventArgs e)
        {
            this.Hide();
            LichLamViec_Trang TaiKhoan = new LichLamViec_Trang();
            TaiKhoan.ShowDialog();
            this.Close();
        }

        private void btn_TaiKhoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            TaiKhoan_Admin TaiKhoan = new TaiKhoan_Admin();
            TaiKhoan.ShowDialog();
            this.Close();
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap TaiKhoan = new DangNhap();
            TaiKhoan.ShowDialog();
            this.Close();
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Trang TaiKhoan = new Admin_Trang();
            TaiKhoan.ShowDialog();
            this.Close();
        }
    }
}
