using QLBenhVienDaLieu.Database.Function;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QLBenhVienDaLieu.GiaoDien.LeTanTrangUI.HoSoBenhNhanUI
{
    public partial class DataHoSoBenhNhan : Form
    {
        private SqlFunctionCaller sqlFunctionCaller;
        private HoSoBenhNhanForm hoSoBenhNhanForm;
        private LeTan_Trang leTan_Trang;

        private Rectangle originalForm;
        private Rectangle originalShowHoSoBenhNhan;
        private Rectangle originalTextMaHoSoBenhNhan;
        private Rectangle originalDataMaHoSoBenhNhan;
        private Rectangle originalTextHoVaTen;
        private Rectangle originalDataHoVaTen;
        private Rectangle originalTextSoDienThoai;
        private Rectangle originalDataSoDienThoai;
        private Rectangle originalTextNgaySinh;
        private Rectangle originalDataNgaySinh;
        private Rectangle originalTextGioiTinh;
        private Rectangle originalDataGioiTinh;
        private Rectangle originalTextCCCD;
        private Rectangle originalDataCCCD;
        private Rectangle originalPanel2;
        private Rectangle originalPanel3;
        private Rectangle originalPanel4;
        private Rectangle originalPanel5;
        private Rectangle originalPanel6;
        private Rectangle originalPanel7;
        private Rectangle originalPanel8;
        private Rectangle originalButtonEdit;
        private Rectangle originalButtonAddLichKham;
        private Rectangle originalButtonDelete;

        float textSizeInitialTextMaHoSoBenhNhan;
        float textSizeInitialDataMaHoSoBenhNhan;
        float textSizeInitialTextHoVaTen;
        float textSizeInitialDataHoVaTen;
        float textSizeInitialTextSoDienThoai;
        float textSizeInitialDataSoDienThoai;
        float textSizeInitialTextNgaySinh;
        float textSizeInitialDataNgaySinh;
        float textSizeInitialTextGioiTinh;
        float textSizeInitialDataGioiTinh;
        float textSizeInitialTextCCCD;
        float textSizeInitialDataCCCD;

        public Label DataMaHoSoBenhNhan { get { return this.dataMaHoSoBenhNhan; } set { this.dataMaHoSoBenhNhan = value; } }
        public Label DataHoVaTen { get { return this.dataHoVaTen; } set { this.dataHoVaTen = value; } }
        public Label DataNgaySinh { get { return this.dataNgaySinh; } set { this.dataNgaySinh = value; } }
        public Label DataGioiTinh { get { return this.dataGioiTinh; } set { this.dataGioiTinh = value; } }
        public Label DataCCCD { get { return this.dataCCCD; } set { this.dataCCCD = value; } }
        public Label DataSoDienThoai { get { return this.dataSoDienThoai; } set { this.dataSoDienThoai = value; } }

        public DataHoSoBenhNhan(LeTan_Trang leTan_Trang, HoSoBenhNhanForm hoSoBenhNhanForm, SqlFunctionCaller sqlFunctionCaller)
        {
            this.sqlFunctionCaller = sqlFunctionCaller;
            this.hoSoBenhNhanForm = hoSoBenhNhanForm;
            this.leTan_Trang = leTan_Trang;

            InitializeComponent();

            originalForm = new Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height);
            originalShowHoSoBenhNhan = new Rectangle(showHoSoBenhNhan.Location.X, showHoSoBenhNhan.Location.Y, showHoSoBenhNhan.Width, showHoSoBenhNhan.Height);
            originalTextMaHoSoBenhNhan = new Rectangle(textMaHoSoBenhNhan.Location.X, textMaHoSoBenhNhan.Location.Y, textMaHoSoBenhNhan.Width, textMaHoSoBenhNhan.Height);
            originalTextHoVaTen = new Rectangle(textHoVaTen.Location.X, textHoVaTen.Location.Y, textHoVaTen.Width, textHoVaTen.Height);
            originalTextGioiTinh = new Rectangle(textGioiTinh.Location.X, textGioiTinh.Location.Y, textGioiTinh.Width, textGioiTinh.Height);
            originalTextNgaySinh = new Rectangle(textNgaySinh.Location.X, textNgaySinh.Location.Y, textNgaySinh.Width, textNgaySinh.Height);
            originalTextCCCD = new Rectangle(textCCCD.Location.X, textCCCD.Location.Y, textCCCD.Width, textCCCD.Height);
            originalTextSoDienThoai = new Rectangle(textSoDienThoai.Location.X, textSoDienThoai.Location.Y, textSoDienThoai.Width, textSoDienThoai.Height);
            originalDataMaHoSoBenhNhan = new Rectangle(dataMaHoSoBenhNhan.Location.X, dataMaHoSoBenhNhan.Location.Y, dataMaHoSoBenhNhan.Width, dataMaHoSoBenhNhan.Height);
            originalDataHoVaTen = new Rectangle(dataHoVaTen.Location.X, dataHoVaTen.Location.Y, dataHoVaTen.Width, dataHoVaTen.Height);
            originalDataGioiTinh = new Rectangle(dataGioiTinh.Location.X, dataGioiTinh.Location.Y, dataGioiTinh.Width, dataGioiTinh.Height);
            originalDataNgaySinh = new Rectangle(dataNgaySinh.Location.X, dataNgaySinh.Location.Y, dataNgaySinh.Width, dataNgaySinh.Height);
            originalDataCCCD = new Rectangle(dataCCCD.Location.X, dataCCCD.Location.Y, dataCCCD.Width, dataCCCD.Height);
            originalDataSoDienThoai = new Rectangle(dataSoDienThoai.Location.X, dataSoDienThoai.Location.Y, dataSoDienThoai.Width, dataSoDienThoai.Height);
            originalButtonEdit = new Rectangle(buttonEdit.Location.X, buttonEdit.Location.Y, buttonEdit.Width, buttonEdit.Height);
            originalButtonAddLichKham = new Rectangle(buttonAddLichKham.Location.X, buttonAddLichKham.Location.Y, buttonAddLichKham.Width, buttonAddLichKham.Height);
            originalButtonDelete = new Rectangle(buttonDelete.Location.X, buttonDelete.Location.Y, buttonDelete.Width, buttonDelete.Height);
            originalPanel2 = new Rectangle(panel2.Location.X, panel2.Location.Y, panel2.Width, panel2.Height);
            originalPanel3 = new Rectangle(panel3.Location.X, panel3.Location.Y, panel3.Width, panel3.Height);
            originalPanel4 = new Rectangle(panel4.Location.X, panel4.Location.Y, panel4.Width, panel4.Height);
            originalPanel5 = new Rectangle(panel5.Location.X, panel5.Location.Y, panel5.Width, panel5.Height);
            originalPanel6 = new Rectangle(panel6.Location.X, panel6.Location.Y, panel6.Width, panel6.Height);
            originalPanel7 = new Rectangle(panel7.Location.X, panel7.Location.Y, panel7.Width, panel7.Height);
            originalPanel8 = new Rectangle(panel8.Location.X, panel8.Location.Y, panel8.Width, panel8.Height);

            textSizeInitialTextMaHoSoBenhNhan = textMaHoSoBenhNhan.Font.Size;
            textSizeInitialTextHoVaTen = textHoVaTen.Font.Size;
            textSizeInitialTextNgaySinh = textNgaySinh.Font.Size;
            textSizeInitialTextGioiTinh = textGioiTinh.Font.Size;
            textSizeInitialTextCCCD = textCCCD.Font.Size;
            textSizeInitialTextSoDienThoai = textSoDienThoai.Font.Size;
            textSizeInitialDataMaHoSoBenhNhan = dataMaHoSoBenhNhan.Font.Size;
            textSizeInitialDataHoVaTen = dataHoVaTen.Font.Size;
            textSizeInitialDataNgaySinh = dataNgaySinh.Font.Size;
            textSizeInitialDataGioiTinh = dataGioiTinh.Font.Size;
            textSizeInitialDataCCCD = dataCCCD.Font.Size;
            textSizeInitialDataSoDienThoai = dataSoDienThoai.Font.Size;

        }

        private void DataHoSoBenhNhan_Resize(object sender, EventArgs e)
        {
            Graphic.ScaleSize.Resize(originalForm, originalShowHoSoBenhNhan, showHoSoBenhNhan, this);
            Graphic.ScaleSize.Resize(originalForm, originalTextMaHoSoBenhNhan, textMaHoSoBenhNhan, this, textSizeInitialTextMaHoSoBenhNhan);
            Graphic.ScaleSize.Resize(originalForm, originalTextHoVaTen, textHoVaTen, this, textSizeInitialTextHoVaTen);
            Graphic.ScaleSize.Resize(originalForm, originalTextNgaySinh, textNgaySinh, this, textSizeInitialTextNgaySinh);
            Graphic.ScaleSize.Resize(originalForm, originalTextGioiTinh, textGioiTinh, this, textSizeInitialTextGioiTinh);
            Graphic.ScaleSize.Resize(originalForm, originalTextCCCD, textCCCD, this, textSizeInitialTextCCCD);
            Graphic.ScaleSize.Resize(originalForm, originalTextSoDienThoai, textSoDienThoai, this, textSizeInitialTextSoDienThoai);
            Graphic.ScaleSize.Resize(originalForm, originalDataMaHoSoBenhNhan, dataMaHoSoBenhNhan, this, textSizeInitialDataMaHoSoBenhNhan);
            Graphic.ScaleSize.Resize(originalForm, originalDataHoVaTen, dataHoVaTen, this, textSizeInitialDataHoVaTen);
            Graphic.ScaleSize.Resize(originalForm, originalDataGioiTinh, dataGioiTinh, this, textSizeInitialDataGioiTinh);
            Graphic.ScaleSize.Resize(originalForm, originalDataNgaySinh, dataNgaySinh, this, textSizeInitialDataNgaySinh);
            Graphic.ScaleSize.Resize(originalForm, originalDataCCCD, dataCCCD, this, textSizeInitialDataCCCD);
            Graphic.ScaleSize.Resize(originalForm, originalDataSoDienThoai, dataSoDienThoai, this, textSizeInitialDataSoDienThoai);
            Graphic.ScaleSize.Resize(originalForm, originalPanel2, panel2, this);
            Graphic.ScaleSize.Resize(originalForm, originalPanel3, panel3, this);
            Graphic.ScaleSize.Resize(originalForm, originalPanel4, panel4, this);
            Graphic.ScaleSize.Resize(originalForm, originalPanel5, panel5, this);
            Graphic.ScaleSize.Resize(originalForm, originalPanel6, panel6, this);
            Graphic.ScaleSize.Resize(originalForm, originalPanel7, panel7, this);
            Graphic.ScaleSize.Resize(originalForm, originalPanel8, panel8, this);
            Graphic.ScaleSize.Resize(originalForm, originalButtonEdit, buttonEdit, this);
            Graphic.ScaleSize.Resize(originalForm, originalButtonAddLichKham, buttonAddLichKham, this);
            Graphic.ScaleSize.Resize(originalForm, originalButtonDelete, buttonDelete, this);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Panel guna2CustomGradientPanel2 = this.leTan_Trang.Guna2CustomGradientPanel2;

            guna2CustomGradientPanel2.Controls.Clear();

            DataDetailHoSoBenhNhan dataDetailHoSoBenhNhan = new DataDetailHoSoBenhNhan(dataMaHoSoBenhNhan.Text , this.leTan_Trang, sqlFunctionCaller);

            dataDetailHoSoBenhNhan.TopLevel = false;
            dataDetailHoSoBenhNhan.Dock = DockStyle.Fill;

            guna2CustomGradientPanel2.Controls.Add(dataDetailHoSoBenhNhan);
            guna2CustomGradientPanel2.Tag = dataDetailHoSoBenhNhan;

            dataDetailHoSoBenhNhan.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Nếu bạn xóa hồ sơ nó sẽ không thể khôi phục",
                            "Bạn có chắc muốn xóa hồ sơ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                sqlFunctionCaller.DeleteHoSoBenhNhan(dataMaHoSoBenhNhan.Text);

                hoSoBenhNhanForm.buttonSearch_Click(null, null);
            }
        }

        private void buttonAddLichKham_Click(object sender, EventArgs e)
        {
            Panel guna2CustomGradientPanel2 = this.leTan_Trang.Guna2CustomGradientPanel2;

            guna2CustomGradientPanel2.Controls.Clear();

            DatLichKhamFormLeTan datLichKhamFormLeTan = new DatLichKhamFormLeTan(this.hoSoBenhNhanForm.TextBoxSearchMaTaiKhoan.Text,
                dataMaHoSoBenhNhan.Text, this.leTan_Trang, sqlFunctionCaller);

            datLichKhamFormLeTan.TopLevel = false;
            datLichKhamFormLeTan.Dock = DockStyle.Fill;

            guna2CustomGradientPanel2.Controls.Add(datLichKhamFormLeTan);
            guna2CustomGradientPanel2.Tag = datLichKhamFormLeTan;

            datLichKhamFormLeTan.Show();
        }
    }
}
