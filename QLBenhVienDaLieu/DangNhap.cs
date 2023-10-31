//using QLBenhVienDaLieu.Database;
//using System;
//using System.Drawing;
//using System.Windows.Forms;

//namespace QLBenhVienDaLieu
//{
//    public partial class DangNhap : Form
//    {
//        private SqlFunctionCaller functionCaller;
//        public DangNhap()
//        {
//            InitializeComponent();
//            this.Size = new Size(1350, 800);         
//            functionCaller = new SqlFunctionCaller();

//        }

//        private void button1_Click_1(object sender, EventArgs e)
//        {
//            string sDT = textBox_SDT.Text;
//            string matKhau = textBox_MatKhau.Text;

//            if (string.IsNullOrWhiteSpace(sDT))
//            {
//                MessageBox.Show("Vui lòng nhập số điện thoại!");
//            }
//            else if (string.IsNullOrWhiteSpace(matKhau))
//            {
//                MessageBox.Show("Vui lòng nhập mật khẩu!");
//            }
//            else
//            {
//                if (functionCaller.CheckUser(sDT, matKhau)) // Kiểm tra đăng nhập thành công
//                {
//                    // Nếu đăng nhập thành công, chuyển sang Form 1
//                    BenhNhan_Trang form1 = new BenhNhan_Trang();
//                    this.Hide(); // Ẩn form hiện tại
//                    form1.ShowDialog(); // Hiển thị Form 1
//                    this.Close(); // Đóng form hiện tại
//                }
//                else
//                {
//                    MessageBox.Show("Tài khoản không hợp lệ.");
//                }
//            }
//        }

//        private void checkBox_HienMatKhau_CheckedChanged(object sender, EventArgs e)
//        {
//            if (checkBox_HienMatKhau.Checked)
//            {
//                textBox_MatKhau.PasswordChar = '\0';
//            }
//            else
//            {
//                textBox_MatKhau.PasswordChar = '*';
//            }
//        }


//        private void linkLabel_DangKy_Click(object sender, EventArgs e)
//        {
//            // Tạo một instance của Form mới
//            DangKy1 dangKy = new DangKy1();
//            this.Hide();
//            dangKy.ShowDialog();
//            this.Close();
//        }

//        private void linkLabel_QMK_Click(object sender, EventArgs e)
//        {
//            // Tạo một instance của Form mới
//            QuenMatKhau quenMatKhau = new QuenMatKhau();
//            this.Hide();
//            quenMatKhau.ShowDialog();
//            this.Close();
//        }
//    }
//}
