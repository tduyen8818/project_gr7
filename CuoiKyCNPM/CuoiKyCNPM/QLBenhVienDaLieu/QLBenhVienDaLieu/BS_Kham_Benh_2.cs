using QLBenhVienDaLieu.Database.Class;
using QLBenhVienDaLieu.Database.Function;
using QLBenhVienDaLieu.GiaoDien.BenhNhanTrangUI.LichKhamUI.DatLichKhamUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace QLBenhVienDaLieu
{
    public partial class BS_Kham_Benh_2 : Form
    {
        private string sDT;

        private void BS_Kham_Benh_2_Load(object sender, EventArgs e)
        {

        }

        public BS_Kham_Benh_2(string sDT)
        {
            InitializeComponent();
            this.sDT = sDT;
        }

        public BS_Kham_Benh_2()
        {
            InitializeComponent();
            pn_hoSo.Hide();
            dgv_skb.Hide();
            dgv_benhAn.Hide();
            bt_hoSo.Checked = true;
            bt_sua.Hide();
            bt_xoa.Hide();
            bt_them.Hide();
            bt_themToaThuoc.Hide();
            disReadOnlyDGV();
        }
        DataTable hsbn = new DataTable();
        DataTable skb = new DataTable();
        DataTable ba = new DataTable();
        string maHSBN = null;
        string maLK = null;

        public void SetMaHoSoBenhNhan(string maHoSoBenhNhan, string maLichKham, FormWindowState state, string sDT)
        {
            this.sDT = sDT;
            this.WindowState = state;
            SqlFunctionCaller funcCall = new SqlFunctionCaller();
            enaReadOnlyDGV();
            try
            {
                hsbn = funcCall.CallGetHoSoBenhNhan(maHoSoBenhNhan);
                skb = funcCall.CallGetSoKhamBenh(maHoSoBenhNhan, maLichKham);
                ba = funcCall.CallGetBenhAn(maHoSoBenhNhan);
                maHSBN = maHoSoBenhNhan;
                maLK = maLichKham;
                //Thong tin HSBN
                Load_HSBN(hsbn);
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
                //Hide all datagridviews
                dgv_skb.Hide();
                dgv_benhAn.Hide();
                //Hide them sua xoa buttons
                bt_sua.Hide();
                bt_xoa.Hide();
                bt_them.Hide();

                bt_hoSo.Checked = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            disReadOnlyDGV();
        }


        private void Load_HSBN(DataTable hsbn)
        {
            tb_hoVaTen.Text = hsbn.Rows[0][0].ToString();
            tb_maHSBN.Text = hsbn.Rows[0][1].ToString();
            tb_maTK.Text = hsbn.Rows[0][2].ToString();
            DateTime dt = (DateTime)hsbn.Rows[0][3];
            tb_ngaySinh.Text = dt.ToString("dd/MM/yyyy");
            tb_gioiTinh.Text = hsbn.Rows[0][4].ToString();
            tb_cccd.Text = hsbn.Rows[0][5].ToString();
            tb_maBHYT.Text = hsbn.Rows[0][6].ToString();
            tb_nghe.Text = hsbn.Rows[0][7].ToString();
            tb_sdt.Text = hsbn.Rows[0][8].ToString();
            tb_mail.Text = hsbn.Rows[0][9].ToString();
            tb_diaChi.Text = hsbn.Rows[0][10].ToString();
        }

        private void BS_Kham_Benh_2_Resize(object sender, EventArgs e)
        {
            enaReadOnlyDGV();
            int lastCol = skb.Columns.Count;
            if (this.WindowState == FormWindowState.Maximized && dgv_skb.Rows.Count != 0 && dgv_skb.DisplayedColumnCount(false) == dgv_skb.RowCount)
            {
                dgv_skb.Columns[lastCol - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else if (dgv_skb.Rows.Count != 0)
            {
                dgv_skb.Columns[lastCol - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            lastCol = ba.Columns.Count;
            if (this.WindowState == FormWindowState.Maximized && dgv_benhAn.Rows.Count != 0 && dgv_benhAn.DisplayedColumnCount(false) == dgv_benhAn.RowCount)
            {
                dgv_benhAn.Columns[lastCol - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else if (dgv_benhAn.Rows.Count != 0)
            {
                dgv_benhAn.Columns[lastCol - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            disReadOnlyDGV();
        }

        private void dgv_lichKham_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
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
                bt_themToaThuoc.Show();

                dgv_benhAn.Show();
            }
            else
            {
                dgv_benhAn.Hide();
                bt_sua.Hide();
                bt_xoa.Hide();
                bt_them.Hide();
                bt_themToaThuoc.Hide();
            }
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            BS_Them form = new BS_Them();
            if (bt_skb.Checked)
            {
                form.SetForm("skb", maHSBN);
                form.FormClosed += (s, args) => updateSKB_DGV();
                form.Show();
                this.Hide();
            }
            if (bt_benhAn.Checked)
            {
                form.SetForm("ba", maHSBN);
                form.FormClosed += (s, args) => updateBA_DGV();
                form.Show();
                this.Hide();
            }
        }
        private void bt_sua_Click(object sender, EventArgs e)
        {
            BS_Sua form = new BS_Sua();
            DataGridViewRow selectedRow = new DataGridViewRow();
            if (bt_skb.Checked && dgv_skb.Rows.Count != 0)
            {
                if (dgv_skb.SelectedRows.Count > 0)
                {
                    selectedRow = dgv_skb.SelectedRows[0];

                    form.SetForm("skb", selectedRow);
                    form.FormClosed += (s, args) => updateSKB_DGV();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu được chọn");
                }
            }
            else if (bt_benhAn.Checked && dgv_benhAn.Rows.Count != 0)
            {
                if (dgv_benhAn.SelectedRows.Count > 0)
                {
                    selectedRow = dgv_benhAn.SelectedRows[0];

                    form.SetForm("ba", selectedRow);
                    form.FormClosed += (s, args) => updateBA_DGV();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu được chọn");
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu nào trong bảng");
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (bt_skb.Checked && dgv_skb.Rows.Count != 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sổ khám bệnh này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dgv_skb.SelectedRows[0];
                    SqlFunctionCaller funcCall = new SqlFunctionCaller();
                    funcCall.DeleteSoKhamBenh(selectedRow.Cells["MaLichKham"].Value.ToString());
                    updateSKB_DGV();
                    MessageBox.Show("Xóa thành công");
                }

            }
            else if (bt_benhAn.Checked && dgv_benhAn.Rows.Count != 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sổ khám bệnh này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dgv_benhAn.SelectedRows[0];
                    SqlFunctionCaller funcCall = new SqlFunctionCaller();
                    funcCall.DeleteRecordByMaBenhAn(selectedRow.Cells["MaBenhAn"].Value.ToString());
                    updateBA_DGV();
                    MessageBox.Show("Xóa thành công");
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu nào trong bảng");
            }
        }

        private void bt_themToaThuoc_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgv_benhAn.SelectedRows[0];

            BS_ThemToaThuoc themTT = new BS_ThemToaThuoc();
            themTT.FormClosed += (s, args) => this.Show();
            themTT.SetInfo(selectedRow.Cells["MaBenhAn"].Value.ToString());
            themTT.Show();
            this.Hide();
        }

        private void updateSKB_DGV()
        {
            enaReadOnlyDGV();
            SqlFunctionCaller funcCall = new SqlFunctionCaller();
            skb = funcCall.CallGetSoKhamBenh(maHSBN, maLK);
            dgv_skb.DataSource = skb;
            this.Show();
            disReadOnlyDGV();
        }

        private void updateBA_DGV()
        {
            enaReadOnlyDGV();
            SqlFunctionCaller funcCall = new SqlFunctionCaller();
            ba = funcCall.CallGetBenhAn(maHSBN);
            dgv_benhAn.DataSource = ba;
            this.Show();
            disReadOnlyDGV();
        }


        private void dgv_skb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow selectedRow = dgv_skb.Rows[e.RowIndex];
            //    string maHoSoBenhNhan = selectedRow.Cells["MaHoSoBenhNhan"].Value.ToString();
            //    string maLichKham = selectedRow.Cells["MaLichKham"].Value.ToString();

            //    // Open the second form and call the method to pass the data
            //    BS_Kham_Benh_2 hsbn = new BS_Kham_Benh_2();
            //    hsbn.SetMaHoSoBenhNhan(maHoSoBenhNhan, maLichKham, this.WindowState);
            //    hsbn.FormClosed += (s, args) => this.Show();
            //    hsbn.Show();
            //    this.Hide();
            //}
        }

        private void dgv_benhAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow selectedRow = dgv_benhAn.Rows[e.RowIndex];
            //    string maHoSoBenhNhan = selectedRow.Cells["MaHoSoBenhNhan"].Value.ToString();
            //    string maLichKham = selectedRow.Cells["MaLichKham"].Value.ToString();

            //    // Open the second form and call the method to pass the data
            //    BS_Kham_Benh_2 hsbn = new BS_Kham_Benh_2();
            //    hsbn.SetMaHoSoBenhNhan(maHoSoBenhNhan, maLichKham, this.WindowState);
            //    hsbn.FormClosed += (s, args) => this.Show();
            //    hsbn.Show();
            //    this.Hide();
            //}
        }

        private void enaReadOnlyDGV()
        {
            dgv_skb.ReadOnly = true;
            dgv_benhAn.ReadOnly = true;
        }

        private void disReadOnlyDGV()
        {
            dgv_skb.ReadOnly = false;
            dgv_benhAn.ReadOnly = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TaiKhoan_BS taiKhoanForm = new TaiKhoan_BS(sDT);
            this.Hide();
            taiKhoanForm.ShowDialog();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LichLamViec_BS lichLamViec = new LichLamViec_BS(sDT);
            this.Hide();
            lichLamViec.ShowDialog();
            this.Close();
        }
    }
}
