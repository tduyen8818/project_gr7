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
    public partial class BS_Kham_Benh : Form
    {
        private string sDT;
        
        public BS_Kham_Benh(string sDT)
        {
            InitializeComponent();
            this.sDT = sDT;
        }

        private void BS_Kham_Benh_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            TaiKhoan_BS taiKhoanForm = new TaiKhoan_BS(sDT);
            this.Hide();
            taiKhoanForm.ShowDialog();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LichLamViec_BS lichLamViec = new LichLamViec_BS(sDT);
            this.Hide();
            lichLamViec.ShowDialog();
            this.Close();
        }
    }
}
