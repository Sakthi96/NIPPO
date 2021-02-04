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
    public partial class frm_nippotouroku : Form
    {
        public DataGridViewRow RowData;
        public Boolean updateFlg;
        public String edit_date;
        public String EmpID;
        public String username;

        public frm_nippotouroku()
        {
            InitializeComponent();
        }
        private void frm_nippotouroku_Load(object sender, EventArgs e)
        {
            if(updateFlg) {
                lbl_Nippotouroku.Text = "日報更新";
                btn_Nippotouroku.Text = "更新";
                dateTimePicker1.Value =Convert.ToDateTime(RowData.Cells["date"].Value.ToString());
                dateTimePicker1.Enabled = false;
                edit_date = dateTimePicker1.Value.ToString("yyyy/MM/dd");
                txt_Shukkinjikan.Text = RowData.Cells["starttime"].Value.ToString();
                txt_Taikinjikan.Text = RowData.Cells["endtime"].Value.ToString();
                txt_Kyukeijikan.Text = RowData.Cells["break"].Value.ToString();
                txt_gyomunaiyou.Text = RowData.Cells["comment"].Value.ToString();
            }
        }
        private void cancel_Click(object sender, EventArgs e)
        {
            frm_tsukibetsurisuto fm = new frm_tsukibetsurisuto();
            this.Hide();
            fm.Show();
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
            frm_tsukibetsurisuto fm = new frm_tsukibetsurisuto();
            this.Hide();
            fm.Show();
        }

        private void btn_Nippotouroku_Click(object sender, EventArgs e)
        {
            string connectionString = File.ReadAllText(@"c:\Debug\sql.txt");
            if (txt_Shukkinjikan.Text == "")
            {
                MessageBox.Show("出勤時間 を 入力してください");
                txt_Shukkinjikan.Focus();
                return;
            }
            if (txt_Taikinjikan.Text == "")
            {
                MessageBox.Show("退勤時間 を 入力してください");
                txt_Taikinjikan.Focus();
                return;
            }
            if (txt_Kyukeijikan.Text == "")
            {
                MessageBox.Show("休憩時間 を 入力してください");
                txt_Kyukeijikan.Focus();
                return;
            }
            if (txt_gyomunaiyou.Text == "")
            {
                MessageBox.Show("業務内容 を 入力してください");
                txt_gyomunaiyou.Focus();
                return;
            }
            if (dateTimePicker1.Value == null)
            {
                MessageBox.Show("日付 を 選択してください");
                txt_gyomunaiyou.Focus();
                return;
            }
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand Command = connection.CreateCommand())
                {
                    if (updateFlg)
                    {
                        Command.CommandText = "DELETE FROM Attendance WHERE date = @edit_date ";
                        Command.Parameters.AddWithValue("@edit_date", edit_date);
                        Command.Connection.Open();
                        Command.ExecuteNonQuery();
                        Command.Connection.Close();
                    }
                    Command.CommandText = "INSERT Attendance (date,EmpId,starttime,endtime,break,comment,created_by,created_at,updated_by,updated_at) VALUES (@date,@Empid, @Shukkinjikan, @Taikinjikan,@Kyukeijikan,@gyomunaiyou,@username,'" + DateTime.Now.ToString() + "',@username,'" + DateTime.Now.ToString() + "') ";
                    Command.Parameters.AddWithValue("@date", dateTimePicker1.Value);
                    Command.Parameters.AddWithValue("@Shukkinjikan", txt_Shukkinjikan.Text);
                    Command.Parameters.AddWithValue("@Taikinjikan", txt_Taikinjikan.Text);
                    Command.Parameters.AddWithValue("@Kyukeijikan", txt_Kyukeijikan.Text);
                    Command.Parameters.AddWithValue("@gyomunaiyou", txt_gyomunaiyou.Text);
                    Command.Parameters.AddWithValue("@username", username);
                    Command.Parameters.AddWithValue("@Empid", EmpID);
                    Command.Connection.Open();
                    Command.ExecuteNonQuery();
                    Command.Connection.Close();
                    if (updateFlg)
                    {
                        MessageBox.Show("更新しました!");
                    }
                    else
                    {
                        MessageBox.Show("登録しました!");
                    }
                    this.Hide();
                    frm_tsukibetsurisuto fm = new frm_tsukibetsurisuto();
                    fm.Show();
                }
            }
        }
       
    }
}
