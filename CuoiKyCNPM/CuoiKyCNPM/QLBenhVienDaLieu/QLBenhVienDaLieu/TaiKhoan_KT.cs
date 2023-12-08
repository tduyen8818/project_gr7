using QLBenhVienDaLieu.Database.Function;
using QLBenhVienDaLieu.GiaoDien.KeToanTrangUI.HoaDonUI;
using QLBenhVienDaLieu.GiaoDien.KeToanTrangUI.ThongKeUI;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QLBenhVienDaLieu
{
    public partial class TaiKhoan_KT : Form
    {
        private SqlFunctionCaller functionCaller;
        private SqlFunctionCaller sqlFunctionCaller;
        private string SDT;
        public TaiKhoan_KT(string sDT)
        {
            InitializeComponent();
            this.Size = new Size(1350, 800);
            functionCaller = new SqlFunctionCaller();
            this.SDT = sDT;
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap TaiKhoan = new DangNhap();
            TaiKhoan.ShowDialog();
            this.Close();
        }

        private void TaiKhoan_KT_Load(object sender, EventArgs e)
        {
            string sDT = SDT;

            if (!string.IsNullOrWhiteSpace(sDT))
            {
                DataTable memberData = functionCaller.RetrieveMemberData(sDT);

                if (memberData.Rows.Count > 0)
                {
                    txtHoVaTen.Text = memberData.Rows[0]["HoVaTen"].ToString();
                    txtMatKhau.Text = memberData.Rows[0]["MatKhau"].ToString();
                    txtCCCD.Text = memberData.Rows[0]["CCCD"].ToString();
                    txtSDT.Text = memberData.Rows[0]["SoDienThoai"].ToString();
                    txtNgaySinh.Text = memberData.Rows[0]["NgaySinh"].ToString();
                    txtViTri.Text = memberData.Rows[0]["ViTri"].ToString();
                    txtMaThanhVien.Text = memberData.Rows[0]["MaThanhVien"].ToString();
                    txtLoaiTaiKhoan.Text = memberData.Rows[0]["LoaiTaiKhoan"].ToString();
                    txtGioiTinh.Text = memberData.Rows[0]["GioiTinh"].ToString();
                    txtEmail.Text = memberData.Rows[0]["Email"].ToString();
                    txtDiaChi.Text = memberData.Rows[0]["DiaChi"].ToString();
                    txtChuyenKhoa.Text = memberData.Rows[0]["ChuyenKhoa"].ToString();

                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin cho số điện thoại này.");
                }
            }
        }

        private void btn_LichLamViec_Click(object sender, EventArgs e)
        {
            LichLamViec_KT LichLamViec = new LichLamViec_KT(SDT);
            this.Hide();
            LichLamViec.ShowDialog();
            this.Close();
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            guna2CustomGradientPanel2.Controls.Clear();

            DanhSachHoaDon danhSachHoaDon = new DanhSachHoaDon(sqlFunctionCaller);

            danhSachHoaDon.TopLevel = false;
            danhSachHoaDon.Dock = DockStyle.Fill;

            guna2CustomGradientPanel2.Controls.Add(danhSachHoaDon);
            guna2CustomGradientPanel2.Tag = danhSachHoaDon;

            danhSachHoaDon.Show();
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            guna2CustomGradientPanel2.Controls.Clear();

            ThongKeDoanhThu thongKeDoanhThu = new ThongKeDoanhThu(sqlFunctionCaller);

            thongKeDoanhThu.TopLevel = false;
            thongKeDoanhThu.Dock = DockStyle.Fill;

            guna2CustomGradientPanel2.Controls.Add(thongKeDoanhThu);
            guna2CustomGradientPanel2.Tag = thongKeDoanhThu;

            thongKeDoanhThu.Show();
        }
    }
}
