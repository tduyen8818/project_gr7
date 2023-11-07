using System;
using System.Drawing;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using QLBenhVienDaLieu.Database.Function;

namespace QLBenhVienDaLieu
{
    public partial class DangKy3 : Form
    {
        private string recipientPhoneNumber;
        public DangKy3(string recipientPhoneNumber)
        {
            InitializeComponent();
            this.Size = new Size(1350, 800);

            this.recipientPhoneNumber = recipientPhoneNumber;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private bool IsValidPassword(string password)
        {
            // Điều kiện kiểm tra: mật khẩu phải có ít nhất 8 ký tự.
            return password.Length >= 8;
        }
        private bool IsValidPassword1(string password)
        {
            // Điều kiện kiểm tra:
            // - Ít nhất 8 ký tự.
            // - Ít nhất một chữ hoa.
            // - Ít nhất một chữ thường.
            // - Ít nhất một số.
            // - Ít nhất một kí hiệu đặc biệt (ký tự không phải chữ hoa, chữ thường hoặc số).

            return Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string password = textBox_XacNhanMatKhau.Text;
            string confirmPassword = textBox_XacNhanMatKhau.Text;
            // Kiểm tra xem các trường nhập liệu có trống không hoặc null
            if (string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return; // Dừng kiểm tra nếu có trường nhập liệu bị thiếu
            }

            // Kiểm tra mật khẩu
            if (!IsValidPassword(password))
            {
                MessageBox.Show("Mật khẩu không hợp lệ!");
                return; // Dừng việc kiểm tra nếu mật khẩu không hợp lệ
            }
            if (!IsValidPassword1(password))
            {
                MessageBox.Show("Mật khẩu không đủ mạnh! " +
                    "Nhập lại mật khẩu phải bao gồm 1 chữ cái viết hoa, 1 chữ cái viết thường, 1 con số, 1 ký tự đặc biệt(!@#$...)");

                return; // Dừng việc kiểm tra nếu mật khẩu không đủ mạnh
            }

            // Kiểm tra xác nhận lại mật khẩu
            if (password != confirmPassword)
            {
                MessageBox.Show("Xác nhận lại mật khẩu không khớp!");
                return; // Dừng việc kiểm tra nếu xác nhận lại mật khẩu không khớp
            }
            // Làm cho số điện thoại phù hợp với định dạng trong cơ sở dữ liệu
            string phoneNumberWithoutPlus84 = this.recipientPhoneNumber.TrimStart('+').Substring(2); // Bỏ tiền tố "+84" và lấy phần còn lại
            // Cập nhật dữ liệu vào cơ sở dữ liệu
            SqlFunctionCaller functionCaller = new SqlFunctionCaller();
            try
            {
                // Thực hiện truy vấn chèn dữ liệu vào cơ sở dữ liệu với số điện thoại đã được điều chỉnh
                functionCaller.CallInsertUser(phoneNumberWithoutPlus84, password);
                MessageBox.Show("Đăng ký thành công.");
                this.Hide();
                DangNhap dangNhap = new DangNhap();
                dangNhap.ShowDialog();
                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khác: " + ex.Message);
            }
        }
    }
}
