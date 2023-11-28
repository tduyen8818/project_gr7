using QLBenhVienDaLieu.Database.Function;
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
    public partial class BS_ThemToaThuoc : Form
    {
        public BS_ThemToaThuoc()
        {
            InitializeComponent();
        }
        SqlFunctionCaller funcCall = new SqlFunctionCaller();
        public void SetInfo(string maBA)
        {
            tb_maBA.Text = maBA;
        }

        private void bt_huySKB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_themSKB_Click(object sender, EventArgs e)
        {
            funcCall.InsertToaThuoc(tb_stt.Text, tb_maThuoc.Text, tb_maBA.Text, tb_tenThuoc.Text, Int32.Parse(tb_soLuong.Text), tb_dang.Text, tb_ghiChu.Text);
            MessageBox.Show("Thêm toa thuốc thành công");
            this.Close();
        }
    }
}
