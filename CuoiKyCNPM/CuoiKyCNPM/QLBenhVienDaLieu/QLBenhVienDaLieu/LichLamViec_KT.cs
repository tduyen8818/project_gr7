using QLBenhVienDaLieu.Database.Function;
using QLBenhVienDaLieu.GiaoDien.KeToanTrangUI.HoaDonUI;
using QLBenhVienDaLieu.GiaoDien.KeToanTrangUI.ThongKeUI;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QLBenhVienDaLieu
{
    public partial class LichLamViec_KT : Form
    {
        private SqlFunctionCaller functionCaller;
        private string sDT;
        public LichLamViec_KT(string sDT)
        {
            InitializeComponent();
            this.Size = new Size(1350, 800);
            this.sDT = sDT; // Gán số điện thoại
            functionCaller = new SqlFunctionCaller();
            functionCaller.Connect();
        }

        private void LichLamViec_KT_Load(object sender, EventArgs e)
        {
            functionCaller.LoadDataFromDatabaseLichLamViec(guna2DataGridView1);
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            // Lấy từ khóa tìm kiếm từ trường tìm kiếm
            string searchKeyword = txt_TimKiem.Text;

            // Gọi phương thức để thực hiện tìm kiếm
            DataTable searchResult = functionCaller.CallSearchLichLamViec(searchKeyword);

            // Hiển thị kết quả tìm kiếm trong DataGridView
            guna2DataGridView1.DataSource = searchResult;
        }

        private void btn_LichLamViec_Click(object sender, EventArgs e)
        {
            LichLamViec_KT LichLamViec = new LichLamViec_KT(sDT);
            this.Hide();
            LichLamViec.ShowDialog();
            this.Close();
        }

        private void btn_TaiKhoan_Click(object sender, EventArgs e)
        {
            TaiKhoan_KT TaiKhoan = new TaiKhoan_KT(sDT);
            this.Hide();
            TaiKhoan.ShowDialog();
            this.Close();
        }

        private void btn_TrangChu_Click(object sender, EventArgs e)
        {

        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            DanhSachHoaDon danhSachHoaDon = new DanhSachHoaDon(functionCaller);
            
            danhSachHoaDon.TopLevel = false;
            danhSachHoaDon.Dock = DockStyle.Fill;

            guna2CustomGradientPanel2.Controls.Clear();
            guna2CustomGradientPanel2.Controls.Add(danhSachHoaDon);
            guna2CustomGradientPanel2.Tag = danhSachHoaDon;

            danhSachHoaDon.Show();
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            ThongKeDoanhThu thongKeDoanhThu = new ThongKeDoanhThu(functionCaller);

            thongKeDoanhThu.TopLevel = false;
            thongKeDoanhThu.Dock = DockStyle.Fill;

            guna2CustomGradientPanel2.Controls.Clear();
            guna2CustomGradientPanel2.Controls.Add(thongKeDoanhThu);
            guna2CustomGradientPanel2.Tag = thongKeDoanhThu;

            thongKeDoanhThu.Show();

        }
    }
}
