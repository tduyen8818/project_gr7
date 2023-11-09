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

        public KeToan_Trang(string sDT)
        {
            InitializeComponent();
            this.sDT = sDT;
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
    }
}
