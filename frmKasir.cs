using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKSProvFullSoft
{
    public partial class frmKasir : Form
    {
        private sqlComp comp = new sqlComp();
        private DataTable dtMenu;
        private int hargaBarang;
        private int TotalHarga;
        private int count = 0;

        public frmKasir()
        {
            InitializeComponent();
        }

        private void frmKasir_Load(object sender, EventArgs e)
        {
            FormRefresh();
        }

        private void FormRefresh()
        {
            cbMenu.Region = new Region(new Rectangle(1, 1, cbMenu.Width - 2, cbMenu.Height - 2));
            AddDataToCbMenu();
            tbClear();
            dgvKeranjang.Rows.Clear();
            tbQty.Enabled = false;
            pnlAdd.Enabled = false;
            TotalHarga = 0;
            lblTotalBayar.Text = "Rp. 0";
            lblKembalian.Text = "Rp. 0";
            tbHarga.Text = "";
        }

        public void AddDataToCbMenu()
        {
            dtMenu = comp.GetSql("select id_barang, kode_barang, nama_barang, harga_satuan from tbl_barang order by id_barang");
            if (dtMenu.Rows.Count > 0)
            {
                cbMenu.Items.Clear();
                foreach (DataRow row in dtMenu.Rows)
                {
                    var kode = row[1].ToString();
                    var nama = row[2].ToString();

                    cbMenu.Items.Add($"{kode} - {nama}");
                }
            }
        }

        public void tbClear()
        {
            tbQty.Text = "";
            tbTotalHarga.Text = "";
        }

        public bool inputValidate()
        {
            if (tbQty.Text == "")
            {
                MessageBox.Show("Input harus di isi", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        private void cbMenu_SelectedValueChanged(object sender, EventArgs e)
        {
            int menuIndex = cbMenu.SelectedIndex;
            if (dtMenu.Rows.Count > 0)
            {
                var IdBarang = dtMenu.Rows[menuIndex][0].ToString();
                hargaBarang = int.Parse(dtMenu.Rows[menuIndex][3].ToString());
                tbKodeBarang.Text = dtMenu.Rows[menuIndex][1].ToString();
                tbIdBarang.Text = IdBarang;
                tbNamaMenu.Text = dtMenu.Rows[menuIndex][2].ToString();
                tbHargaSatuan.Text = $"Rp. {hargaBarang.ToString("#,0")}";
                tbQty.Enabled = true;
                pnlAdd.Enabled = true;
            }
        }

        public void getTotal()
        {
            int total = 0;
            if (dgvKeranjang.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvKeranjang.Rows)
                {
                    int subTotal = int.Parse(row.Cells["subtotalx"].Value.ToString());
                    total += subTotal;
                }
            }
            else
            {
                total = 0;
            }
            TotalHarga = total;
            lblTotalBayar.Text = $"Rp. {TotalHarga:#,0}";
        }

        public string IDTransaksi()
        {
            string idTransaksi;
            int Increment;
            int lastdgvindex = dgvKeranjang.Rows.Count - 1;
            DataTable dt = new DataTable();
            dt = comp.GetSql("select no_transaksi from tbl_transaksi order by no_transaksi desc");
            if (dt.Rows.Count > 0 && dgvKeranjang.Rows.Count > 0)
            {
                var id = dgvKeranjang.Rows[lastdgvindex].Cells["idTransaksi"].Value.ToString();
                Increment = int.Parse(id.Substring(2)) + 1;
                idTransaksi = $"TR{Increment:000}";
            }
            else if (dt.Rows.Count == 0 && dgvKeranjang.Rows.Count > 0)
            {
                var id = dgvKeranjang.Rows[lastdgvindex].Cells["idTransaksi"].Value.ToString();
                Increment = int.Parse(id.Substring(2)) + 1;
                idTransaksi = $"TR{Increment:000}";
            }
            else if (dt.Rows.Count > 0 && dgvKeranjang.Rows.Count == 0)
            {
                var id = dt.Rows[0][0].ToString();
                Increment = int.Parse(id.Substring(2)) + 1;
                idTransaksi = $"TR{Increment:000}";
            }
            else
            {
                idTransaksi = "TR001";
            }
            return idTransaksi;
        }

        public void AddToKeranjang()
        {
            //exact value
            string idTransaksi = IDTransaksi();
            string idBarang = tbIdBarang.Text;
            string kodeBarang = tbKodeBarang.Text;
            string namaBarang = tbNamaMenu.Text;
            string hargaSatuan = tbHargaSatuan.Text;
            string qty = tbQty.Text;
            string subtotal = tbTotalHargax.Text;

            //formatted
            string subtotalx = tbTotalHarga.Text;

            bool result = false;

            if (dgvKeranjang.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvKeranjang.Rows)
                {
                    if (row.Cells["kodeBarang"].Value.ToString().Contains(kodeBarang))
                    {
                        row.Cells["qty"].Value = qty;
                        row.Cells["subtotal"].Value = subtotalx;
                        row.Cells["subtotalx"].Value = subtotal;
                        result = true;
                        break;
                    }
                }
            }
            if (!result)
            {
                dgvKeranjang.Rows.Add(idTransaksi, idBarang, kodeBarang, namaBarang, hargaSatuan, qty, subtotalx, subtotal);
            }
        }

        private void tbQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbQty_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbQty.Text)) return;

            UInt64 qty = UInt64.Parse(tbQty.Text);
            UInt64 total = (UInt64)hargaBarang * qty;
            tbTotalHarga.Text = $"Rp. {total:#,0}";
            tbTotalHargax.Text = total.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbClear();

            count++;

            if (count == 3)
            {
                var message = MessageBox.Show("Anda Yakin Ingin Menghapus Seluruh Keranjang?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (message == DialogResult.Yes)
                {
                    dgvKeranjang.Rows.Clear();
                }
                count = 0;
            }
        }

        public void Save()
        {
            if (dgvKeranjang.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvKeranjang.Rows)
                {
                    string no_transaksi = row.Cells["idTransaksi"].Value.ToString();
                    string tgl_transaksi = DateTime.Today.ToString("yyyy-MM-dd");
                    string total_bayar = row.Cells["subtotalx"].Value.ToString();
                    string id_user = Gv.uid;
                    string id_barang = row.Cells["idBarang"].Value.ToString();

                    string sql = $"insert into tbl_transaksi (no_transaksi, tgl_transaksi, total_bayar, id_user, id_barang) values ('{no_transaksi}', '{tgl_transaksi}', {total_bayar}, {id_user}, {id_barang})";

                    if (comp.SetSql(sql))
                    {
                        MessageBox.Show("Pembayaran Berhasil", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }
            FormRefresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!inputValidate()) return;
            AddToKeranjang();
            getTotal();
            if (dgvKeranjang.Rows.Count == 0) return;
            tbHarga.Enabled = true;
        }

        private void dgvKeranjang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void tbHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            if (tbHarga.Text == "") return;
            int total = TotalHarga;
            int bayar = int.Parse(tbHarga.Text);

            if (bayar < total)
            {
                MessageBox.Show("Pembayaran Kurang", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            int kembalian = bayar - total;
            lblKembalian.Text = $"Rp.{kembalian:#,0}";
            btnSimpan.Enabled = true;
            btnPrint.Enabled = true;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            Save();
            frmKasir_Load(null, EventArgs.Empty);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            comp.SetSql($"INSERT INTO tbl_log (aktivitas, id_user) VALUES ('Logout', {Gv.uid});");
            Application.Restart();
        }
    }
}