using QLBenhVienDaLieu.Class;
using QLBenhVienDaLieu.Database;
using QLBenhVienDaLieu.Graphic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QLBenhVienDaLieu.GiaoDien.Lich_Kham.XemLichKham
{
    public partial class XemLichKham : Form
    {
        BenhNhan_Trang benhNhan_Trang;

        private string soDienThoai = "0123456789";

        private Rectangle originalForm;
        private Rectangle originalTitle;
        private Rectangle originalDataXemLichKham;
        private SqlFunctionCaller sqlFunctionCaller;

        float textSizeInitialTitle;

        public XemLichKham(SqlFunctionCaller sqlFunctionCaller, BenhNhan_Trang benhNhan_Trang)
        {
            InitializeComponent();

            this.sqlFunctionCaller = sqlFunctionCaller;
            this.benhNhan_Trang = benhNhan_Trang;

            originalForm = new Rectangle(Location.X, Location.Y, this.Width, this.Height);
            originalTitle = new Rectangle(titleXemLich.Location.X, titleXemLich.Location.Y, titleXemLich.Width, titleXemLich.Height);
            DataXemLichKham dataXemLichKhamInitial = new DataXemLichKham(benhNhan_Trang, sqlFunctionCaller);
            originalDataXemLichKham = new Rectangle(dataXemLichKhamInitial.Location.X, dataXemLichKhamInitial.Location.Y, dataXemLichKhamInitial.Width, dataXemLichKhamInitial.Height);

            this.textSizeInitialTitle = titleXemLich.Font.Size;

            List<HoSoBenhNhan> listHoSoBenhNhan = sqlFunctionCaller.GetHoSoBenhNhanByMaTaiKhoanOrSoDienThoai(this.soDienThoai);

            foreach(HoSoBenhNhan hoSoBenhNhan in listHoSoBenhNhan)
            {
                foreach (LichKham lichKham in sqlFunctionCaller.GetLichKhamByMaHoSoBenhNhan(hoSoBenhNhan.MaHoSoBenhNhan))
                {
                    DataXemLichKham dataXemLichKham = new DataXemLichKham(benhNhan_Trang, sqlFunctionCaller);
                    Blank blank = new Blank();
                    ChuyenKhoa chuyenKhoa = sqlFunctionCaller.GetChuyenKhoaByMaChuyenKhoa(lichKham.MaChuyenKhoa);
                    DichVu dichVu = sqlFunctionCaller.GetDichVuByMaDichVu(lichKham.MaDichVu);
                    HoaDon hoaDon = sqlFunctionCaller.GetHoaDonByMaLichKham(lichKham.MaLichKham);


                    dataXemLichKham.TopLevel = false;
                    dataXemLichKham.Dock = DockStyle.Top;

                    dataXemLichKham.DataMaPhieu.Text = lichKham.MaLichKham;
                    dataXemLichKham.DataChuyenKhoa.Text = chuyenKhoa.TenChuyenKhoa;
                    dataXemLichKham.DataName.Text = hoSoBenhNhan.HoVaTen;
                    dataXemLichKham.DataDichVu.Text = dichVu.TenDichVu;

                    if (hoaDon.TongTien == 0)
                    {
                        dataXemLichKham.DataTrangThai.Text = "Chưa thanh toán";
                        dataXemLichKham.DataTrangThai.ForeColor = System.Drawing.Color.Red;
                    }

                    blank.TopLevel = false;
                    blank.Dock = DockStyle.Top;

                    flowLayoutPanel1.Controls.Add(dataXemLichKham);
                    flowLayoutPanel1.Controls.Add(blank);
                    flowLayoutPanel1.Tag = dataXemLichKham;
                    flowLayoutPanel1.Tag = blank;

                    dataXemLichKham.Show();
                    blank.Show();
                }
            }
        }

        private void XemLichKham_Resize(object sender, EventArgs e)
        {

            ScaleSize.Resize(originalForm, originalTitle, titleXemLich, this, textSizeInitialTitle);

            foreach (var dataXemLichKham in flowLayoutPanel1.Controls.OfType<DataXemLichKham>().ToList())
            {
                ScaleSize.Resize(originalForm, originalDataXemLichKham, dataXemLichKham, this);
                dataXemLichKham.Region = Draw.RoundedRectangle(0, 0, dataXemLichKham.Width, dataXemLichKham.Height, 30, 30);
            }
        }
    }
}
