using QLBenhVienDaLieu.Database.Function;
using QLBenhVienDaLieu.GiaoDien.BenhNhanTrangUI.LichKhamUI.DatLichKhamUI;
using QLBenhVienDaLieu.GiaoDien.BenhNhanTrangUI.LichKhamUI.XemLichKhamUI;
using QLBenhVienDaLieu.GiaoDien.BenhNhanTrangUI.TaiKhoanUI.HoSoBenhNhanUI;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QLBenhVienDaLieu
{
    public partial class BenhNhan_Trang : Form
    {
        private SqlFunctionCaller sqlFunctionCaller;

        private string soDienThoai;

        public Panel MainPanelRight { get { return mainPanelRight; } set { mainPanelRight = value; } }

        public string SoDienThoai
        {
            get { return soDienThoai; }
            set { soDienThoai = value; }
        }



        public BenhNhan_Trang(string soDienThoai, SqlFunctionCaller sqlFunctionCaller)
        {
            this.sqlFunctionCaller = sqlFunctionCaller;
            this.soDienThoai = soDienThoai;
            InitializeComponent();

            mainPanelRight.Region = Graphic.Draw.RoundedRectangle(0, 0, mainPanelRight.Width, mainPanelRight.Height, 20, 20);
            mainPanelLeft.Region = Graphic.Draw.RoundedRectangle(0, 0, mainPanelLeft.Width, mainPanelLeft.Height, 20, 20);

        }

        

        private void buttonTrangChu_Click(object sender, EventArgs e)
        {

        }

        private void buttonDichVu_Click(object sender, EventArgs e)
        {
            BS_Kham_Benh bskb = new BS_Kham_Benh();
            bskb.FormClosed += (s, args) => this.Show();
            bskb.Show();
            this.Hide();
        }

        private void buttonLichKham_Click(object sender, EventArgs e)
        {
           if (panelDropDown1.Height == buttonLichKham.Height)
           {
                panelDropDown1.Height = buttonLichKham.Height + buttonXemLich.Height + buttonDatLich.Height;
           } else
           {
                panelDropDown1.Height = buttonLichKham.Height;
           }
        }

        private void buttonXemLich_Click(object sender, EventArgs e)
        {
            mainPanelRight.Controls.Clear();
            XemLichKham xemLichKham = new XemLichKham(sqlFunctionCaller, this, soDienThoai);

            xemLichKham.TopLevel = false;
            xemLichKham.Dock = DockStyle.Fill;

            mainPanelRight.Controls.Add(xemLichKham);
            mainPanelRight.Tag = xemLichKham;

            xemLichKham.Show();
        }

        private void buttonDatLich_Click(object sender, EventArgs e)
        {
            if (!sqlFunctionCaller.GetHoSoBenhNhanByMaTaiKhoan(soDienThoai).Any())
            {
                mainPanelRight.Controls.Clear();
                DangKyHoSoBenhNhan dangKyHoSoBenhNhan = new DangKyHoSoBenhNhan(sqlFunctionCaller, soDienThoai);

                dangKyHoSoBenhNhan.TopLevel = false;
                dangKyHoSoBenhNhan.Dock = DockStyle.Fill;

                mainPanelRight.Controls.Add(dangKyHoSoBenhNhan);
                mainPanelRight.Tag = dangKyHoSoBenhNhan;

                dangKyHoSoBenhNhan.Show();

            }
            else
            {
                mainPanelRight.Controls.Clear();
                DatLichKham datLichKham = new DatLichKham(sqlFunctionCaller, this, soDienThoai);

                datLichKham.TopLevel = false;
                datLichKham.Dock = DockStyle.Fill;

                mainPanelRight.Controls.Add(datLichKham);
                mainPanelRight.Tag = datLichKham;

                datLichKham.Show();

            }
        }

        private void buttonThongBao_Click(object sender, EventArgs e)
        {

        }

        private void buttonHoTro_Click(object sender, EventArgs e)
        {

        }

        private void buttonTaiKhoan_Click(object sender, EventArgs e)
        {
            if (panelDropDown2.Height == buttonTaiKhoan.Height)
            {
                panelDropDown2.Height = buttonTaiKhoan.Height + buttonHoSoBenhNhan.Height + buttonTaiKhoanSub.Height;
            } else
            {
                panelDropDown2.Height = buttonTaiKhoan.Height;
            }
        }

        public void buttonHoSoBenhNhan_Click(object sender, EventArgs e)
        {
            if (!sqlFunctionCaller.GetHoSoBenhNhanByMaTaiKhoan(soDienThoai).Any())
            {
                mainPanelRight.Controls.Clear();
                DangKyHoSoBenhNhan dangKyHoSoBenhNhan = new DangKyHoSoBenhNhan(sqlFunctionCaller, soDienThoai);

                dangKyHoSoBenhNhan.TopLevel = false;
                dangKyHoSoBenhNhan.Dock = DockStyle.Fill;

                mainPanelRight.Controls.Add(dangKyHoSoBenhNhan);
                mainPanelRight.Tag = dangKyHoSoBenhNhan;

                dangKyHoSoBenhNhan.Show();
            }
            else
            {
                mainPanelRight.Controls.Clear();
                HoSoBenhNhanForm hoSoBenhNhan = new HoSoBenhNhanForm(sqlFunctionCaller, this);

                hoSoBenhNhan.TopLevel = false;
                hoSoBenhNhan.Dock = DockStyle.Fill;

                mainPanelRight.Controls.Add(hoSoBenhNhan);
                mainPanelRight.Tag = hoSoBenhNhan;

                hoSoBenhNhan.Show();
            }
        }

        private void buttonTaiKhoanSub_Click(object sender, EventArgs e)
        {

        }

        private void buttonGioiThieu_Click(object sender, EventArgs e)
        {

        }

        private void buttonDatLichKhamNgay_Click(object sender, EventArgs e)
        {

        }

        private void BenhNhan_Trang_Resize(object sender, EventArgs e)
        {
            mainPanelRight.Region = Graphic.Draw.RoundedRectangle(0, 0, mainPanelRight.Width, mainPanelRight.Height, 20, 20);
            mainPanelLeft.Region = Graphic.Draw.RoundedRectangle(0, 0, mainPanelLeft.Width, mainPanelLeft.Height, 20, 20);

        }

        
    }
}
