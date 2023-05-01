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
            FormRefresh("activity");
        }

        public void FormRefresh(string form)
        {
            switch (form)
            {
                case "user":
                    pnlUser.Visible = true;
                    pnlActivity.Visible = false;
                    PanelUserInit();
                    break;

                case "activity":
                    pnlActivity.Visible = true;
                    pnlUser.Visible = false;
                    PanelActivityInit();
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
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
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
    }
}