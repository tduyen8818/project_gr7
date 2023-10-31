using QLBenhVienDaLieu.Database;
using QLBenhVienDaLieu.GiaoDien.Lich_Kham.DatLichKham;
using QLBenhVienDaLieu.GiaoDien.Lich_Kham.XemLichKham;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBenhVienDaLieu
{
    public partial class BenhNhan_Trang : Form
    {
        private bool isCollapsed1;

        private SqlFunctionCaller sqlFunctionCaller;

        Rectangle originalForm;
        Rectangle originalButtonLogo;
        Rectangle originalButtonTrangChu;
        Rectangle originalButtonDichVu;
        Rectangle originalButtonLichKham;
        Rectangle originalButtonXemLich;
        Rectangle originalButtonDatLich;
        Rectangle originalButtonThongBao;
        Rectangle originalButtonHoTro;
        Rectangle originalButtonTaiKhoan;
        Rectangle originalButtonHoSoBenhNhan;
        Rectangle originalButtonTaiKhoanSub;
        Rectangle originalButtonTextPhone;
        Rectangle originalButtonDatLichKhamNgay;
        Rectangle originalButtonPhoneUser;
        Rectangle originalButtonGioiThieu;
        Rectangle originalMainPanelLeft;
        Rectangle originalMainPanelRight;
        Rectangle originalPanelDropDown1;
        Rectangle originalPanelDropDown2;
        Rectangle originalLabel1;
        Rectangle originalLabel2;
        Rectangle originalLabel3;
        Rectangle originalLabel4;
        Rectangle originalLabel5;
        Rectangle originalLabel6;
        Rectangle originalPanel3;
        Rectangle originalPanel4;
        Rectangle originalPanel6;
        Rectangle originalPanel7;
        Rectangle originalPanel8;
        Rectangle originalPanel9;
        Rectangle originalPanel10;
        Rectangle originalPanel11;
        Rectangle originalPanel12;
        Rectangle originalPanel13;
        Rectangle originalPanel14;
        Rectangle originalPanel15;
        Rectangle originalPanel18;
        Rectangle originalPanel19;

        float textSizeInitialButtonLogo;
        float textSizeInitialButtonTrangChu;
        float textSizeInitialButtonDichVu;
        float textSizeInitialButtonLichKham;
        float textSizeInitialButtonXemLich;
        float textSizeInitialButtonDatLich;
        float textSizeInitialButtonThongBao;
        float textSizeInitialButtonHoTro;
        float textSizeInitialButtonTaiKhoan;
        float textSizeInitialButtonHoSoBenhNhan;
        float textSizeInitialButtonTaiKhoanSub;
        float textSizeInitialButtonTextPhone;
        float textSizeInitialButtonDatLichKhamNgay;
        float textSizeInitialButtonPhoneUser;
        float textSizeInitialButtonGioiThieu;
        float textSizeInitialLabel1;
        float textSizeInitialLabel2;
        float textSizeInitialLabel3;
        float textSizeInitialLabel4;
        float textSizeInitialLabel5;
        float textSizeInitialLabel6;

        public Panel MainPanelRight { get {return mainPanelRight; } set {mainPanelRight = value; } }

        public BenhNhan_Trang()
        {

            this.sqlFunctionCaller = new SqlFunctionCaller();
            sqlFunctionCaller.Connect();

            InitializeComponent();
            

            originalForm = new Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height);
            originalButtonLogo = new Rectangle(buttonLogo.Location.X, buttonLogo.Location.Y, buttonLogo.Width, buttonLogo.Height);
            originalButtonTrangChu = new Rectangle(buttonTrangChu.Location.X, buttonTrangChu.Location.Y, buttonTrangChu.Width, buttonTrangChu.Height);
            originalButtonDichVu = new Rectangle(buttonDichVu.Location.X, buttonDichVu.Location.Y, buttonDichVu.Width, buttonDichVu.Height);
            originalButtonLichKham = new Rectangle(buttonLichKham.Location.X, buttonLichKham.Location.Y, buttonLichKham.Width, buttonLichKham.Height);
            originalButtonXemLich = new Rectangle(buttonXemLich.Location.X, buttonXemLich.Location.Y, buttonXemLich.Width, buttonXemLich.Height);
            originalButtonDatLich = new Rectangle(buttonDatLich.Location.X, buttonDatLich.Location.Y, buttonDatLich.Width, buttonDatLich.Height);
            originalButtonThongBao = new Rectangle(buttonThongBao.Location.X, buttonThongBao.Location.Y, buttonThongBao.Width, buttonThongBao.Height);
            originalButtonHoTro = new Rectangle(buttonHoTro.Location.X, buttonHoTro.Location.Y, buttonHoTro.Width, buttonHoTro.Height);
            originalButtonTaiKhoan = new Rectangle(buttonTaiKhoan.Location.X, buttonTaiKhoan.Location.Y, buttonTaiKhoan.Width, buttonTaiKhoan.Height);
            originalButtonHoSoBenhNhan = new Rectangle(buttonHoSoBenhNhan.Location.X, buttonHoSoBenhNhan.Location.Y, buttonHoSoBenhNhan.Width, buttonHoSoBenhNhan.Height);
            originalButtonTaiKhoanSub = new Rectangle(buttonTaiKhoanSub.Location.X, buttonTaiKhoanSub.Location.Y, buttonTaiKhoanSub.Width, buttonTaiKhoanSub.Height);
            originalButtonTextPhone = new Rectangle(buttonTextPhone.Location.X, buttonTextPhone.Location.Y, buttonTextPhone.Width, buttonTextPhone.Height);
            originalButtonDatLichKhamNgay = new Rectangle(buttonDatLichKhamNgay.Location.X, buttonDatLichKhamNgay.Location.Y, buttonDatLichKhamNgay.Width, buttonDatLichKhamNgay.Height);
            originalButtonPhoneUser = new Rectangle(buttonPhoneUser.Location.X, buttonPhoneUser.Location.Y, buttonPhoneUser.Width, buttonPhoneUser.Height);
            originalButtonGioiThieu = new Rectangle(buttonGioiThieu.Location.X, buttonGioiThieu.Location.Y, buttonGioiThieu.Width, buttonGioiThieu.Height);
            originalMainPanelLeft = new Rectangle(mainPanelLeft.Location.X, mainPanelLeft.Location.Y, mainPanelLeft.Width, mainPanelLeft.Height);
            originalMainPanelRight = new Rectangle(mainPanelRight.Location.X, mainPanelRight.Location.Y, mainPanelRight.Width, mainPanelRight.Height);
            originalPanelDropDown1 = new Rectangle(panelDropDown1.Location.X, panelDropDown1.Location.Y, panelDropDown1.Width, panelDropDown1.Height);
            originalPanelDropDown2 = new Rectangle(panelDropDown2.Location.X, panelDropDown2.Location.Y, panelDropDown2.Width, panelDropDown2.Height);
            originalLabel1 = new Rectangle(label1.Location.X, label1.Location.Y, label1.Width, label1.Height);
            originalLabel2 = new Rectangle(label2.Location.X, label2.Location.Y, label2.Width, label2.Height);
            originalLabel3 = new Rectangle(label3.Location.X, label3.Location.Y, label3.Width, label3.Height);
            originalLabel4 = new Rectangle(label4.Location.X, label4.Location.Y, label4.Width, label4.Height);
            originalLabel5 = new Rectangle(label5.Location.X, label5.Location.Y, label5.Width, label5.Height);
            originalLabel6 = new Rectangle(label6.Location.X, label6.Location.Y, label6.Width, label6.Height);
            originalPanel3 = new Rectangle(panel3.Location.X, panel3.Location.Y, panel3.Width, panel3.Height);
            originalPanel4 = new Rectangle(panel4.Location.X, panel4.Location.Y, panel4.Width, panel4.Height);
            originalPanel6 = new Rectangle(panel6.Location.X, panel6.Location.Y, panel6.Width, panel6.Height);
            originalPanel7 = new Rectangle(panel7.Location.X, panel7.Location.Y, panel7.Width, panel7.Height);
            originalPanel8 = new Rectangle(panel8.Location.X, panel8.Location.Y, panel8.Width, panel8.Height);
            originalPanel9 = new Rectangle(panel9.Location.X, panel9.Location.Y, panel9.Width, panel9.Height);
            originalPanel10 = new Rectangle(panel10.Location.X, panel10.Location.Y, panel10.Width, panel10.Height);
            originalPanel11 = new Rectangle(panel11.Location.X, panel11.Location.Y, panel11.Width, panel11.Height);
            originalPanel12 = new Rectangle(panel12.Location.X, panel12.Location.Y, panel12.Width, panel12.Height);
            originalPanel13 = new Rectangle(panel13.Location.X, panel13.Location.Y, panel13.Width, panel13.Height);
            originalPanel14 = new Rectangle(panel14.Location.X, panel14.Location.Y, panel14.Width, panel14.Height);
            originalPanel15 = new Rectangle(panel15.Location.X, panel15.Location.Y, panel15.Width, panel15.Height);
            originalPanel18 = new Rectangle(panel18.Location.X, panel18.Location.Y, panel18.Width, panel18.Height);
            originalPanel19 = new Rectangle(panel19.Location.X, panel19.Location.Y, panel19.Width, panel19.Height);

            textSizeInitialButtonLogo = buttonLogo.Font.Size;
            textSizeInitialButtonTrangChu = buttonTrangChu.Font.Size;
            textSizeInitialButtonDichVu = buttonDichVu.Font.Size;
            textSizeInitialButtonLichKham = buttonLichKham.Font.Size;
            textSizeInitialButtonXemLich = buttonXemLich.Font.Size;
            textSizeInitialButtonDatLich = buttonDatLich.Font.Size;
            textSizeInitialButtonThongBao = buttonThongBao.Font.Size;
            textSizeInitialButtonHoTro = buttonHoTro.Font.Size;
            textSizeInitialButtonTaiKhoan = buttonTaiKhoan.Font.Size;
            textSizeInitialButtonHoSoBenhNhan = buttonHoSoBenhNhan.Font.Size;
            textSizeInitialButtonTaiKhoanSub = buttonTaiKhoanSub.Font.Size;
            textSizeInitialButtonTextPhone = buttonTextPhone.Font.Size;
            textSizeInitialButtonDatLichKhamNgay = buttonDatLichKhamNgay.Font.Size;
            textSizeInitialButtonPhoneUser = buttonPhoneUser.Font.Size;
            textSizeInitialButtonGioiThieu = buttonGioiThieu.Font.Size;
            textSizeInitialLabel1 = label1.Font.Size;
            textSizeInitialLabel2 = label2.Font.Size;
            textSizeInitialLabel3 = label3.Font.Size;
            textSizeInitialLabel4 = label4.Font.Size;
            textSizeInitialLabel5 = label5.Font.Size;
            textSizeInitialLabel6 = label6.Font.Size;

            mainPanelLeft.Region = Graphic.Draw.RoundedRectangle(0, 0, mainPanelLeft.Width, mainPanelLeft.Height, 20, 20);
            mainPanelRight.Region = Graphic.Draw.RoundedRectangle(0, 0, mainPanelRight.Width, mainPanelRight.Height, 20, 20);
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void buttonTrangChu_Click(object sender, EventArgs e)
        {

        }

        private void buttonDichVu_Click(object sender, EventArgs e)
        {

        }

        private void buttonLichKham_Click(object sender, EventArgs e)
        {
            if (panelDropDown1.Height > (buttonXemLich.Height + buttonDatLich.Height))
            {
                panelDropDown1.Height = buttonLichKham.Height;
            } else
            {
                panelDropDown1.Height = buttonLichKham.Height + buttonXemLich.Height + buttonDatLich.Height;
            }
        }

        private void buttonXemLich_Click(object sender, EventArgs e)
        {
            mainPanelRight.Controls.Clear();
            XemLichKham xemLichKham = new XemLichKham(sqlFunctionCaller, this);

            xemLichKham.TopLevel = false;
            xemLichKham.Dock = DockStyle.Fill;

            mainPanelRight.Controls.Add(xemLichKham);
            mainPanelRight.Tag = xemLichKham;

            xemLichKham.Show();
        }

        private void buttonDatLich_Click(object sender, EventArgs e)
        {
            mainPanelRight.Controls.Clear();
            DatLichKham datLichKham = new DatLichKham(sqlFunctionCaller, this);

            datLichKham.TopLevel = false;
            datLichKham.Dock = DockStyle.Fill;

            mainPanelRight.Controls.Add(datLichKham);
            mainPanelRight.Tag = datLichKham;

            datLichKham.Show();
        }

        private void buttonThongBao_Click(object sender, EventArgs e)
        {

        }

        private void buttonHoTro_Click(object sender, EventArgs e)
        {

        }

        private void buttonTaiKhoan_Click(object sender, EventArgs e)
        {
            if (panelDropDown2.Height > (buttonTaiKhoan.Height + buttonTaiKhoanSub.Height))
            {
                panelDropDown2.Height = buttonTaiKhoan.Height;
            }
            else
            {
                panelDropDown2.Height = buttonTaiKhoan.Height + buttonTaiKhoanSub.Height + buttonHoSoBenhNhan.Height;
            }
        }

        private void buttonHoSoBenhNhan_Click(object sender, EventArgs e)
        {

        }

        private void buttonTaiKhoanSub_Click(object sender, EventArgs e)
        {

        }

        private void buttonDatLichKhamNgay_Click(object sender, EventArgs e)
        {

        }

        private void buttonPhoneUser_Click(object sender, EventArgs e)
        {

        }

        private void buttonTextPhone_Click(object sender, EventArgs e)
        {

        }

        private void BenhNhan_Trang_Resize(object sender, EventArgs e)
        {
            Graphic.ScaleSize.Resize(originalForm, originalButtonLogo, buttonLogo, this, textSizeInitialButtonLogo);
            Graphic.ScaleSize.Resize(originalForm, originalButtonTrangChu, buttonTrangChu, this, textSizeInitialButtonTrangChu);
            Graphic.ScaleSize.Resize(originalForm, originalButtonDichVu, buttonDichVu, this, textSizeInitialButtonDichVu);
            Graphic.ScaleSize.Resize(originalForm, originalButtonLichKham, buttonLichKham, this, textSizeInitialButtonLichKham);
            Graphic.ScaleSize.Resize(originalForm, originalButtonXemLich, buttonXemLich, this, textSizeInitialButtonXemLich);
            Graphic.ScaleSize.Resize(originalForm, originalButtonDatLich, buttonDatLich, this, textSizeInitialButtonDatLich);
            Graphic.ScaleSize.Resize(originalForm, originalButtonThongBao, buttonThongBao, this, textSizeInitialButtonThongBao);
            Graphic.ScaleSize.Resize(originalForm, originalButtonHoTro, buttonHoTro, this, textSizeInitialButtonHoTro);
            Graphic.ScaleSize.Resize(originalForm, originalButtonTaiKhoan, buttonTaiKhoan, this, textSizeInitialButtonTaiKhoan);
            Graphic.ScaleSize.Resize(originalForm, originalButtonHoSoBenhNhan, buttonHoSoBenhNhan, this, textSizeInitialButtonHoSoBenhNhan);
            Graphic.ScaleSize.Resize(originalForm, originalButtonTaiKhoanSub, buttonTaiKhoanSub, this, textSizeInitialButtonTaiKhoanSub);
            Graphic.ScaleSize.Resize(originalForm, originalButtonTextPhone, buttonTextPhone, this, textSizeInitialButtonTextPhone);
            Graphic.ScaleSize.Resize(originalForm, originalButtonDatLichKhamNgay, buttonDatLichKhamNgay, this, textSizeInitialButtonDatLichKhamNgay);
            Graphic.ScaleSize.Resize(originalForm, originalButtonPhoneUser, buttonPhoneUser, this, textSizeInitialButtonPhoneUser);
            Graphic.ScaleSize.Resize(originalForm, originalButtonGioiThieu, buttonGioiThieu, this, textSizeInitialButtonGioiThieu);
            Graphic.ScaleSize.Resize(originalForm, originalMainPanelLeft, mainPanelLeft, this);
            Graphic.ScaleSize.Resize(originalForm, originalMainPanelRight, mainPanelRight, this);
            Graphic.ScaleSize.Resize(originalForm, originalPanelDropDown1, panelDropDown1, this);
            Graphic.ScaleSize.Resize(originalForm, originalPanelDropDown2, panelDropDown2, this);
            Graphic.ScaleSize.Resize(originalForm, originalLabel1, label1, this, textSizeInitialLabel1);
            Graphic.ScaleSize.Resize(originalForm, originalLabel2, label2, this, textSizeInitialLabel2);
            Graphic.ScaleSize.Resize(originalForm, originalLabel3, label3, this, textSizeInitialLabel3);
            Graphic.ScaleSize.Resize(originalForm, originalLabel4, label4, this, textSizeInitialLabel4);
            Graphic.ScaleSize.Resize(originalForm, originalLabel5, label5, this, textSizeInitialLabel5);
            Graphic.ScaleSize.Resize(originalForm, originalLabel6, label6, this, textSizeInitialLabel6);
            Graphic.ScaleSize.Resize(originalForm, originalPanel3, panel3, this);
            Graphic.ScaleSize.Resize(originalForm, originalPanel4, panel4, this);
            Graphic.ScaleSize.Resize(originalForm, originalPanel6, panel6, this);
            Graphic.ScaleSize.Resize(originalForm, originalPanel7, panel7, this);
            Graphic.ScaleSize.Resize(originalForm, originalPanel8, panel8, this);
            Graphic.ScaleSize.Resize(originalForm, originalPanel9, panel9, this);
            Graphic.ScaleSize.Resize(originalForm, originalPanel10, panel10, this);
            Graphic.ScaleSize.Resize(originalForm, originalPanel11, panel11, this);
            Graphic.ScaleSize.Resize(originalForm, originalPanel12, panel12, this);
            Graphic.ScaleSize.Resize(originalForm, originalPanel13, panel13, this);
            Graphic.ScaleSize.Resize(originalForm, originalPanel14, panel14, this);
            Graphic.ScaleSize.Resize(originalForm, originalPanel15, panel15, this);
            Graphic.ScaleSize.Resize(originalForm, originalPanel18, panel18, this);
            Graphic.ScaleSize.Resize(originalForm, originalPanel19, panel19, this);

            mainPanelLeft.Region = Graphic.Draw.RoundedRectangle(0, 0, mainPanelLeft.Width, mainPanelLeft.Height, 20, 20);
            mainPanelRight.Region = Graphic.Draw.RoundedRectangle(0, 0, mainPanelRight.Width, mainPanelRight.Height, 20, 20);

           
        }
    }
}
