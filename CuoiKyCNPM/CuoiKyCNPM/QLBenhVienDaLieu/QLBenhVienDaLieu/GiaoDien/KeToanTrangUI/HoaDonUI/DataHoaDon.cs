using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBenhVienDaLieu.GiaoDien.KeToanTrangUI.HoaDonUI
{
    public partial class DataHoaDon : Form
    {
        public Label MaHoaDon
        {
            get
            {
                return dataMaHoaDon;
            }
            set
            {
                dataMaHoaDon = value;
            }
        }

        public Label MaLichKham
        {
            get
            {
                return dataMaLichKham;
            }
            set
            {
                dataMaLichKham = value;
            }
        }

        public Label TongTien
        {
            get
            {
                return dataTongTien;
            }
            set
            {
                dataTongTien = value;
            }
        }

        public Label HinhThucThanhToan
        {
            get
            {
                return dataHinhThucThanhToan;
            }
            set
            {
                dataHinhThucThanhToan = value;
            }
        }

        private Rectangle originalForm;
        private Rectangle originalTextMaHoaDon;
        private Rectangle originalTextMaLichKham;
        private Rectangle originalTextTongTien;
        private Rectangle originalTextHinhThucThanhToan;
        private Rectangle originalDataMaHoaDon;
        private Rectangle originalDataMaLichKham;
        private Rectangle originalDataTongTien;
        private Rectangle originalDataHinhThucThanhToan;

        private float textSizeInitialTextMaHoaDon;
        private float textSizeInitialTextMaLichKham;
        private float textSizeInitialTextTongTien;
        private float textSizeInitialTextHinhThucThanhToan;
        private float textSizeInitialDataMaHoaDon;
        private float textSizeInitialDataMaLichKham;
        private float textSizeInitialDataTongTien;
        private float textSizeInitialDataHinhThucThanhToan;

        public DataHoaDon()
        {
            InitializeComponent();

            originalForm = new Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height);
            originalTextMaHoaDon = new Rectangle(textMaHoaDon.Location.X, textMaHoaDon.Location.Y, textMaHoaDon.Width, textMaHoaDon.Height);
            originalTextMaLichKham = new Rectangle(textMaLichKham.Location.X, textMaLichKham.Location.Y, textMaLichKham.Width, textMaLichKham.Height);
            originalTextTongTien = new Rectangle(textTongTien.Location.X, textTongTien.Location.Y, textTongTien.Width, textTongTien.Height);
            originalTextHinhThucThanhToan = new Rectangle(textHinhThucThanhToan.Location.X, textHinhThucThanhToan.Location.Y, textHinhThucThanhToan.Width, textHinhThucThanhToan.Height);
            originalDataMaHoaDon = new Rectangle(dataMaHoaDon.Location.X, dataMaHoaDon.Location.Y, dataMaHoaDon.Width, dataMaHoaDon.Height);
            originalDataMaLichKham = new Rectangle(dataMaLichKham.Location.X, dataMaLichKham.Location.Y, dataMaLichKham.Width, dataMaLichKham.Height);
            originalDataTongTien = new Rectangle(dataTongTien.Location.X, dataTongTien.Location.Y, dataTongTien.Width, dataTongTien.Height);
            originalDataHinhThucThanhToan = new Rectangle(dataHinhThucThanhToan.Location.X, dataHinhThucThanhToan.Location.Y, dataHinhThucThanhToan.Width, dataHinhThucThanhToan.Height);

            textSizeInitialTextMaHoaDon = textMaHoaDon.Font.Size;
            textSizeInitialTextMaLichKham = textMaLichKham.Font.Size;
            textSizeInitialTextTongTien = textTongTien.Font.Size;
            textSizeInitialTextHinhThucThanhToan = textHinhThucThanhToan.Font.Size;
            textSizeInitialDataMaHoaDon = dataMaHoaDon.Font.Size;
            textSizeInitialDataMaLichKham = dataMaLichKham.Font.Size;
            textSizeInitialDataTongTien = dataTongTien.Font.Size;
            textSizeInitialDataHinhThucThanhToan = dataHinhThucThanhToan.Font.Size;
        }

        private void DataHoaDon_Resize(object sender, EventArgs e)
        {
            Graphic.ScaleSize.Resize(originalForm, originalTextMaHoaDon, textMaHoaDon, this, textSizeInitialTextMaHoaDon);
            Graphic.ScaleSize.Resize(originalForm, originalTextMaLichKham, textMaLichKham, this, textSizeInitialTextMaLichKham);
            Graphic.ScaleSize.Resize(originalForm, originalTextTongTien, textTongTien, this, textSizeInitialTextTongTien);
            Graphic.ScaleSize.Resize(originalForm, originalTextHinhThucThanhToan, textHinhThucThanhToan, this, textSizeInitialTextHinhThucThanhToan);
            Graphic.ScaleSize.Resize(originalForm, originalDataMaHoaDon, dataMaHoaDon, this, textSizeInitialDataMaHoaDon);
            Graphic.ScaleSize.Resize(originalForm, originalDataMaLichKham, dataMaLichKham, this, textSizeInitialDataMaLichKham);
            Graphic.ScaleSize.Resize(originalForm, originalDataTongTien, dataTongTien, this, textSizeInitialDataTongTien);
            Graphic.ScaleSize.Resize(originalForm, originalDataHinhThucThanhToan, dataHinhThucThanhToan, this, textSizeInitialDataHinhThucThanhToan);
            
        }
    }
}
