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
    public partial class BS_Kham_Benh_2 : Form
    {
        public BS_Kham_Benh_2()
        {
            InitializeComponent();
            pn_hoSo.Hide();
            dgv_skb.Hide();
            dgv_benhAn.Hide();
            bt_sua.Hide();
            bt_xoa.Hide();
            bt_them.Hide();
        }
        DataTable hsbn = new DataTable();
        DataTable skb = new DataTable();
        DataTable ba = new DataTable();
        public void SetMaHoSoBenhNhan(string maHoSoBenhNhan, string maLichKham, FormWindowState state)
        {
            this.WindowState = state;
            SqlFunctionCaller funcCall = new SqlFunctionCaller();

            try
            {
                hsbn = funcCall.CallGetHoSoBenhNhan(maHoSoBenhNhan);
                skb = funcCall.CallGetSoKhamBenh(maHoSoBenhNhan, maLichKham);
                ba = funcCall.CallGetBenhAn(maHoSoBenhNhan);
                //Table so kham benh
                dgv_skb.DataSource = skb;
                //Change column display size
                dgv_skb.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dgv_skb.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                //Table benh an
                dgv_benhAn.DataSource = ba;
                //Change column display size
                dgv_benhAn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dgv_benhAn.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                //Hide all displays
                pn_hoSo.Hide();
                dgv_skb.Hide();
                dgv_benhAn.Hide();
                //Hide them sua xoa buttons
                bt_sua.Hide();
                bt_xoa.Hide();
                bt_them.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BS_Kham_Benh_2_Resize(object sender, EventArgs e)
        {
            int lastCol = skb.Columns.Count;
            if (this.WindowState == FormWindowState.Maximized && dgv_skb.Rows.Count != 0)
            {
                dgv_skb.Columns[lastCol - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else if (dgv_skb.Rows.Count != 0)
            {
                dgv_skb.Columns[lastCol - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            lastCol = ba.Columns.Count;
            if (this.WindowState == FormWindowState.Maximized && dgv_benhAn.Rows.Count != 0)
            {
                dgv_benhAn.Columns[lastCol - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else if (dgv_benhAn.Rows.Count != 0)
            {
                dgv_benhAn.Columns[lastCol - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
        }

        private void BS_Kham_Benh_2_Load(object sender, EventArgs e)
        {

        }

        private void dgv_lichKham_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgv_skb.Rows[e.RowIndex];
                string cellValue = selectedRow.Cells["ColumnName"].Value.ToString();

            }
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BS_Kham_Benh_2_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void bt_hoSo_CheckedChanged(object sender, EventArgs e)
        {
            if (bt_hoSo.Checked)
            {
                //Uncheck other buttons
                bt_skb.Checked = false;
                bt_benhAn.Checked = false;

                pn_hoSo.Show();
            }
            else
            {
                pn_hoSo.Hide();
            }
        }

        private void bt_skb_CheckedChanged(object sender, EventArgs e)
        {
            if (bt_skb.Checked)
            {
                //Uncheck other buttons
                bt_hoSo.Checked = false;
                bt_benhAn.Checked = false;
                //Show them sua xoa buttons
                bt_sua.Show();
                bt_xoa.Show();
                bt_them.Show();

                dgv_skb.Show();
            }
            else
            {
                dgv_skb.Hide();
                bt_sua.Hide();
                bt_xoa.Hide();
                bt_them.Hide();
            }
        }

        private void bt_benhAn_CheckedChanged(object sender, EventArgs e)
        {
            if (bt_benhAn.Checked)
            {
                //Uncheck other buttons
                bt_hoSo.Checked = false;
                bt_skb.Checked = false;
                //Show them sua xoa buttons
                bt_sua.Show();
                bt_xoa.Show();
                bt_them.Show();

                dgv_benhAn.Show();
            }
            else
            {
                dgv_benhAn.Hide();
                bt_sua.Hide();
                bt_xoa.Hide();
                bt_them.Hide();
            }
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            if (bt_skb.Checked)
            {

            }
            if (bt_benhAn.Checked)
            {

            }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (bt_skb.Checked && dgv_skb.Rows.Count != 0)
            {

            }
            if (bt_benhAn.Checked && dgv_benhAn.Rows.Count != 0)
            {

            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (bt_skb.Checked && dgv_skb.Rows.Count != 0)
            {

            }
            if (bt_benhAn.Checked && dgv_benhAn.Rows.Count != 0)
            {

            }
        }

        private void dgv_skb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgv_skb.Rows[e.RowIndex];
                string maHoSoBenhNhan = selectedRow.Cells["MaHoSoBenhNhan"].Value.ToString();
                string maLichKham = selectedRow.Cells["MaLichKham"].Value.ToString();

                // Open the second form and call the method to pass the data
                BS_Kham_Benh_2 hsbn = new BS_Kham_Benh_2();
                hsbn.SetMaHoSoBenhNhan(maHoSoBenhNhan, maLichKham, this.WindowState);
                hsbn.FormClosed += (s, args) => this.Show();
                hsbn.Show();
                this.Hide();
            }
        }

        private void dgv_benhAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgv_benhAn.Rows[e.RowIndex];
                string maHoSoBenhNhan = selectedRow.Cells["MaHoSoBenhNhan"].Value.ToString();
                string maLichKham = selectedRow.Cells["MaLichKham"].Value.ToString();

                // Open the second form and call the method to pass the data
                BS_Kham_Benh_2 hsbn = new BS_Kham_Benh_2();
                hsbn.SetMaHoSoBenhNhan(maHoSoBenhNhan, maLichKham, this.WindowState);
                hsbn.FormClosed += (s, args) => this.Show();
                hsbn.Show();
                this.Hide();
            }
        }
    }
}
