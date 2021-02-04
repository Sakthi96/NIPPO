using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MBNippo
{
    public partial class frm_shaiinrisuto : Form
    {
        private frm_login frm_login;

        public frm_shaiinrisuto()
        {
            InitializeComponent();
        }

        public frm_shaiinrisuto(frm_login frm_login)
        {
            this.frm_login = frm_login;
        }

        private void frm_shaiinrisuto_Load(object sender, EventArgs e)
        {
            string cs = File.ReadAllText(@"c:\Debug\sql.txt");
            MySqlConnection con = new MySqlConnection(cs);
            String query = @"Select SNo,EmpName from Employeelist";
            MySqlCommand cmd = new MySqlCommand(query, con);
            con.Open();
            MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            grd_shaiinrisuto.DataSource = ds;
            grd_shaiinrisuto.DataMember = ds.Tables[0].ToString();
        }
        private void btn_logout_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("ログアウトしますか ?",
                                      "Confirm Logout !",
                                      MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                frm_login frmlogin = new frm_login();
                this.Hide();
                frmlogin.Show();
            }
            else
            {
                this.Show();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
