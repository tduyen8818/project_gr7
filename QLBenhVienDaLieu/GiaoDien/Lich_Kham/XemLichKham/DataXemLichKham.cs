using QLBenhVienDaLieu.Graphic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBenhVienDaLieu.GiaoDien.Lich_Kham.XemLichKham
{
    public partial class DataXemLichKham : Form
    {
        Rectangle originalForm;
        Rectangle originalTextMaPhieu;
        Rectangle originalDataMaPhieu;
        Rectangle originalDataName;
        Rectangle originalTextDichVu;
        Rectangle originalDataDichVu;
        Rectangle originalTextChuyenKhoa;
        Rectangle originalDataChuyenKhoa;
        Rectangle originalTextTrangThai;
        Rectangle originalDataTrangThai;
        Rectangle originalLinkXemChiTiet;

        float textSizeTextMaphieu;
        float textSizeDataMaPhieu;
        float textSizeDataName;
        float textSizeTextDichVu;
        float textSizeDataDichVu;
        float textSizeTextChuyenKhoa;
        float textSizeDataChuyenKhoa;
        float textSizeTextTrangThai;
        float textSizeDataTrangThai;
        float textSizeLinkXemChiTiet;

        public DataXemLichKham()
        {
            InitializeComponent();
            originalForm = new Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height);
            originalTextMaPhieu = new Rectangle(textMaPhieu.Location.X, textMaPhieu.Location.Y, textMaPhieu.Width, textMaPhieu.Height);
            originalDataMaPhieu = new Rectangle(dataMaPhieu.Location.X, dataMaPhieu.Location.Y, dataMaPhieu.Width, dataMaPhieu.Height);
            originalDataName = new Rectangle(dataName.Location.X, dataName.Location.Y, dataName.Width, dataName.Height);
            originalTextDichVu = new Rectangle(textDichVu.Location.X, textDichVu.Location.Y, textDichVu.Width, textDichVu.Height);
            originalDataDichVu = new Rectangle(dataDichVu.Location.X, dataDichVu.Location.Y, dataDichVu.Width, dataDichVu.Height);
            originalTextChuyenKhoa = new Rectangle(textChuyenKhoa.Location.X, textChuyenKhoa.Location.Y, textChuyenKhoa.Width, textChuyenKhoa.Height);
            originalDataChuyenKhoa = new Rectangle(dataChuyenKhoa.Location.X, dataChuyenKhoa.Location.Y, dataChuyenKhoa.Width, dataChuyenKhoa.Height);
            originalTextTrangThai = new Rectangle(textTrangThai.Location.X, textTrangThai.Location.Y, textTrangThai.Width, textTrangThai.Height);
            originalDataTrangThai = new Rectangle(dataTrangThai.Location.X, dataTrangThai.Location.Y, dataTrangThai.Width, dataTrangThai.Height);
            originalLinkXemChiTiet = new Rectangle(linkXemChiTiet.Location.X, linkXemChiTiet.Location.Y, linkXemChiTiet.Width, linkXemChiTiet.Height);

            textSizeTextMaphieu = textMaPhieu.Font.Size;
            textSizeDataMaPhieu = dataMaPhieu.Font.Size;
            textSizeDataName = dataName.Font.Size;
            textSizeTextDichVu = textDichVu.Font.Size;
            textSizeDataDichVu = dataDichVu.Font.Size;
            textSizeTextChuyenKhoa = textChuyenKhoa.Font.Size;
            textSizeDataChuyenKhoa = dataChuyenKhoa.Font.Size;
            textSizeTextTrangThai = textTrangThai.Font.Size;
            textSizeDataTrangThai = dataTrangThai.Font.Size;
            textSizeLinkXemChiTiet = linkXemChiTiet.Font.Size;

        }


        public Label TextMaPhieu
        {
            get { return this.textMaPhieu; }
            set { this.textMaPhieu = value; }
        }

        public Label DataMaPhieu
        {
            get { return this.dataMaPhieu; }
            set { this.dataMaPhieu = value; }
        }

        public Label DataName
        {
            get { return this.dataName; }
            set { this.dataName = value; }
        }

        public Label TextDichVu
        {
            get { return this.textDichVu; }
            set { this.textDichVu = value; }
        }

        public Label DataDichVu
        {
            get { return this.dataDichVu; }
            set { this.dataDichVu = value; }
        }

        public Label TextChuyenKhoa
        {
            get { return this.textChuyenKhoa; }
            set { this.textChuyenKhoa = value; }
        }

        public Label DataChuyenKhoa
        {
            get { return this.dataChuyenKhoa; }
            set { this.dataChuyenKhoa = value; }
        }

        public Label TextTrangThai
        {
            get { return this.textTrangThai; }
            set { this.textTrangThai = value; }
        }

        public Label DataTrangThai
        {
            get { return this.dataTrangThai; }
            set { this.dataTrangThai = value; }
        }

        public LinkLabel LinkXemChiTiet
        {
            get { return this.linkXemChiTiet; }
            set { this.linkXemChiTiet = value; }
        }

        private void DataXemLichKham_Resize(object sender, EventArgs e)
        {
            ScaleSize.Resize(originalForm, originalTextMaPhieu, textMaPhieu, this, textSizeTextMaphieu);
            ScaleSize.Resize(originalForm, originalDataMaPhieu, dataMaPhieu, this, textSizeDataMaPhieu);
            ScaleSize.Resize(originalForm, originalDataName, dataName, this, textSizeDataName);
            ScaleSize.Resize(originalForm, originalTextDichVu, textDichVu, this, textSizeTextDichVu);
            ScaleSize.Resize(originalForm, originalDataDichVu, dataDichVu, this, textSizeDataDichVu);
            ScaleSize.Resize(originalForm, originalTextChuyenKhoa, textChuyenKhoa, this, textSizeTextChuyenKhoa);
            ScaleSize.Resize(originalForm, originalDataChuyenKhoa, dataChuyenKhoa, this, textSizeDataChuyenKhoa);
            ScaleSize.Resize(originalForm, originalTextTrangThai, textTrangThai, this, textSizeTextTrangThai);
            ScaleSize.Resize(originalForm, originalDataTrangThai, dataTrangThai, this, textSizeDataTrangThai);
            ScaleSize.Resize(originalForm, originalLinkXemChiTiet, linkXemChiTiet, this, textSizeLinkXemChiTiet);
        }
    }
}
