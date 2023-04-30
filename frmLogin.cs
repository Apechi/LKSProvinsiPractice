using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;

namespace LKSProvFullSoft
{
    public partial class frmLogin : Form
    {
        private sqlComp comp = new sqlComp();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void tbUsername_Enter(object sender, EventArgs e)
        {
            if (tbUsername.Text == "User Name")
            {
                tbUsername.Text = "";
            }
        }

        private void tbUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUsername.Text))
            {
                tbUsername.Text = "User Name";
            }
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            if (tbPassword.Text == "Password")
            {
                tbPassword.Text = "";
                tbPassword.UseSystemPasswordChar = true;
            }
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbPassword.Text))
            {
                tbPassword.Text = "Password";
                tbPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbPassword.Text = "Password";
            tbUsername.Text = "User Name";
        }

        public void Login()
        {
            DataTable dt = new DataTable();
            dt = comp.GetSql($"select * from tbl_user where username = '{tbUsername.Text}' and password = '{tbPassword.Text}'");
            if (dt.Rows.Count > 0)
            {
                var today = DateTime.Now.ToString();
                Gv.uid = dt.Rows[0][0].ToString();
                Gv.username = dt.Rows[0][2].ToString();
                string tipe = dt.Rows[0][1].ToString();

                switch (tipe)
                {
                    case "Admin":
                        Gv.fa.Show();
                        this.Hide();
                        break;

                    case "Gudang":
                        Gv.fg.Show();
                        this.Hide();
                        break;

                    case "Kasir":
                        Gv.fk.Show();
                        this.Hide();
                        break;
                }

                comp.SetSql($"INSERT INTO tbl_log (aktivitas, id_user) VALUES ('Login', {Gv.uid});");
            }
            else
            {
                MessageBox.Show("Data Tidak Ada", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "User Name" || tbPassword.Text == "Password") return;
            if (tbUsername.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Input harus di Isi", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Login();
            }
        }
    }
}