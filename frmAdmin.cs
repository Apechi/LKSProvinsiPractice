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

        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            PanelUserInit();
        }

        // PANEL USER FUNCTIONALITY

        private void PanelUserInit()
        {
            pnlUser.Visible = true;
            ClearTB();
            InputState(true, false);
            AddDataToUserDgv();
            pnlDelete.Enabled = false;
            pnlEdit.Enabled = false;
            cbTipeUser.Region = new Region(new Rectangle(1, 1, cbTipeUser.Width - 2, cbTipeUser.Height - 3));
        }

        public void AddDataToUserDgv()
        {
            dt = new DataTable();
            dt = comp.GetSql("select * from tbl_user order by id_user asc");
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
            PanelUserInit();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            InputState(false, true);
        }
    }
}