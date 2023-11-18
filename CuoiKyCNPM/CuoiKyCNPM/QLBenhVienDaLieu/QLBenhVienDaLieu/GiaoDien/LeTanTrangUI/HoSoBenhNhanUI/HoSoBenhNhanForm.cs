using QLBenhVienDaLieu.Database.Check;
using QLBenhVienDaLieu.Database.Class;
using QLBenhVienDaLieu.Database.Function;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QLBenhVienDaLieu.GiaoDien.LeTanTrangUI.HoSoBenhNhanUI
{
    public partial class HoSoBenhNhanForm : Form
    {
        private SqlFunctionCaller sqlFunctionCaller;
        private LeTan_Trang leTan_Trang;

        List<DataHoSoBenhNhan> listDataHoSoBenhNhan = new List<DataHoSoBenhNhan>();

        private Rectangle originalForm;
        private Rectangle originalTitleHoSoBenhNhan;
        private Rectangle originalTextBoxSearchSoDienThoai;
        private Rectangle originalTextErrorMaTaiKhoan;
        private Rectangle originalButtonSearch;
        private Rectangle originalFlowLayoutPanel1;
        private Rectangle originalTextTemp;
        private Rectangle originalButtonAdd;

        private float textSizeInitialTitleHoSoBenhNhan;
        private float textSizeInitialTextTextBoxSearchDienThoai;
        private float textSizeInitialTextErrorMaTaiKhoan;

        public TextBox TextBoxSearchMaTaiKhoan
        {
            get
            {
                return textBoxSearchMaTaiKhoan;
            }

            set
            {
                textBoxSearchMaTaiKhoan = value;
            }
        }

        public HoSoBenhNhanForm(LeTan_Trang leTan_Trang, SqlFunctionCaller sqlFunctionCaller)
        {
            this.sqlFunctionCaller = sqlFunctionCaller;
            this.leTan_Trang = leTan_Trang;

            InitializeComponent();

            originalForm = new Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height);
            originalTitleHoSoBenhNhan = new Rectangle(titleHoSoBenhNhan.Location.X, titleHoSoBenhNhan.Location.Y, titleHoSoBenhNhan.Width, titleHoSoBenhNhan.Height);
            originalTextBoxSearchSoDienThoai = new Rectangle(textBoxSearchMaTaiKhoan.Location.X, textBoxSearchMaTaiKhoan.Location.Y, textBoxSearchMaTaiKhoan.Width, textBoxSearchMaTaiKhoan.Height);
            originalTextErrorMaTaiKhoan = new Rectangle(textErrorMaTaiKhoan.Location.X, textErrorMaTaiKhoan.Location.Y, textErrorMaTaiKhoan.Width, textErrorMaTaiKhoan.Height);
            originalButtonSearch = new Rectangle(buttonSearch.Location.X, buttonSearch.Location.Y, buttonSearch.Width, buttonSearch.Height);
            originalFlowLayoutPanel1 = new Rectangle(flowLayoutPanel1.Location.X, flowLayoutPanel1.Location.Y, flowLayoutPanel1.Width, flowLayoutPanel1.Height);
            originalTextTemp = new Rectangle(textTemp.Location.X, textTemp.Location.Y, textTemp.Width, textTemp.Height);
            originalButtonAdd = new Rectangle(buttonAdd.Location.X, buttonAdd.Location.Y, buttonAdd.Width, buttonAdd.Height);

            textSizeInitialTitleHoSoBenhNhan = titleHoSoBenhNhan.Font.Size;
            textSizeInitialTextTextBoxSearchDienThoai = textBoxSearchMaTaiKhoan.Font.Size;
            textSizeInitialTextErrorMaTaiKhoan = textErrorMaTaiKhoan.Font.Size;


        }

        private void HoSoBenhNhanForm_Resize(object sender, EventArgs e)
        {
            if (originalForm.Width != 0 && titleHoSoBenhNhan.Font.Size != 0)
            {
                Graphic.ScaleSize.Resize(originalForm, originalTitleHoSoBenhNhan, titleHoSoBenhNhan, this, textSizeInitialTitleHoSoBenhNhan);
                Graphic.ScaleSize.Resize(originalForm, originalTextBoxSearchSoDienThoai, textBoxSearchMaTaiKhoan, this, textSizeInitialTextTextBoxSearchDienThoai);
                Graphic.ScaleSize.Resize(originalForm, originalTextErrorMaTaiKhoan, textErrorMaTaiKhoan, this, textSizeInitialTextErrorMaTaiKhoan);
                Graphic.ScaleSize.Resize(originalForm, originalButtonSearch, buttonSearch, this);
                Graphic.ScaleSize.Resize(originalForm, originalFlowLayoutPanel1, flowLayoutPanel1, this);
                Graphic.ScaleSize.ResizeX(originalForm, originalTextTemp, textTemp, this);
                Graphic.ScaleSize.Resize(originalForm, originalButtonAdd, buttonAdd, this);

                if (buttonSearch.Height != textBoxSearchMaTaiKhoan.Height)
                {
                    buttonSearch.Height = textBoxSearchMaTaiKhoan.Height;
                }
            }
        }

        private void textBoxSearchSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            textErrorMaTaiKhoan.Visible = false;

            if (Available.CheckSoDienThoai(textBoxSearchMaTaiKhoan.Text))
            {
                textBoxSearchMaTaiKhoan.BackColor = Color.White;
                textBoxSearchMaTaiKhoan.ForeColor = Color.Black;
                buttonSearch.BackColor = SystemColors.ActiveCaption;
                buttonSearch.Enabled = true;
            } else
            {
                textBoxSearchMaTaiKhoan.BackColor = Color.LightCoral;
                textBoxSearchMaTaiKhoan.ForeColor = Color.Red;
                buttonSearch.BackColor = Color.Gray;
                buttonSearch.Enabled = false;
            }
        }

        public void buttonSearch_Click(object sender, EventArgs e)
        {
            if (sqlFunctionCaller.GetDangKyUserBySoDienThoai(textBoxSearchMaTaiKhoan.Text).SoDienThoai.Equals(""))
            {
                textErrorMaTaiKhoan.Visible = true;

                buttonAdd.Enabled = false;
                buttonAdd.BackColor = Color.Gray;

                foreach (DataHoSoBenhNhan dataHoSoBenhNhan in listDataHoSoBenhNhan)
                {
                    flowLayoutPanel1.Controls.Remove(dataHoSoBenhNhan);
                }

                listDataHoSoBenhNhan.Clear();

            } else
            {
                textErrorMaTaiKhoan.Visible = false;

                buttonAdd.Enabled = true;
                buttonAdd.BackColor = Color.MediumSeaGreen;

                foreach (DataHoSoBenhNhan dataHoSoBenhNhan in listDataHoSoBenhNhan)
                {
                    flowLayoutPanel1.Controls.Remove(dataHoSoBenhNhan);
                }

                listDataHoSoBenhNhan.Clear();

                List<HoSoBenhNhan> listHoSoBenhNhan = sqlFunctionCaller.GetHoSoBenhNhanByMaTaiKhoan(textBoxSearchMaTaiKhoan.Text);

                foreach (HoSoBenhNhan hoSoBenhNhan in listHoSoBenhNhan)
                {
                    DataHoSoBenhNhan dataHoSoBenhNhan = new DataHoSoBenhNhan(this.leTan_Trang, this, sqlFunctionCaller);
                    dataHoSoBenhNhan.DataMaHoSoBenhNhan.Text = hoSoBenhNhan.MaHoSoBenhNhan;
                    dataHoSoBenhNhan.DataHoVaTen.Text = hoSoBenhNhan.HoVaTen;
                    dataHoSoBenhNhan.DataSoDienThoai.Text = hoSoBenhNhan.SoDienThoai;
                    dataHoSoBenhNhan.DataNgaySinh.Text = hoSoBenhNhan.NgaySinh.ToShortDateString();
                    dataHoSoBenhNhan.DataGioiTinh.Text = hoSoBenhNhan.GioiTinh;
                    dataHoSoBenhNhan.DataCCCD.Text = hoSoBenhNhan.CCCD;


                    dataHoSoBenhNhan.TopLevel = false;
                    dataHoSoBenhNhan.Dock = DockStyle.Top;

                    listDataHoSoBenhNhan.Add(dataHoSoBenhNhan);

                    flowLayoutPanel1.Controls.Add(dataHoSoBenhNhan);
                    flowLayoutPanel1.Tag = dataHoSoBenhNhan;

                    dataHoSoBenhNhan.Show();
                }
            }

        }

        private void textBoxSearchSoDienThoai_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (buttonSearch.Enabled == true)
                {
                    buttonSearch_Click(null, null);
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Panel guna2CustomGradientPanel2 = this.leTan_Trang.Guna2CustomGradientPanel2;

            guna2CustomGradientPanel2.Controls.Clear();

            AddHoSoBenhNhan addHoSoBenhNhan = new AddHoSoBenhNhan(textBoxSearchMaTaiKhoan.Text, this.leTan_Trang, sqlFunctionCaller);

            addHoSoBenhNhan.TopLevel = false;
            addHoSoBenhNhan.Dock = DockStyle.Fill;

            guna2CustomGradientPanel2.Controls.Add(addHoSoBenhNhan);
            guna2CustomGradientPanel2.Tag = addHoSoBenhNhan;

            addHoSoBenhNhan.Show();
        }
    }
}
