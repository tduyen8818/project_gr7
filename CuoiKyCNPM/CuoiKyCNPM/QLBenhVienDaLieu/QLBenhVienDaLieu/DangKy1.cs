using System;
using System.Drawing;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace QLBenhVienDaLieu
{
    public partial class DangKy1 : Form
    {
        private string phoneNumber;

        public DangKy1()
        {
            InitializeComponent();
            this.Size = new Size(1350, 800);
        }
        Random random = new Random();
        int otp;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                // Thay đổi thông tin tài khoản Twilio của bạn
                string accountSid = "AC4d5fb5f8d08bf654fbfba35370ca5dba";
                string authToken = "fa058f7bb604fcdb8fb7e8be7f448901";
                string twilioPhoneNumber = "+12032759991"; // Số điện thoại Twilio đã cung cấp

                TwilioClient.Init(accountSid, authToken);

                otp = random.Next(100000, 1000000);

                // Số điện thoại nhận OTP
                string inputPhoneNumber = textBox_SoDienThoai.Text;

                // Kiểm tra xem ô văn bản có rỗng hay không
                if (string.IsNullOrWhiteSpace(inputPhoneNumber))
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại trước khi gửi OTP.");
                    return; // Không thực hiện gửi OTP nếu không có số điện thoại
                }

                // Kiểm tra xem số điện thoại đã nhập có tiền tố quốc tế "+84" chưa
                if (!inputPhoneNumber.StartsWith("+84"))
                {
                    // Nếu chưa có, thêm tiền tố "+84"
                    inputPhoneNumber = "+84" + inputPhoneNumber;
                }

                var message = MessageResource.Create(
                    to: new PhoneNumber(inputPhoneNumber),
                    from: new PhoneNumber(twilioPhoneNumber),
                    body: "Mã OTP của bạn là: " + otp.ToString());

                MessageBox.Show("OTP đã được gửi thành công.");
                this.Hide();
                DangKy2 dangKy = new DangKy2(inputPhoneNumber, otp);
                dangKy.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi gửi OTP: {ex.Message}");
            }
        }
    }
}
