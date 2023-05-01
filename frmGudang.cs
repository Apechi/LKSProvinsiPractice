using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace LKSProvFullSoft
{
    public partial class frmGudang : Form
    {
        sqlComp comp = new sqlComp();
        int hargaBarang;
        DataTable dt = new DataTable();

        public frmGudang()
        {
            InitializeComponent();
        }

        private void frmGudang_Load(object sender, EventArgs e)
        {
            FormRefresh();
        }

        private void FormRefresh()
        {
            cbSatuan.Region = new Region(new Rectangle(1, 1, cbSatuan.Width - 2, cbSatuan.Height - 2));
            AddData();
            pnlEdit.Enabled = false;
            pnlDelete.Enabled = false;
            InputState(true, false);
            ClearTB();
        }

        public void InputState(bool main, bool sc)
        {
            pnlInsert.Visible = main;
            pnlEdit.Visible = main;
            pnlDelete.Visible = main;

            pnlSave.Visible = sc;
            pnlCancel.Visible = sc;
            gbInput.Enabled = sc;
        }

        public void ClearTB()
        {
            tbKodeBarang.Text = "";
            tbNamaBarang.Text = "";
            tbJumlahBarang.Text = "";
            cbSatuan.SelectedItem = "";
            dtpExpired.Value = DateTime.Now;
        }

        private void tbHargaSatuan_Leave(object sender, EventArgs e)
        {
            if (tbHargaSatuan.Text == "") return;
            hargaBarang = int.Parse(tbHargaSatuan.Text);
            string value = hargaBarang.ToString("#,0");
            tbHargaSatuan.Text = $"Rp. {value}";
        }

        public void AddData()
        {
            
            dt = comp.GetSql("Select * from tbl_barang");
            dgvBarang.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                int id = (int)row[0];
                var kode = row[1].ToString();
                var nama = row[2].ToString();
                var expired = (DateTime)row[3];
                var jumlah = row[4].ToString();
                var satuan = row[5].ToString();
                var harga = int.Parse(row[6].ToString());

                //converter
                string idx = $"BRG{id:00}";
                string expiredx = expired.ToString("dd/MM/yyyy");
                string hargax = $"RP. {harga.ToString("#,0")}";

                dgvBarang.Rows.Add(idx, kode, nama, expiredx, jumlah, satuan, hargax);

            }
        }

        private void tbHargaSatuan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbHargaSatuan_Enter(object sender, EventArgs e)
        {
            tbHargaSatuan.Text = "";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            ClearTB();
            InputState(false, true);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormRefresh();
        }

        private void tbJumlahBarang_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbNamaBarang_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dgvBarang_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvBarang.Rows.Count > 0)
            {
                int x = dgvBarang.CurrentCell.RowIndex;
                tbKodeBarang.Text = dt.Rows[x][1].ToString();
                tbHargaSatuan.Text = dt.Rows[x][6].ToString();
            }
        }
    }
}
