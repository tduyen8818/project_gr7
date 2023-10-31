//using System;
//using System.Drawing;
//using System.Windows.Forms;

//namespace QLBenhVienDaLieu
//{
//    public partial class DangKy2 : Form
//    {
//        private string recipientPhoneNumber;
//        private Timer countdownTimer;
//        private int minutes = 3; // 3 phút
//        private int seconds = 0;
//        private int otp;
//        public DangKy2(string recipientPhoneNumber, int otp)
//        {
//            InitializeComponent();
//            this.Size = new Size(1350, 800);
//            label2.Left = 950;
//            label2.Top = 346;

//            this.recipientPhoneNumber = recipientPhoneNumber;
//            this.otp = otp; // Lưu OTP được truyền từ DangKy1
//            // Khởi tạo Timer
//            countdownTimer = new Timer();
//            countdownTimer.Interval = 1000; // 1 giây
//            countdownTimer.Tick += new EventHandler(CountdownTimer_Tick);

//            // Bắt đầu đếm ngược khi form được hiển thị
//            countdownTimer.Start();
//        }

//        private void CountdownTimer_Tick(object sender, EventArgs e)
//        {
//            // Giảm thời gian đi 1 giây
//            seconds--;

//            // Kiểm tra nếu phút và giây đều bằng 0
//            if (minutes == 0 && seconds == 0)
//            {
//                // Dừng Timer khi đếm về 0
//                countdownTimer.Stop();
//            }

//            // Cập nhật phút và giây nếu cần thiết
//            if (seconds < 0)
//            {
//                minutes--;
//                seconds = 59;
//            }

//            // Cập nhật giao diện người dùng
//            UpdateLabel2();
//        }
//        // Phương thức để cập nhật label2
//        private void UpdateLabel2()
//        {
//            if (label2.InvokeRequired)
//            {
//                label2.Invoke(new Action(() => label2.Text = $"{minutes:D2}:{seconds:D2}"));
//            }
//            else
//            {
//                label2.Text = $"{minutes:D2}:{seconds:D2}";
//            }
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            string enteredOTP = textBox_MaXacNhan.Text;

//            if (string.IsNullOrWhiteSpace(enteredOTP))
//            {
//                MessageBox.Show("Vui lòng nhập mã OTP.");
//                return;
//            }

//            if (enteredOTP == otp.ToString())
//            {
//                MessageBox.Show("OTP hợp lệ.");
//                this.Hide();
//                DangKy3 dangKy3 = new DangKy3(recipientPhoneNumber);
//                dangKy3.ShowDialog();
//                this.Close();

//            }
//            else
//            {
//                MessageBox.Show("OTP không hợp lệ. Vui lòng thử lại.");
//            }
//        }
//    }
//}
