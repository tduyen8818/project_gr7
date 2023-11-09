using QLBenhVienDaLieu.Database.Function;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QLBenhVienDaLieu
{
    public partial class LichLamViec_Trang : Form
    {
        private SqlFunctionCaller functionCaller;
        private DataGridViewRow selectedRow;
        public LichLamViec_Trang()
        {
            InitializeComponent();
            this.Size = new Size(1350, 800);
            functionCaller = new SqlFunctionCaller();
            PopulateCaComboBox();
        }
        private void PopulateCaComboBox()
        {
            comboBox_Ca.Items.Add("Sáng");
            comboBox_Ca.Items.Add("Chiều");
            comboBox_Ca.SelectedIndex = 0;
        }
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRow = guna2DataGridView1.Rows[e.RowIndex];

                // Lấy dữ liệu từ hàng đã chọn và hiển thị nó trên các trường nhập liệu
                txt_HoVaTen.Text = selectedRow.Cells["HoVaTen"].Value.ToString();
                txt_MaThanhVien.Text = selectedRow.Cells["MaThanhVien"].Value.ToString();
                dateTimePicker_Ngay.Value = Convert.ToDateTime(selectedRow.Cells["Ngay"].Value);
                comboBox_Ca.SelectedItem = selectedRow.Cells["Ca"].Value.ToString();
            }
        }

        private void LichLamViec_Trang_Load(object sender, EventArgs e)
        {
            functionCaller.LoadDataFromDatabaseLichLamViec(guna2DataGridView1);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string hoVaTen = txt_HoVaTen.Text;
            DateTime ngayLamViec = dateTimePicker_Ngay.Value;
            string Ca = comboBox_Ca.SelectedItem.ToString();
            String maThanhVienNhap = txt_MaThanhVien.Text;

            string maThanhVien = functionCaller.GetMaThanhVien(hoVaTen);

            if (!string.IsNullOrEmpty(maThanhVien))
            {
                if (maThanhVien == maThanhVienNhap)
                {
                    // Kiểm tra nếu đã tồn tại bản ghi có cùng Mã thành viên, Ngày và Ca
                    if (functionCaller.IsDuplicateLichLamViec(maThanhVien, ngayLamViec, Ca))
                    {
                        MessageBox.Show("Mã thành viên, Ngày và Ca đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        functionCaller.InsertLichLamViec(hoVaTen, maThanhVien, ngayLamViec, Ca);
                        functionCaller.LoadDataFromDatabaseLichLamViec(guna2DataGridView1);

                        txt_HoVaTen.Text = "";
                        txt_MaThanhVien.Text = ""; // Xóa giá trị mã thành viên đã nhập
                        dateTimePicker_Ngay.Value = DateTime.Now;
                        comboBox_Ca.SelectedIndex = 0;

                        MessageBox.Show("Thêm thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Mã thành viên không khớp với mã đã tìm thấy.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy tên hoặc mã thành viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string selectedMaLichLamViec;
        private string selectedMaThanhVien;

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (selectedRow != null)
            {
                // Kiểm tra xem cột "MaLichLamViec" có tồn tại trong selectedRow
                if (selectedRow.Cells["MaLichLamViec"].Value != null)
                {
                    // Sử dụng dữ liệu từ hàng đã chọn
                    selectedMaLichLamViec = selectedRow.Cells["MaLichLamViec"].Value.ToString();
                    selectedMaThanhVien = selectedRow.Cells["MaThanhVien"].Value.ToString();

                    // Định nghĩa biến để lưu trữ giá trị cập nhật
                    string hoVaTenMoi, CaMoi;
                    DateTime ngayLamViecMoi;

                    // Kiểm tra nếu bất kỳ trường nhập liệu nào không trống
                    if (!string.IsNullOrEmpty(txt_HoVaTen.Text) || !string.IsNullOrEmpty(dateTimePicker_Ngay.Text) ||
                        comboBox_Ca.SelectedItem != null)
                    {
                        hoVaTenMoi = txt_HoVaTen.Text;
                        ngayLamViecMoi = dateTimePicker_Ngay.Value;
                        CaMoi = comboBox_Ca.SelectedItem?.ToString();
                    }
                    else
                    {
                        // Sử dụng dữ liệu từ hàng đã chọn
                        hoVaTenMoi = selectedRow.Cells["HoVaTen"].Value.ToString();
                        ngayLamViecMoi = (DateTime)selectedRow.Cells["Ngay"].Value;
                        CaMoi = selectedRow.Cells["Ca"].Value.ToString();
                    }

                    // Cập nhật dữ liệu
                    functionCaller.UpdateLichLamViec(selectedMaLichLamViec, hoVaTenMoi, selectedMaThanhVien, ngayLamViecMoi, CaMoi);

                    // Tải lại dữ liệu từ cơ sở dữ liệu và hiển thị nó trong DataGridView
                    functionCaller.LoadDataFromDatabaseLichLamViec(guna2DataGridView1);

                    // Hiển thị thông báo thành công
                    MessageBox.Show("Sửa dữ liệu thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy cột 'MaLichLamViec' trong hàng đã chọn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng cần sửa trước.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (selectedRow != null)
            {
                // Lấy MaThanhVien đã chọn (giả sử "MaThanhVien" là cột khóa chính)
                string selectedMaLichLamViec = selectedRow.Cells["MaLichLamViec"].Value.ToString();

                // Gọi phương thức để xóa bản ghi đã chọn
                functionCaller.DeleteLichLamViec(selectedMaLichLamViec);

                // Tải dữ liệu cập nhật từ cơ sở dữ liệu và làm mới DataGridView
                functionCaller.LoadDataFromDatabaseLichLamViec(guna2DataGridView1);

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
            txt_MaThanhVien.Text = "";
            comboBox_Ca.Text = "";
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_HoVaTen.ResetText();
            txt_MaThanhVien.ResetText();
            dateTimePicker_Ngay.ResetText();
            comboBox_Ca.ResetText();
            comboBox_Ca.ResetText();

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
        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            // Tự động thực hiện tìm kiếm khi người dùng thay đổi nội dung trường tìm kiếm
            btn_TimKiem_Click(sender, e);
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Trang QuanLyNhanVien = new Admin_Trang();
            QuanLyNhanVien.ShowDialog();
            this.Close();
        }

        private void btn_LichLamViec_Click(object sender, EventArgs e)
        {
            this.Hide();
            LichLamViec_Trang QuanLyNhanVien = new LichLamViec_Trang();
            QuanLyNhanVien.ShowDialog();
            this.Close();
        }

        private void btn_TaiKhoan_Click(object sender, EventArgs e)
        {

        }
    }

}
