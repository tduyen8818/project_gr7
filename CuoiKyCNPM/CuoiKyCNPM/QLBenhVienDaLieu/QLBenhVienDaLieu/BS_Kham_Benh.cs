﻿using QLBenhVienDaLieu.Database.Class;
using QLBenhVienDaLieu.Database.Function;
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
    public partial class BS_Kham_Benh : Form
    {
        private string sDT;

        public BS_Kham_Benh(string sDT)
        {
            InitializeComponent();
            this.sDT = sDT;
            dt_ngayKham.Value = DateTime.Now;
            dt_ngayKham.MaxDate = dt_ngayKham.Value;
            //Change column display size
            dgv_lichKham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgv_lichKham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgv_lichKham.ReadOnly = true;
        }

        public BS_Kham_Benh()
        {
            InitializeComponent();
            this.sDT = "";
            dt_ngayKham.Value = DateTime.Now;
            dt_ngayKham.MaxDate = dt_ngayKham.Value;
            //Change column display size
            dgv_lichKham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgv_lichKham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgv_lichKham.ReadOnly = true;
        }

        private void BS_Kham_Benh_Load(object sender, EventArgs e)
        {

        }

        DataTable resultTable = new DataTable();
        private void SelectedValue(object sender, EventArgs e)
        {
            dgv_lichKham.ReadOnly = false;
            if (cb_caKham.SelectedIndex != -1)
            {
                string ngay = dt_ngayKham.Value.Date.ToString("yyyy-MM-dd");
                string ca = cb_caKham.SelectedItem.ToString();
                SqlFunctionCaller funcCall = new SqlFunctionCaller();

                try
                {
                    resultTable = funcCall.CallGetLichKhamByNgayAndCa(ngay, ca);
                    dgv_lichKham.DataSource = resultTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            dgv_lichKham.ReadOnly = true;
        }

        private void BS_Kham_Benh_Resize(object sender, EventArgs e)
        {
            //Change column display size
            int lastCol = resultTable.Columns.Count;
            if (this.WindowState == FormWindowState.Maximized && dgv_lichKham.Rows.Count !=0)
            {
                dgv_lichKham.Columns[lastCol - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else if (dgv_lichKham.Rows.Count != 0)
            {
                dgv_lichKham.Columns[lastCol - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
        }

        private void dgv_lichKham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgv_lichKham.Rows[e.RowIndex];
                string maHoSoBenhNhan = selectedRow.Cells["MaHoSoBenhNhan"].Value.ToString();
                string maLichKham = selectedRow.Cells["MaLichKham"].Value.ToString();

                // Open BS_Kham_Benh_2 and call the method to pass the data
                BS_Kham_Benh_2 hsbn = new BS_Kham_Benh_2();
                hsbn.SetMaHoSoBenhNhan(maHoSoBenhNhan, maLichKham, this.WindowState, sDT);
                hsbn.FormClosed += (s, args) => this.Show();
                hsbn.Show();
                this.Hide();
            }
        }

        private void btn_DichVu_Click(object sender, EventArgs e)
        {

        }

        TaiKhoan_BS taiKhoanForm;
        LichLamViec_BS lichLamViec;

        private void btn_LichLamViec_Click(object sender, EventArgs e)
        {
            if (lichLamViec == null || lichLamViec.IsDisposed)
            {
                lichLamViec = new LichLamViec_BS(sDT);
                lichLamViec.FormClosed += (s, args) => this.Close();
                this.Hide();
                lichLamViec.Show();
            }
            if (IsFormHidden(lichLamViec))
            {
                this.Hide();
                lichLamViec.Show();
            }
        }

        private void btn_taiKhoan_Click(object sender, EventArgs e)
        {
            if (taiKhoanForm == null || taiKhoanForm.IsDisposed)
            {
                taiKhoanForm = new TaiKhoan_BS(sDT);
                taiKhoanForm.FormClosed += (s, args) => this.Close();
                this.Hide();
                taiKhoanForm.Show();
            }
            if (IsFormHidden(taiKhoanForm))
            {
                this.Hide();
                taiKhoanForm.Show();
            }
        }

        private bool IsFormHidden(Form form)
        {
            return form != null && form.Visible && !form.Focused;
        }
    }
}
