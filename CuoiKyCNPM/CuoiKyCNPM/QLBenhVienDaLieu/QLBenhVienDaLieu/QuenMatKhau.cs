﻿using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;


namespace QLBenhVienDaLieu
{
    public partial class QuenMatKhau : Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
            this.Size = new Size(1350, 800);
        }
        Random random = new Random();
        int otp;

        private void button1_Click(object sender, EventArgs e)
        {
            // Số điện thoại nhập từ TextBox
            string inputPhoneNumber = textBox_SoDienThoai.Text;

            const string serverName = "LAPTOP-C2CHSH4F";
            const string databaseName = "PHONGKHAMDALIEU";
            const string userName = "quang";
            const string password = "123";

            // Kết nối đến cơ sở dữ liệu SQL Server
            string connectionString = $"Data Source={serverName};" +
            $"Initial Catalog={databaseName};" +
            $"User id={userName};" +
            $"Password={password};"; // Thay thế bằng chuỗi kết nối cơ sở dữ liệu thực tế
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Kiểm tra xem số điện thoại có tồn tại trong cơ sở dữ liệu hay không
                string query = "SELECT COUNT(*) FROM DangKyUser WHERE SoDienThoai = @SoDienThoai";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SoDienThoai", inputPhoneNumber);
                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        // Số điện thoại đã tồn tại trong cơ sở dữ liệu, gửi OTP ở đây
                        MessageBox.Show("Gửi OTP.");
                        // Gọi hàm gửi OTP ở đây
                        try
                        {
                            // Thay đổi thông tin tài khoản Twilio của bạn
                            string accountSid = "AC8c409975f31b38baad27e6b1c480b32b";
                            string authToken = "4af34b894d9d4073648c4cb4f4669530";
                            string twilioPhoneNumber = "+16062632008"; // Số điện thoại Twilio đã cung cấp

                            TwilioClient.Init(accountSid, authToken);

                            otp = random.Next(100000, 1000000);
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
                            QuenMatKhau1 quenMatKhau = new QuenMatKhau1(inputPhoneNumber, otp);
                            quenMatKhau.ShowDialog();
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi gửi OTP: {ex.Message}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Số điện thoại không tồn tại.");
                    }
                }
            }
        }
    }
}
