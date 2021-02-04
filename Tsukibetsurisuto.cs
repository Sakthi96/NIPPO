using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MBNippo
{
    public partial class frm_tsukibetsurisuto : Form
    {
        public static string userid = "";
        public frm_tsukibetsurisuto()
        {
            InitializeComponent();
        }

        private void frm_tsukibetsurisuto_Load(object sender, EventArgs e)
        {
            hidlabel.Text = frm_login.username;
            MessageBox.Show(hidlabel.Text);
            string cs = File.ReadAllText(@"c:\Debug\sql.txt");
            MySqlConnection con = new MySqlConnection(cs);
            MySqlCommand cmd = new MySqlCommand("Select EmpName from Employee where EmpId =@userid", con);
            cmd.Parameters.AddWithValue("@userid", hidlabel.Text);
            con.Open();
            MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            userid = ds.Tables[0].Rows[0]["EmpName"].ToString();
            pop_label.Text = userid;
            Form formBackground = new Form();
            try
            {
                using (SubForm uu = new SubForm())
                {
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .50d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    uu.Owner = formBackground;
                    uu.EmpID = hidlabel.Text;
                    uu.ShowDialog();

                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }
            MySqlCommand comd = new MySqlCommand("Select SNo,date,starttime,endtime,break,comment from Attendance Where EmpId ='"+ hidlabel.Text + "'", con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(comd);
            DataSet des = new DataSet();
            adapter.Fill(des);
            grd_tsukibetsurisuto.DataSource = des;
            grd_tsukibetsurisuto.DataMember = des.Tables[0].ToString();
        }
        private void logout_Click(object sender, EventArgs e)
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
        private void btn_filter_Click(object sender, EventArgs e)
        {
            string cs = File.ReadAllText(@"c:\Debug\sql.txt");
            MySqlConnection con = new MySqlConnection(cs);
            MySqlCommand cmd = new MySqlCommand("Select date,starttime,endtime,break,comment from Attendance where EmpId = @Empid AND date >= @startdate AND date <= @enddate ", con);
            cmd.Parameters.AddWithValue("@startdate", dateTimePicker1.Value.ToString("yyyy/MM/dd"));
            cmd.Parameters.AddWithValue("@enddate", dateTimePicker1.Value.ToString("yyyy/MM/31"));
            cmd.Parameters.AddWithValue("@Empid", hidlabel.Text);
            con.Open();
            MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            grd_tsukibetsurisuto.DataSource = ds;
            grd_tsukibetsurisuto.DataMember = ds.Tables[0].ToString();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            
            frm_nippotouroku frmreg = new frm_nippotouroku();
            frmreg.username = pop_label.Text;
            frmreg.EmpID = hidlabel.Text;
            this.Hide();
            frmreg.Show();
        }
        private void changelog_Click(object sender, EventArgs e)
        {
            if (grd_tsukibetsurisuto.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.grd_tsukibetsurisuto.SelectedRows[0];
                frm_nippotouroku frmreg = new frm_nippotouroku();
                frmreg.RowData = row;
                frmreg.updateFlg = true;
                frmreg.EmpID = hidlabel.Text;
                this.Hide();
                frmreg.Show();
            }
        }
    }
}
