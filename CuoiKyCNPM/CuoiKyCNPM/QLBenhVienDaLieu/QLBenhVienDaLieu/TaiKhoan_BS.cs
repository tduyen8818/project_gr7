﻿using QLBenhVienDaLieu.Database.Function;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QLBenhVienDaLieu
{
    public partial class TaiKhoan_BS : Form
    {
        private SqlFunctionCaller functionCaller;
        private string SDT;
        public TaiKhoan_BS(string sDT)
        {
            InitializeComponent();
            this.Size = new Size(1350, 800);
            functionCaller = new SqlFunctionCaller();
            this.SDT = sDT;
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap TaiKhoan = new DangNhap();
            TaiKhoan.ShowDialog();
            this.Close();
        }

        private void TaiKhoan_Form_Load(object sender, EventArgs e)
        {
            string sDT = SDT;

            if (!string.IsNullOrWhiteSpace(sDT))
            {
                DataTable memberData = functionCaller.RetrieveMemberData(sDT);

                if (memberData.Rows.Count > 0)
                {
                    txtHoVaTen.Text = memberData.Rows[0]["HoVaTen"].ToString();
                    txtMatKhau.Text = memberData.Rows[0]["MatKhau"].ToString();
                    txtCCCD.Text = memberData.Rows[0]["CCCD"].ToString();
                    txtSDT.Text = memberData.Rows[0]["SoDienThoai"].ToString();
                    txtNgaySinh.Text = memberData.Rows[0]["NgaySinh"].ToString();
                    txtViTri.Text = memberData.Rows[0]["ViTri"].ToString();
                    txtMaThanhVien.Text = memberData.Rows[0]["MaThanhVien"].ToString();
                    txtLoaiTaiKhoan.Text = memberData.Rows[0]["LoaiTaiKhoan"].ToString();
                    txtGioiTinh.Text = memberData.Rows[0]["GioiTinh"].ToString();
                    txtEmail.Text = memberData.Rows[0]["Email"].ToString();
                    txtDiaChi.Text = memberData.Rows[0]["DiaChi"].ToString();
                    txtChuyenKhoa.Text = memberData.Rows[0]["ChuyenKhoa"].ToString();

                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin cho số điện thoại này.");
                }
            }
        }

        LichLamViec_BS LichLamViec;

        private void btn_LichLamViec_Click(object sender, EventArgs e)
        {
            if (LichLamViec == null || LichLamViec.IsDisposed)
            {
                LichLamViec = new LichLamViec_BS(SDT);
                LichLamViec.FormClosed += (s, args) => this.Close();
                this.Hide();
                LichLamViec.Show();
            }
            if (IsFormHidden(LichLamViec))
            {
                this.Hide();
                LichLamViec.Show();
            }
        }

        private bool IsFormHidden(Form form)
        {
            return form != null && form.Visible && !form.Focused;
        }

        BS_Kham_Benh bskb;

        private void btn_DichVu_Click(object sender, EventArgs e)
        {
            if (bskb == null || bskb.IsDisposed)
            {
                bskb = new BS_Kham_Benh(SDT);
                bskb.FormClosed += (s, args) => this.Close();
                this.Hide();
                bskb.Show();
            }
            if (IsFormHidden(bskb))
            {
                this.Hide();
                bskb.Show();
            }
        }
    }
}
