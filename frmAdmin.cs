using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKSProvFullSoft
{
    public partial class frmAdmin : Form
    {
        private sqlComp comp = new sqlComp();
        private DataTable dt;
        private DataTable dtActivity;

        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            dgvActivity.ReadOnly = Enabled;
            dgvReport.ReadOnly = Enabled;
            dgvUser.ReadOnly = Enabled;
            FormRefresh("activity");
        }

        public void FormRefresh(string form)
        {
            switch (form)
            {
                case "user":
                    pnlUser.Visible = true;
                    pnlActivity.Visible = false;
                    pnlLaporan.Visible = false;
                    PanelUserInit();
                    break;

                case "activity":
                    pnlActivity.Visible = true;
                    pnlUser.Visible = false;
                    pnlLaporan.Visible = false;
                    PanelActivityInit();
                    break;

                case "laporan":
                    pnlLaporan.Visible = true;
                    pnlUser.Visible = false;
                    pnlActivity.Visible = false;
                    PanelLaporanInit();
                    break;
            }
        }

        // PANEL USER FUNCTIONALITY

        private void PanelUserInit()
        {
            ClearTB();
            InputState(true, false);
            AddDataToUserDgv("select * from tbl_user order by id_user asc");
            pnlDelete.Enabled = false;
            pnlEdit.Enabled = false;
            cbTipeUser.Region = new Region(new Rectangle(1, 1, cbTipeUser.Width - 2, cbTipeUser.Height - 3));
        }

        public void AddDataToUserDgv(string query)
        {
            dt = new DataTable();
            dt = comp.GetSql(query);
            dgvUser.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                string id = row[0].ToString();
                string tipe = row[1].ToString();
                string nama = row[2].ToString();
                string alamat = row[3].ToString();
                string telepon = row[4].ToString();

                dgvUser.Rows.Add(id, tipe, nama, alamat, telepon);
            }
            if (dgvUser.Rows[0].Cells[1].Value.ToString().Contains("Admin"))
            {
                dgvUser.Rows[0].Visible = false;
            }
        }

        public bool InputValidate()
        {
            bool result = true;
            if (tbNama.Text == "" || tbAlamat.Text == "" || tbTelepon.Text == "" || tbUsername.Text == "" || tbPassword.Text == "" || string.IsNullOrEmpty(cbTipeUser.SelectedItem.ToString()))
            {
                MessageBox.Show("Input Harus di Isi!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                result = false;
            }
            return result;
        }

        public bool Controller(string status)
        {
            bool result = false;

            switch (status)
            {
                case "insert":
                    if (InputValidate())
                        result = comp.SetSql($"INSERT INTO [dbo].[tbl_user] ([tipe_user] ,[nama] ,[alamat],[telpon] ,[username],[password]) VALUES ('{cbTipeUser.SelectedItem}', '{tbNama.Text}', '{tbAlamat.Text}', '{tbTelepon.Text}', '{tbUsername.Text}', '{tbPassword.Text}' )");
                    break;

                case "update":
                    if (InputValidate())
                        result = comp.SetSql($"UPDATE [dbo].[tbl_user] SET [tipe_user] = '{cbTipeUser.SelectedItem}' ,[nama] = '{tbNama.Text}',[alamat] = '{tbAlamat.Text}' ,[telpon] = '{tbTelepon.Text}' ,[username] = '{tbUsername.Text}' , [password] = '{tbPassword.Text}' WHERE id_user = '{tbUserId.Text}'");
                    break;

                case "delete":
                    if (InputValidate())
                        result = comp.SetSql($"delete from tbl_user where id_user = '{tbUserId.Text}'");
                    break;

                case "search":
                    AddDataToUserDgv($"select * from tbl_user where id_user like '%{tbSearch.Text}%' OR tipe_user like '%{tbSearch.Text}%' or nama like '%{tbSearch.Text}%' or alamat like '%{tbSearch.Text}%' or telpon like '%{tbSearch.Text}%' or username like '%{tbSearch.Text}%' or password like '%{tbSearch.Text}%'");
                    result = true;
                    break;
            }

            if (result)
            {
                MessageBox.Show("Berhasil", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }

        public void InputState(bool main, bool sc)
        {
            pnlInsert.Visible = main;
            pnlEdit.Visible = main;
            pnlDelete.Visible = main;

            gbInput.Enabled = sc;
            pnlSave.Visible = sc;
            pnlCancel.Visible = sc;
        }

        public void ClearTB()
        {
            tbNama.Text = "";
            tbAlamat.Text = "";
            tbTelepon.Text = "";
            tbUsername.Text = "";
            tbPassword.Text = "";
        }

        private void tbNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbTelepon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void pnlUser_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            InputState(false, true);
            ClearTB();
            Gv.status = "insert";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            PanelUserInit();
        }

        private void dgvUser_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvUser.Rows.Count > 0)
            {
                int x = dgvUser.CurrentCell.RowIndex;
                tbUserId.Text = dgvUser.Rows[x].Cells[0].Value.ToString();
                cbTipeUser.SelectedItem = dgvUser.Rows[x].Cells[1].Value.ToString();
                tbNama.Text = dgvUser.Rows[x].Cells[2].Value.ToString();
                tbAlamat.Text = dgvUser.Rows[x].Cells[3].Value.ToString();
                tbTelepon.Text = dgvUser.Rows[x].Cells[4].Value.ToString();
                tbUsername.Text = dt.Rows[x][5].ToString();
                tbPassword.Text = dt.Rows[x][6].ToString();
                pnlEdit.Enabled = true;
                pnlDelete.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Controller(Gv.status);
            PanelUserInit();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            InputState(false, true);
            Gv.status = "update";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var validate = MessageBox.Show("Yakin ingin hapus data?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (validate == DialogResult.Yes)
            {
                Controller("delete");
            }
            PanelUserInit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbSearch.Text))
            {
                Controller("search");
            }
        }

        private void btnActivity_Click(object sender, EventArgs e)
        {
            FormRefresh("activity");
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            FormRefresh("user");
        }

        //Panel Activity

        public void PanelActivityInit()
        {
            GetDataActivity();
        }

        public void GetDataActivity()
        {
            var today = DateTime.Today.Date.ToString("yyyy-MM-dd");
            dgvActivity.DataSource = comp.GetSql($"SELECT L.id_log AS 'ID Log', U.nama AS 'Nama', L.waktu AS 'Waktu', L.aktivitas AS 'Aktivitas' FROM tbl_log L INNER JOIN tbl_user U ON L.id_user = U.id_user WHERE L.waktu BETWEEN '{today} 00:00:00' AND '{today} 23:59:59'");
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            var tanggal = dtpTanggal.Value.ToString("yyyy-MM-dd");
            dgvActivity.DataSource = comp.GetSql($"select L.id_log as 'ID Log', U.nama as 'Nama', L.waktu as 'Waktu', L.aktivitas as 'Aktivitas' from tbl_log L inner join tbl_user U on L.id_user = U.id_user where L.waktu BETWEEN '{tanggal} 00:00:00' AND '{tanggal} 23:59:59'");
        }

        private void pnlActivity_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            comp.SetSql($"INSERT INTO tbl_log (aktivitas, id_user) VALUES ('Logout', {Gv.uid});");
            Application.Restart();
        }

        //Panel Laporan

        public void PanelLaporanInit()
        {
            dtpFrom.Region = new Region(new Rectangle(1, 1, dtpFrom.Width - 2, dtpFrom.Height - 2));
            dtpTo.Region = new Region(new Rectangle(1, 1, dtpTo.Width - 2, dtpTo.Height - 2));
            pnlChart.Enabled = false;
            AddDataToReport();
        }

        public int GetOmset(int month, int year)
        {
            var firstdaymonth = new DateTime(year, month, 1);
            var lastdaymonth = firstdaymonth.AddMonths(1).AddDays(-1);
            DataTable dt = new DataTable();
            dt = comp.GetSql($"select total_bayar from tbl_transaksi where tgl_transaksi between '{firstdaymonth:yyyy-MM-dd}' and '{lastdaymonth:yyyy-MM-dd}'");
            if (dt.Rows.Count > 0)
            {
                int omset = int.Parse(dt.Rows[0][0].ToString());
                return omset;
            }
            else
            {
                return 0;
            }
        }

        public void GetReport()
        {
            int FromMonth = dtpFrom.Value.Month;
            int toMonth = dtpTo.Value.Month;
            int FromYear = dtpFrom.Value.Year;
            int ToYear = dtpTo.Value.Year;

            if (FromMonth > toMonth && FromYear > ToYear) return;

            crtReport.Series["Omset"].Points.Clear();

            for (int year = FromYear; year <= ToYear; year++)
            {
                for (int month = 1; month < 12; month++)
                {
                    if (month < FromMonth) continue;
                    if (month > toMonth) continue;

                    var MonthNames = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month);
                    var omset = GetOmset(month, year);

                    crtReport.Series["Omset"].Points.AddXY(MonthNames, omset);
                }
            }
        }

        public void AddDataToReport()
        {
            DataTable dt = new DataTable();
            dt = comp.GetSql("select T.id_transaksi, T.no_transaksi, T.tgl_transaksi, T.total_bayar, U.nama from tbl_transaksi T inner join tbl_user U on U.id_user = T.id_user");

            foreach (DataRow row in dt.Rows)
            {
                int id = (int)row[0];
                string noTransaksi = row[1].ToString();
                DateTime date = (DateTime)row[2];
                int total = int.Parse(row[3].ToString());
                string nama = row[4].ToString();

                //conversi

                string idx = $"TR{id:000}";
                var idculture = new CultureInfo("id-ID");
                string tanggalx = date.ToString("dddd, dd/MM/yyyy", idculture);
                string totalx = $"Rp. {total:#,0}";

                dgvReport.Rows.Add(noTransaksi, tanggalx, totalx, nama);
            }
        }

        public bool ValidateFromTo()
        {
            bool result = true;
            var from = dtpFrom.Value;
            var to = dtpTo.Value;

            if (from >= to)
            {
                MessageBox.Show("Tidak Bisa Mundur Waktu", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                result = false;
            }
            return result;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            FormRefresh("laporan");
        }

        private void btnFilterReport_Click(object sender, EventArgs e)
        {
            if (!ValidateFromTo()) return;

            if (dgvReport.Rows.Count > 0)
            {
                pnlChart.Enabled = true;
            }
        }

        private void frmAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            GetReport();
        }
    }
}