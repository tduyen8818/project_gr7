using QLBenhVienDaLieu.Database.Function;
using QLBenhVienDaLieu.GiaoDien.LeTanTrangUI.HoSoBenhNhanUI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QLBenhVienDaLieu
{
    public partial class LeTan_Trang : Form
    {
        private string sDT;

        private SqlFunctionCaller sqlFunctionCaller;

        private Rectangle originalForm;

        public Panel Guna2CustomGradientPanel2
        {
            get
            {
                return guna2CustomGradientPanel2;
            }
            set
            {
                guna2CustomGradientPanel2  = value;
            }
        }


        public LeTan_Trang(string sDT, SqlFunctionCaller sqlFunctionCaller)
        {
            InitializeComponent();
            this.sDT = sDT;
            this.sqlFunctionCaller = sqlFunctionCaller;

            originalForm = new Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height);

            guna2CustomGradientPanel2.Region = Graphic.Draw.RoundedRectangle(0, 0 , guna2CustomGradientPanel2.Width, guna2CustomGradientPanel2.Height, 20, 20);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TaiKhoan_LT TaiKhoan = new TaiKhoan_LT(sDT);
            this.Hide();
            TaiKhoan.ShowDialog();
            this.Close();
        }

        private void btn_TrangChu_Click(object sender, EventArgs e)
        {

        }

        private void btn_LichLamViec_Click(object sender, EventArgs e)
        {
            LichLamViec_LT LichLamViec = new LichLamViec_LT(sDT);
            this.Hide();
            LichLamViec.ShowDialog();
            this.Close();
        }

        private void buttonHoSoBenhNhan_Click(object sender, EventArgs e)
        {
            guna2CustomGradientPanel2.Controls.Clear();

            HoSoBenhNhanForm hoSoBenhNhanForm = new HoSoBenhNhanForm(this, sqlFunctionCaller);

            hoSoBenhNhanForm.TopLevel = false;
            hoSoBenhNhanForm.Dock = DockStyle.Fill;

            guna2CustomGradientPanel2.Controls.Add( hoSoBenhNhanForm);
            guna2CustomGradientPanel2.Tag = hoSoBenhNhanForm;

            hoSoBenhNhanForm.Show();
        }

        private void LeTan_Trang_Resize(object sender, EventArgs e)
        {
            if (originalForm.Width != 0)
            {
                guna2CustomGradientPanel2.Region = Graphic.Draw.RoundedRectangle(0, 0, guna2CustomGradientPanel2.Width, guna2CustomGradientPanel2.Height, 20, 20);
            }
        }
    }
}
