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
        private sqlComp comp = new sqlComp();
        private int hargaBarang;
        private DataTable dt = new DataTable();

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
            dtpExpired.Region = new Region(new Rectangle(1, 1, dtpExpired.Width - 2, dtpExpired.Height - 2));
            AddData("Select * from tbl_barang");
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
            tbHargaSatuan.Text = "";
            dtpExpired.Value = DateTime.Now;
        }

        private void tbHargaSatuan_Leave(object sender, EventArgs e)
        {
            if (tbHargaSatuan.Text == "") return;
            hargaBarang = int.Parse(tbHargaSatuan.Text);
            string value = hargaBarang.ToString("#,0");
            tbHargaSatuan.Text = $"Rp. {value}";
        }

        public void AddData(string query)
        {
            dt = comp.GetSql(query);
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

        public bool InputValidate()
        {
            bool result = false;
            if (tbKodeBarang.Text == "" || tbNamaBarang.Text == "" || dtpExpired.Value == DateTime.Today || tbJumlahBarang.Text == "" || cbSatuan.SelectedItem == "" || tbHargaSatuan.Text == "")
            {
                MessageBox.Show("Input Harus Di Isi", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                result = true;
            }
            return result;
        }

        public bool Controller(string status)
        {
            bool result = false;
            switch (status)
            {
                case "insert":
                    if (InputValidate()) return false;
                    result = comp.SetSql($"insert into tbl_barang (kode_barang,nama_barang,expired_date,jumlah_barang,satuan,harga_satuan) values ('{tbKodeBarang.Text}', '{tbNamaBarang.Text}', '{dtpExpired.Value.ToString("yyyy-MM-dd")}', {tbJumlahBarang.Text}, '{cbSatuan.SelectedItem}', {hargaBarang} )");
                    break;

                case "update":
                    if (InputValidate()) return false;
                    result = comp.SetSql($"update tbl_barang set kode_barang = '{tbKodeBarang.Text}', nama_barang = '{tbNamaBarang.Text}', expired_date = '{dtpExpired.Value}', jumlah_barang = {tbJumlahBarang.Text}, satuan = '{cbSatuan.SelectedItem}', harga_satuan = {hargaBarang} where id_barang = {tbIdBarang.Text}");
                    break;

                case "delete":
                    result = comp.SetSql($"delete from tbl_barang where id_barang = {tbIdBarang.Text}");
                    break;

                case "search":
                    AddData($"select * from tbl_barang where id_barang like '%{tbSearch.Text}%' or kode_barang like '%{tbSearch.Text}%' or nama_barang like '%{tbSearch.Text}%' or expired_date like '%{tbSearch.Text}%' or jumlah_barang like '%{tbSearch.Text}%' or satuan like '%{tbSearch.Text}%' or harga_satuan like '%{tbSearch.Text}%'");
                    result = true;
                    break;
            }
            if (result = true)
            {
                MessageBox.Show("Berhasil", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
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
            Gv.status = "insert";
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
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dgvBarang_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvBarang.Rows.Count > 0)
            {
                int x = dgvBarang.CurrentCell.RowIndex;
                tbIdBarang.Text = dt.Rows[x][0].ToString();
                tbKodeBarang.Text = dt.Rows[x][1].ToString();
                tbNamaBarang.Text = dt.Rows[x][2].ToString();
                dtpExpired.Value = (DateTime)dt.Rows[x][3];
                tbJumlahBarang.Text = dt.Rows[x][4].ToString();
                cbSatuan.SelectedItem = dt.Rows[x][5].ToString();
                tbHargaSatuan.Text = dt.Rows[x][6].ToString();
                pnlEdit.Enabled = true;
                pnlDelete.Enabled = true;
            }
        }

        private void tbSearch_Leave(object sender, EventArgs e)
        {
            if (tbSearch.Text != "") return;
            tbSearch.Text = "Cari Nama Barang";
        }

        private void tbSearch_Enter(object sender, EventArgs e)
        {
            if (tbSearch.Text != "Cari Nama Barang") return;
            tbSearch.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            InputState(false, true);
            Gv.status = "update";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Apa Kammu Yakin ingin menghapus Data Ini?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (msg == DialogResult.Yes)
            {
                Controller("delete");
                FormRefresh();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Controller(Gv.status);
            FormRefresh();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text == "Cari Nama Barang")
            {
                AddData("Select * from tbl_barang");
            }
            else
            {
                Controller("search");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            comp.SetSql($"INSERT INTO tbl_log (aktivitas, id_user) VALUES ('Logout', {Gv.uid})");
            Application.Restart();
        }

        private void frmGudang_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}