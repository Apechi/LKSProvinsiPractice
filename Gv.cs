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
    internal class Gv
    {
        public static string uid;
        public static string username;
        public static string status;
        public static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F316BRT\SQLEXPRESS;Initial Catalog=FoodXYZ;Integrated Security=True");
        public static frmLogin fl = new frmLogin();
        public static frmAdmin fa = new frmAdmin();
        public static frmGudang fg = new frmGudang();
        public static frmKasir fk = new frmKasir();
    }
}