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
    public partial class BS_Sua : Form
    {
        SqlFunctionCaller funcCall = new SqlFunctionCaller();
        string formType = null;

        public BS_Sua()
        {
            InitializeComponent();
            pn_suaSKB.Hide();
            pn_suaBA.Hide();
            dt_ba_giaTriBHYT.Value = DateTime.Now;
        }

        private void BS_Sua_Load(object sender, EventArgs e)
        {

        }

        public void SetForm(string type, DataGridViewRow table)
        {
            switch (type)
            {
                case "skb":
                    tb_skb_maHSBN.Text = table.Cells["MaHoSoBenhNhan"].Value.ToString();
                    tb_skb_maLK.Text = table.Cells["MaLichKham"].Value.ToString();
                    tb_skb_hoVaTen.Text = table.Cells["HoVaTen"].Value.ToString();
                    tb_skb_tuoi.Text = table.Cells["Tuoi"].Value.ToString();
                    tb_skb_soBHYT.Text = table.Cells["SoTheBHYT"].Value.ToString();
                    tb_skb_diaChi.Text = table.Cells["DiaChi"].Value.ToString();
                    tb_skb_nghe.Text = table.Cells["NgheNghiep"].Value.ToString();
                    tb_skb_danToc.Text = table.Cells["DanToc"].Value.ToString();
                    tb_skb_trieuChung.Text = table.Cells["TrieuChung"].Value.ToString();
                    tb_skb_chanDoan.Text = table.Cells["ChanDoan"].Value.ToString();
                    tb_skb_ppDieuTri.Text = table.Cells["PhuongPhapDieuTri"].Value.ToString();
                    tb_skb_bs.Text = table.Cells["BSKhamBenh"].Value.ToString();
                    tb_skb_ghiChu.Text = table.Cells["GhiChu"].Value.ToString();
                    pn_suaSKB.Show();
                    break;
                case "ba":
                    tb_ba_maBA.Text = table.Cells["MaBenhAn"].Value.ToString();
                    tb_ba_maHSBN.Text = table.Cells["MaHoSoBenhNhan"].Value.ToString();
                    tb_ba_doiTuong.Text = table.Cells["DoiTuong"].Value.ToString();
                    dt_ba_giaTriBHYT.Value = (DateTime)table.Cells["GiaTriBHYT"].Value;
                    tb_ba_hoTenThanNhan.Text = table.Cells["HoTenThanNhan"].Value.ToString();
                    tb_ba_tgVaoVien.Text = table.Cells["ThoiGianVaoVien"].Value.ToString();
                    tb_ba_ttVao.Text = table.Cells["TrucTiepVao"].Value.ToString();
                    tb_ba_noiGT.Text = table.Cells["NoiGioiThieu"].Value.ToString();
                    tb_ba_khoa.Text = table.Cells["VaoKhoa"].Value.ToString();
                    tb_ba_chuyenKhoa.Text = table.Cells["ChuyenKhoa"].Value.ToString();
                    tb_ba_tongSoNgay.Text = table.Cells["TongSoNgayDieuTri"].Value.ToString();
                    tb_ba_noiChuyen.Text = table.Cells["NoiChuyenDen"].Value.ToString();
                    tb_ba_KKBhoacCC.Text = table.Cells["KKBorCapCuu"].Value.ToString();
                    tb_ba_dieuTri.Text = table.Cells["KhiVaoKhoaDieuTri"].Value.ToString();
                    tb_ba_kq.Text = table.Cells["KetQuaDieuTri"].Value.ToString();
                    tb_ba_giaiPhau.Text = table.Cells["GiaiPhauBenh"].Value.ToString();
                    tb_ba_benhLy.Text = table.Cells["QuaTrinhBenhLy"].Value.ToString();
                    tb_ba_tienSu.Text = table.Cells["TienSuBenh"].Value.ToString();
                    tb_ba_toanThan.Text = table.Cells["ToaThan"].Value.ToString();
                    tb_ba_coNang.Text = table.Cells["TrieuChungCoNang"].Value.ToString();
                    tb_ba_thuongTonCB.Text = table.Cells["ThuongTonCanBan"].Value.ToString();
                    tb_ba_coQuan.Text = table.Cells["CacCoQuan"].Value.ToString();
                    tb_ba_tongKet.Text = table.Cells["TKetQuaTrinhBenhLy"].Value.ToString();
                    tb_ba_tomTat.Text = table.Cells["TomTatKQXN"].Value.ToString();
                    tb_ba_ppDieuTri.Text = table.Cells["PhuongPhapDieuTri"].Value.ToString();
                    tb_ba_hoSoPA.Text = table.Cells["HoSoPhimAnh"].Value.ToString();
                    pn_suaBA.Show();
                    break;
            }
        }

        private void bt_suaSKB_Click(object sender, EventArgs e)
        {
            funcCall.UpdateSoKhamBenh(tb_skb_maHSBN.Text, tb_skb_maLK.Text, tb_skb_hoVaTen.Text, tb_skb_tuoi.Text, tb_skb_soBHYT.Text, tb_skb_diaChi.Text, tb_skb_nghe.Text, tb_skb_danToc.Text, tb_skb_trieuChung.Text, tb_skb_chanDoan.Text, tb_skb_ppDieuTri.Text, tb_skb_bs.Text, tb_skb_ghiChu.Text);
            MessageBox.Show("Sửa sổ khám bệnh thành công");
            this.Close();
        }

        private void bt_suaBA_Click(object sender, EventArgs e)
        {
            funcCall.UpdateBenhAn(tb_ba_maBA.Text, tb_ba_maHSBN.Text, tb_ba_doiTuong.Text, dt_ba_giaTriBHYT.Value, tb_ba_hoTenThanNhan.Text, tb_ba_tgVaoVien.Text, tb_ba_ttVao.Text, tb_ba_noiGT.Text, tb_ba_khoa.Text, tb_ba_chuyenKhoa.Text, tb_ba_tongSoNgay.Text, tb_ba_noiChuyen.Text, tb_ba_KKBhoacCC.Text, tb_ba_dieuTri.Text, tb_ba_kq.Text, tb_ba_giaiPhau.Text, tb_ba_benhLy.Text, tb_ba_tienSu.Text, tb_ba_toanThan.Text, tb_ba_coNang.Text, tb_ba_thuongTonCB.Text, tb_ba_coQuan.Text, tb_ba_tongKet.Text, tb_ba_tomTat.Text, tb_ba_ppDieuTri.Text, tb_ba_hoSoPA.Text);
            MessageBox.Show("Sửa bệnh án thành công");
            this.Close();
        }
    }
}
