using QLBenhVienDaLieu.Database.Function;
using QLBenhVienDaLieu.GiaoDien.LeTanTrangUI.HoSoBenhNhanUI;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QLBenhVienDaLieu
{
    public partial class LichLamViec_LT : Form
    {
        private SqlFunctionCaller functionCaller;
        private string sDT;
        public LichLamViec_LT(string sDT)
        {
            InitializeComponent();
            this.Size = new Size(1350, 800);
            this.sDT = sDT; // Gán số điện thoại
            functionCaller = new SqlFunctionCaller();
            functionCaller.Connect();
        }

        private void LichLamViec_LT_Load(object sender, EventArgs e)
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
            LichLamViec_LT LichLamViec = new LichLamViec_LT(sDT);
            this.Hide();
            LichLamViec.ShowDialog();
            this.Close();
        }

        private void btn_TrangChu_Click(object sender, EventArgs e)
        {

        }

        private void btn_TaiKhoan_Click(object sender, EventArgs e)
        {
            TaiKhoan_LT TaiKhoan = new TaiKhoan_LT(sDT);
            this.Hide();
            TaiKhoan.ShowDialog();
            this.Close();
        }

        private void btn_HoSoBenhNhan_Click(object sender, EventArgs e)
        {
            HoSoBenhNhanForm hoSoBenhNhanForm = new HoSoBenhNhanForm(guna2CustomGradientPanel2, functionCaller);

            hoSoBenhNhanForm.TopLevel = false;
            hoSoBenhNhanForm.Dock = DockStyle.Fill;

            guna2CustomGradientPanel2.Controls.Clear();
            guna2CustomGradientPanel2.Controls.Add( hoSoBenhNhanForm );
            guna2CustomGradientPanel2.Tag = hoSoBenhNhanForm;

            hoSoBenhNhanForm.Show();
        }
    }
}
