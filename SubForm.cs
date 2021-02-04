using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MBNippo
{
    public partial class SubForm : Form
    {
        public String EmpID;
        public String username;
        public DateTime now;

        public SubForm()
        {
            InitializeComponent();
        }
        private void SubForm_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Today;
            date.Text = now.ToString("yyyy/MM");
            txt_break.Text = "01:00";
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txt_starttime_Enter(object sender, EventArgs e)
        {
            if (txt_starttime.Text == "出勤時間")
            {
                txt_starttime.Text = "";
                txt_starttime.ForeColor = Color.Black;
            }
        }
        private void txt_starttime_Leave(object sender, EventArgs e)
        {
            if (txt_starttime.Text == "")
            {
                txt_starttime.Text = "出勤時間";
                txt_starttime.ForeColor = Color.Silver;
            }
        }
        private void txt_endtime_Enter(object sender, EventArgs e)
        {
            if (txt_endtime.Text == "退勤時間")
            {
                txt_endtime.Text = "";
                txt_endtime.ForeColor = Color.Black;
            }
        }
        private void txt_endtime_Leave(object sender, EventArgs e)
        {
            if (txt_endtime.Text == "")
            {
                txt_endtime.Text = "退勤時間";
                txt_endtime.ForeColor = Color.Silver;
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            txt_starttime.Text = now.ToString("hh:mm");
            txt_starttime.ForeColor = Color.Black;
        }

        private void txt_comment_Enter(object sender, EventArgs e)
        {
            if (txt_comment.Text == "業務内容")
            {
                txt_comment.Text = "";
                txt_comment.ForeColor = Color.Black;
            }
        }

        private void txt_comment_Leave(object sender, EventArgs e)
        {
            if (txt_comment.Text == "")
            {
                txt_comment.Text = "業務内容";
                txt_comment.ForeColor = Color.Silver;
            }
        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            txt_endtime.Text = now.ToString("hh:mm");
            txt_endtime.ForeColor = Color.Black;
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            string connectionString = File.ReadAllText(@"c:\Debug\sql.txt");
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand Command = connection.CreateCommand())
                {
                    Command.CommandText = "UPDATE Attendance SET date = @date,EmpId= @Empid,starttime =@Shukkinjikan,endtime=@Taikinjikan,break=@Kyukeijikan,comment=@gyomunaiyou,created_by=@username,created_at='" + DateTime.Now.ToString() + "',updated_by= @username,updated_at= '" + DateTime.Now.ToString() + "' WHERE date =@date and EmpId= @Empid";
                    Command.Parameters.AddWithValue("@date", now.ToString("yyyy/MM/dd"));
                    Command.Parameters.AddWithValue("@Shukkinjikan", txt_starttime.Text);
                    Command.Parameters.AddWithValue("@Taikinjikan", txt_endtime.Text);
                    Command.Parameters.AddWithValue("@Kyukeijikan", txt_break.Text);
                    Command.Parameters.AddWithValue("@gyomunaiyou", txt_comment.Text);
                    Command.Parameters.AddWithValue("@username", username);
                    Command.Parameters.AddWithValue("@Empid", EmpID);
                    Command.Connection.Open();
                    Command.ExecuteNonQuery();
                    Command.Connection.Close();
                }
            }
            this.Hide();
        }
    }
}
