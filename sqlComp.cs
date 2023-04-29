using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LKSProvFullSoft
{
    internal class sqlComp
    {
        private SqlCommand cmd;
        private DataTable dt;
        private SqlDataAdapter da;

        public bool SetSql(string query)
        {
            bool result = false;
            Gv.con.Open();
            try
            {
                cmd = new SqlCommand(query, Gv.con);
                cmd.ExecuteNonQuery();
                result = true;
                Gv.con.Close();
            }
            catch
            {
                MessageBox.Show("Sepertinya ada yang salah", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Gv.con.Close();
            }
            return result;
        }

        public DataTable GetSql(string query)
        {
            dt = new DataTable();
            Gv.con.Open();
            try
            {
                da = new SqlDataAdapter(query, Gv.con);
                da.Fill(dt);
                Gv.con.Close();
            }
            catch
            {
                MessageBox.Show("Sepertinya ada yang salah", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Gv.con.Close();
            }
            return dt;
        }
    }
}