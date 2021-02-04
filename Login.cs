using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MBNippo
{
    public partial class frm_login : Form
    {
        public static string username = "";
        public frm_login()
        {
            InitializeComponent();
        }
        private void frm_login_Load(object sender, EventArgs e)
        {
            if (!File.Exists(@"c:\Debug\sql.txt"))
            {
                MessageBox.Show("Debug ファルダ を C: に置いておいて ください。");
            }
            txt_Userid.Focus();
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            string cs = File.ReadAllText(@"c:\Debug\sql.txt"); 
            //string cs = @"Server=localhost;userId=root;password=root;database=mbnippo"; 
            if (txt_Userid.Text == "")
            {
                MessageBox.Show("社員ID を 入力してください");
                txt_Userid.Focus();
                return;
            }
            if (txt_Userid.Text.Length > 10)
            {　
                MessageBox.Show("社員ID は 10字 以上 入力 不可能！");
                txt_Userid.Focus();
                return;
            }
            if (txt_Password.Text == "")
            {
                MessageBox.Show("パスワード を 入力してください");
                txt_Password.Focus();
                return;
            }
            if (txt_Userid.Text.Length > 12)
            {
                MessageBox.Show("パスワード は 12字 以上 入力 不可能！");
                txt_Password.Focus();
                return;
            }
            try
            {
                //Create SqlConnection
                MySqlConnection con = new MySqlConnection(cs);
                MySqlCommand cmd = new MySqlCommand("Select * from Employee where EmpId=@username and Password=@password", con);
                cmd.Parameters.AddWithValue("@username", txt_Userid.Text);
                cmd.Parameters.AddWithValue("@password", txt_Password.Text);
                MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int Count = ds.Tables[0].Rows.Count;
                if (Count != 0)
                {
                    String userid = ds.Tables[0].Rows[0]["EmpId"].ToString();
                    String password = ds.Tables[0].Rows[0]["Password"].ToString();
                    if (userid == "AD001" && password == txt_Password.Text)
                    {
                        MessageBox.Show("ログイン が 成功しました!");
                        this.Hide();
                        username = txt_Userid.Text;
                        frm_shaiinrisuto fm = new frm_shaiinrisuto();
                        fm.Show();
                    }
                    else if (userid == txt_Userid.Text && password == txt_Password.Text)
                    {
                        MessageBox.Show("ログイン が 成功しました!");
                        this.Hide();
                        username = txt_Userid.Text;
                        frm_tsukibetsurisuto fm = new frm_tsukibetsurisuto();
                        fm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("社員ID また パスワードは正しくありません！");
                    txt_Userid.Clear();
                    txt_Password.Clear();
                    txt_Userid.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
