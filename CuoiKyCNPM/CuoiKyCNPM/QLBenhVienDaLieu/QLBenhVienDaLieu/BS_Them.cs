using QLBenhVienDaLieu.Database.Class;
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
    public partial class BS_Them : Form
    {
        SqlFunctionCaller funcCall = new SqlFunctionCaller();
        string formType = null;

        public BS_Them()
        {
            InitializeComponent();
            pn_themSKB.Hide();
            pn_themBA.Hide();
            dt_ba_giaTriBHYT.Value = DateTime.Now;
            dt_ba_giaTriBHYT.MaxDate = DateTime.Now;
        }

        private void BS_Them_Load(object sender, EventArgs e)
        {

        }

        public void SetForm(string type, string maHSBN)
        {
            switch (type)
            {
                case "skb":
                    tb_skb_maHSBN.Text = maHSBN;
                    formType = type;
                    pn_themSKB.Show();
                    break;
                case "ba":
                    tb_ba_maHSBN.Text = maHSBN;
                    formType = type;
                    pn_themBA.Show();
                    break;
            }
        }

        private void bt_themSKB_Click(object sender, EventArgs e)
        {
            funcCall.InsertSoKhamBenh(tb_skb_maHSBN.Text, tb_skb_maLK.Text, tb_skb_hoVaTen.Text, tb_skb_tuoi.Text, tb_skb_soBHYT.Text, tb_skb_diaChi.Text, tb_skb_nghe.Text, tb_skb_danToc.Text, tb_skb_trieuChung.Text, tb_skb_chanDoan.Text, tb_skb_ppDieuTri.Text, tb_skb_bs.Text, tb_skb_ghiChu.Text);
            MessageBox.Show("Tạo sổ khám bệnh thành công");
            this.Close();
        }

        private void bt_themBA_Click(object sender, EventArgs e)
        {
            funcCall.InsertBenhAn(tb_ba_maHSBN.Text, tb_ba_doiTuong.Text, dt_ba_giaTriBHYT.Value, tb_ba_hoTenThanNhan.Text, dt_ba_tgVaoVien.Value.ToString(), tb_ba_ttVao.Text, tb_ba_noiGT.Text, tb_ba_khoa.Text, tb_ba_chuyenKhoa.Text, tb_ba_tongSoNgay.Text, tb_ba_noiChuyen.Text, tb_ba_KKBhoacCC.Text, tb_ba_dieuTri.Text, tb_ba_kq.Text, tb_ba_giaiPhau.Text, tb_ba_benhLy.Text, tb_ba_tienSu.Text, tb_ba_toanThan.Text, tb_ba_coNang.Text, tb_ba_thuongTonCB.Text, tb_ba_coQuan.Text, tb_ba_tongKet.Text, tb_ba_tomTat.Text, tb_ba_ppDieuTri.Text, tb_ba_hoSoPA.Text);
            MessageBox.Show("Tạo bệnh án thành công");
            this.Close();
        }

        private void bt_huySKB_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void bt_huyBA_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
