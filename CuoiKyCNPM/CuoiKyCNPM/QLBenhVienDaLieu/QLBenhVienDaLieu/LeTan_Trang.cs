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
    public partial class LeTan_Trang : Form
    {
        private string sDT;
        public LeTan_Trang(string sDT)
        {
            InitializeComponent();
            this.sDT = sDT;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TaiKhoan_LT TaiKhoan = new TaiKhoan_LT(sDT);
            this.Hide();
            TaiKhoan.ShowDialog();
            this.Close();
        }

        private void btn_TrangChu_Click(object sender, EventArgs e)
        {

        }

        private void btn_LichLamViec_Click(object sender, EventArgs e)
        {
            LichLamViec_LT LichLamViec = new LichLamViec_LT(sDT);
            this.Hide();
            LichLamViec.ShowDialog();
            this.Close();
        }
    }
}
