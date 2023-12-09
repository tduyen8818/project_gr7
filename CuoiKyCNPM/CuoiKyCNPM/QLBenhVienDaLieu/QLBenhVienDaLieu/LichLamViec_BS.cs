using QLBenhVienDaLieu.Database.Function;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QLBenhVienDaLieu
{
    public partial class LichLamViec_BS : Form
    {
        private SqlFunctionCaller functionCaller;
        private string sDT;
        public LichLamViec_BS(string sDT)
        {
            InitializeComponent();
            this.Size = new Size(1350, 800);
            this.sDT = sDT; // Gán số điện thoại
            functionCaller = new SqlFunctionCaller();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LichLamViec_BS_Load(object sender, EventArgs e)
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

        private void btn_TaiKhoan_Click(object sender, EventArgs e)
        {
            TaiKhoan_BS TaiKhoan = new TaiKhoan_BS(sDT);
            this.Hide();
            TaiKhoan.ShowDialog();
            this.Close();

        }

        private void btn_LichLamViec_Click(object sender, EventArgs e)
        {
            LichLamViec_BS LichLamViec = new LichLamViec_BS(sDT);
            this.Hide();
            LichLamViec.ShowDialog();
            this.Close();
        }

        private void btn_TrangChu_Click(object sender, EventArgs e)
        {

        }

        private void btn_DichVu_Click(object sender, EventArgs e)
        {
            BS_Kham_Benh bskb = new BS_Kham_Benh();
            bskb.FormClosed += (s, args) => this.Close();
            this.Hide();
            bskb.Show();
        }
    }
}
