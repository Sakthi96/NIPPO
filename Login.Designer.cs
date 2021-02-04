namespace MBNippo
{
    partial class frm_login
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.lbl_Login = new System.Windows.Forms.Label();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.pnl_login = new System.Windows.Forms.Panel();
            this.pnl_bottom = new System.Windows.Forms.Panel();
            this.btn_Login = new System.Windows.Forms.Button();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Userid = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_Userid = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnl_top.SuspendLayout();
            this.pnl_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Font = new System.Drawing.Font("Stencil", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Login.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbl_Login.Location = new System.Drawing.Point(460, 9);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(128, 42);
            this.lbl_Login.TabIndex = 7;
            this.lbl_Login.Text = "ログイン";
            this.lbl_Login.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.pnl_top.Controls.Add(this.lbl_Login);
            this.pnl_top.Controls.Add(this.btn_Close);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(983, 59);
            this.pnl_top.TabIndex = 8;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.btn_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Close.BackgroundImage")));
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Location = new System.Drawing.Point(947, 12);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(24, 24);
            this.btn_Close.TabIndex = 20;
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // pnl_login
            // 
            this.pnl_login.Controls.Add(this.pnl_bottom);
            this.pnl_login.Controls.Add(this.btn_Login);
            this.pnl_login.Controls.Add(this.txt_Password);
            this.pnl_login.Controls.Add(this.txt_Userid);
            this.pnl_login.Controls.Add(this.lbl_password);
            this.pnl_login.Controls.Add(this.lbl_Userid);
            this.pnl_login.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_login.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_login.Location = new System.Drawing.Point(0, 54);
            this.pnl_login.Name = "pnl_login";
            this.pnl_login.Size = new System.Drawing.Size(983, 540);
            this.pnl_login.TabIndex = 10;
            // 
            // pnl_bottom
            // 
            this.pnl_bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.pnl_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_bottom.Location = new System.Drawing.Point(0, 505);
            this.pnl_bottom.Name = "pnl_bottom";
            this.pnl_bottom.Size = new System.Drawing.Size(983, 35);
            this.pnl_bottom.TabIndex = 19;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.ForeColor = System.Drawing.Color.Black;
            this.btn_Login.Location = new System.Drawing.Point(467, 243);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(117, 32);
            this.btn_Login.TabIndex = 18;
            this.btn_Login.Text = "ログイン";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.White;
            this.txt_Password.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.txt_Password.Location = new System.Drawing.Point(467, 178);
            this.txt_Password.MaxLength = 12;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(221, 22);
            this.txt_Password.TabIndex = 17;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // txt_Userid
            // 
            this.txt_Userid.BackColor = System.Drawing.Color.White;
            this.txt_Userid.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Userid.Location = new System.Drawing.Point(467, 123);
            this.txt_Userid.MaxLength = 10;
            this.txt_Userid.Name = "txt_Userid";
            this.txt_Userid.Size = new System.Drawing.Size(221, 22);
            this.txt_Userid.TabIndex = 16;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(358, 179);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(76, 21);
            this.lbl_password.TabIndex = 13;
            this.lbl_password.Text = "パスワード";
            // 
            // lbl_Userid
            // 
            this.lbl_Userid.AutoSize = true;
            this.lbl_Userid.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Userid.Location = new System.Drawing.Point(358, 122);
            this.lbl_Userid.Name = "lbl_Userid";
            this.lbl_Userid.Size = new System.Drawing.Size(61, 21);
            this.lbl_Userid.TabIndex = 1;
            this.lbl_Userid.Text = "社員ID";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(983, 594);
            this.Controls.Add(this.pnl_login);
            this.Controls.Add(this.pnl_top);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frm_login_Load);
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.pnl_login.ResumeLayout(false);
            this.pnl_login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Panel pnl_login;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_Userid;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Userid;
        private System.Windows.Forms.Button btn_Login;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Panel pnl_bottom;
    }
}

