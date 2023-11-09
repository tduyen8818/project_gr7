using QLBenhVienDaLieu.Database.Function;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QLBenhVienDaLieu
{
    public partial class Admin_Trang : Form
    {
        private SqlFunctionCaller functioner;
        private DataGridViewRow selectedRow;
        public Admin_Trang()
        {
            InitializeComponent();
            this.Size = new Size(1350, 800);
            functioner = new SqlFunctionCaller();
            PopulateGenderComboBox();
            PopulateAccountTypeComboBox();
        }
        private void PopulateGenderComboBox()
        {
            comboBox_GioiTinh.Items.Add("Nam");
            comboBox_GioiTinh.Items.Add("Nữ");
            comboBox_GioiTinh.SelectedIndex = 0;
        }
        private void PopulateAccountTypeComboBox()
        {
            comboBox_LoaiTaiKhoan.Items.Add("BS");
            comboBox_LoaiTaiKhoan.Items.Add("KT");
            comboBox_LoaiTaiKhoan.Items.Add("TV");
            comboBox_LoaiTaiKhoan.SelectedIndex = 0;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string hoVaTen = txt_HoVaTen.Text;
            string matKhau = txt_MatKhau.Text;
            DateTime ngaySinh = dateTimePicker_NgaySinh.Value;
            string gioiTinh = comboBox_GioiTinh.SelectedItem.ToString();
            string cccd = txt_CCCD.Text;
            string soDienThoai = txt_SoDienThoai.Text;
            string email = txt_Email.Text;
            string diaChi = txt_DiaChi.Text;
            string chuyenKhoa = txt_ChuyenKhoa.Text;
            string viTri = txt_ViTri.Text;
            string loaiTaiKhoan = comboBox_LoaiTaiKhoan.SelectedItem.ToString();

            // Gọi hàm để chèn dữ liệu
            functioner.InsertTaiKhoanThanhVien(hoVaTen, matKhau, ngaySinh, gioiTinh, cccd, soDienThoai, email, diaChi, chuyenKhoa, viTri, loaiTaiKhoan);

            functioner.LoadDataFromDatabase(guna2DataGridView1);

            // Xóa các trường nhập liệu sau khi chèn dữ liệu
            txt_HoVaTen.Text = "";
            txt_MatKhau.Text = "";
            txt_CCCD.Text = "";
            txt_Email.Text = "";
            txt_SoDienThoai.Text = "";
            txt_DiaChi.Text = "";
            txt_ChuyenKhoa.Text = "";
            txt_ViTri.Text = "";

            // You can also provide user feedback to indicate a successful insertion
            MessageBox.Show("Thêm thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private string selectedMaThanhVien;
        private void btn_Sua_Click(object sender, EventArgs e)
        {

            if (selectedRow != null)
            {
                // Sử dụng dữ liệu từ hàng đã chọn
                selectedMaThanhVien = selectedRow.Cells["MaThanhVien"].Value.ToString();


                // Định nghĩa biến để lưu trữ giá trị cập nhật
                string hoVaTenMoi, matKhauMoi, gioiTinhMoi, cccdMoi, soDienThoaiMoi, emailMoi, diaChiMoi, chuyenKhoaMoi, viTriMoi, loaiTaiKhoanMoi;
                DateTime ngaySinhMoi;


                // Kiểm tra nếu bất kỳ trường nhập liệu nào không trống
                if (!string.IsNullOrEmpty(txt_HoVaTen.Text) || !string.IsNullOrEmpty(txt_MatKhau.Text) ||
                    !string.IsNullOrEmpty(txt_CCCD.Text) || !string.IsNullOrEmpty(txt_SoDienThoai.Text) ||
                    !string.IsNullOrEmpty(txt_Email.Text) || !string.IsNullOrEmpty(txt_DiaChi.Text) ||
                    !string.IsNullOrEmpty(txt_ChuyenKhoa.Text) || !string.IsNullOrEmpty(txt_ViTri.Text) ||
                    comboBox_GioiTinh.SelectedItem != null || comboBox_LoaiTaiKhoan.SelectedItem != null)
                {
                    hoVaTenMoi = txt_HoVaTen.Text;
                    matKhauMoi = txt_MatKhau.Text;
                    ngaySinhMoi = dateTimePicker_NgaySinh.Value;
                    gioiTinhMoi = comboBox_GioiTinh.SelectedItem?.ToString();
                    cccdMoi = txt_CCCD.Text;
                    soDienThoaiMoi = txt_SoDienThoai.Text;
                    emailMoi = txt_Email.Text;
                    diaChiMoi = txt_DiaChi.Text;
                    chuyenKhoaMoi = txt_ChuyenKhoa.Text;
                    viTriMoi = txt_ViTri.Text;
                    loaiTaiKhoanMoi = comboBox_LoaiTaiKhoan.SelectedItem?.ToString();
                }
                else
                {
                    // Sử dụng dữ liệu từ hàng đã chọn
                    hoVaTenMoi = selectedRow.Cells["HoVaTen"].Value.ToString();
                    matKhauMoi = selectedRow.Cells["MatKhau"].Value.ToString();
                    ngaySinhMoi = Convert.ToDateTime(selectedRow.Cells["NgaySinh"].Value.ToString());
                    gioiTinhMoi = selectedRow.Cells["GioiTinh"].Value.ToString();
                    cccdMoi = selectedRow.Cells["CCCD"].Value.ToString();
                    soDienThoaiMoi = selectedRow.Cells["SoDienThoai"].Value.ToString();
                    emailMoi = selectedRow.Cells["DiaChi"].Value.ToString();
                    diaChiMoi = selectedRow.Cells["Email"].Value.ToString();
                    chuyenKhoaMoi = selectedRow.Cells["ChuyenKhoa"].Value.ToString();
                    viTriMoi = selectedRow.Cells["ViTri"].Value.ToString();
                    loaiTaiKhoanMoi = selectedRow.Cells["LoaiTaiKhoan"].Value.ToString();
                }

                // Cập nhật dữ liệu
                functioner.SuaTaiKhoanThanhVien(selectedMaThanhVien, hoVaTenMoi, matKhauMoi, ngaySinhMoi, gioiTinhMoi, cccdMoi, soDienThoaiMoi, emailMoi, diaChiMoi, chuyenKhoaMoi, viTriMoi, loaiTaiKhoanMoi);

                // Tải lại dữ liệu từ cơ sở dữ liệu và hiển thị nó trong DataGridView
                functioner.LoadDataFromDatabase(guna2DataGridView1);

                // Hiển thị thông báo thành công
                MessageBox.Show("Sửa dữ liệu thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng cần sửa trước.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_HoVaTen.ResetText();
            txt_MatKhau.ResetText();
            txt_CCCD.ResetText();
            txt_Email.ResetText();
            txt_DiaChi.ResetText();
            txt_ChuyenKhoa.ResetText();
            txt_ViTri.ResetText();
            txt_SoDienThoai.ResetText();

            functioner.LoadDataFromDatabase(guna2DataGridView1);
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRow = guna2DataGridView1.Rows[e.RowIndex];

                // Lấy dữ liệu từ hàng đã chọn và hiển thị nó trên các trường nhập liệu
                txt_HoVaTen.Text = selectedRow.Cells["HoVaTen"].Value.ToString();
                txt_MatKhau.Text = selectedRow.Cells["MatKhau"].Value.ToString();
                dateTimePicker_NgaySinh.Value = Convert.ToDateTime(selectedRow.Cells["NgaySinh"].Value);
                comboBox_GioiTinh.SelectedItem = selectedRow.Cells["GioiTinh"].Value.ToString();
                txt_CCCD.Text = selectedRow.Cells["CCCD"].Value.ToString();
                txt_SoDienThoai.Text = selectedRow.Cells["SoDienThoai"].Value.ToString();
                txt_Email.Text = selectedRow.Cells["DiaChi"].Value.ToString();
                txt_DiaChi.Text = selectedRow.Cells["Email"].Value.ToString();
                txt_ChuyenKhoa.Text = selectedRow.Cells["ChuyenKhoa"].Value.ToString();
                txt_ViTri.Text = selectedRow.Cells["ViTri"].Value.ToString();
                comboBox_LoaiTaiKhoan.SelectedItem = selectedRow.Cells["LoaiTaiKhoan"].Value.ToString();
            }
        }

        private void Admin_Trang_Load(object sender, EventArgs e)
        {

            functioner.LoadDataFromDatabase(guna2DataGridView1);

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (selectedRow != null)
            {
                // Lấy MaThanhVien đã chọn (giả sử "MaThanhVien" là cột khóa chính)
                string selectedMaThanhVien = selectedRow.Cells["MaThanhVien"].Value.ToString();

                // Gọi phương thức để xóa bản ghi đã chọn
                functioner.DeleteTaiKhoanThanhVien(selectedMaThanhVien);

                // Tải dữ liệu cập nhật từ cơ sở dữ liệu và làm mới DataGridView
                functioner.LoadDataFromDatabase(guna2DataGridView1);

                // Xóa các trường nhập liệu và cung cấp thông báo cho người dùng
                XoaTruongNhapLieu();
                MessageBox.Show("Xóa thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng cần xóa trước.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void XoaTruongNhapLieu()
        {
            txt_HoVaTen.Text = "";
            txt_MatKhau.Text = "";
            txt_CCCD.Text = "";
            txt_Email.Text = "";
            txt_DiaChi.Text = "";
            txt_ChuyenKhoa.Text = "";
            txt_ViTri.Text = "";
            txt_SoDienThoai.Text = "";
            comboBox_GioiTinh.SelectedIndex = 0;
            comboBox_LoaiTaiKhoan.SelectedIndex = 0;
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            // Lấy từ khóa tìm kiếm từ trường tìm kiếm
            string searchKeyword = txt_TimKiem.Text;

            // Gọi phương thức để thực hiện tìm kiếm
            DataTable searchResult = functioner.CallSearchTaiKhoanThanhVien(searchKeyword);

            // Hiển thị kết quả tìm kiếm trong DataGridView
            guna2DataGridView1.DataSource = searchResult;
        }
        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            // Tự động thực hiện tìm kiếm khi người dùng thay đổi nội dung trường tìm kiếm
            btn_TimKiem_Click(sender, e);
        }
    }
}
