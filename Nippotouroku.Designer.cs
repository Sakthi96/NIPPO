namespace MBNippo
{
    partial class frm_nippotouroku
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_nippotouroku));
            this.pnl_nippotouroku = new System.Windows.Forms.Panel();
            this.hiddenlabel = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_gyomunaiyou = new System.Windows.Forms.RichTextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.btn_Nippotouroku = new System.Windows.Forms.Button();
            this.lbl_Gyoumunaiyou = new System.Windows.Forms.Label();
            this.txt_Kyukeijikan = new System.Windows.Forms.TextBox();
            this.lbl_Kyukeijikan = new System.Windows.Forms.Label();
            this.txt_Taikinjikan = new System.Windows.Forms.TextBox();
            this.lbl_Taikinjikan = new System.Windows.Forms.Label();
            this.txt_Shukkinjikan = new System.Windows.Forms.TextBox();
            this.lbl_Shukkinjikan = new System.Windows.Forms.Label();
            this.lbl_Nippotouroku = new System.Windows.Forms.Label();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.pnl_nippotouroku.SuspendLayout();
            this.pnl_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_nippotouroku
            // 
            this.pnl_nippotouroku.BackColor = System.Drawing.Color.White;
            this.pnl_nippotouroku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnl_nippotouroku.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_nippotouroku.Controls.Add(this.hiddenlabel);
            this.pnl_nippotouroku.Controls.Add(this.lbl_date);
            this.pnl_nippotouroku.Controls.Add(this.dateTimePicker1);
            this.pnl_nippotouroku.Controls.Add(this.txt_gyomunaiyou);
            this.pnl_nippotouroku.Controls.Add(this.cancel);
            this.pnl_nippotouroku.Controls.Add(this.btn_Nippotouroku);
            this.pnl_nippotouroku.Controls.Add(this.lbl_Gyoumunaiyou);
            this.pnl_nippotouroku.Controls.Add(this.txt_Kyukeijikan);
            this.pnl_nippotouroku.Controls.Add(this.lbl_Kyukeijikan);
            this.pnl_nippotouroku.Controls.Add(this.txt_Taikinjikan);
            this.pnl_nippotouroku.Controls.Add(this.lbl_Taikinjikan);
            this.pnl_nippotouroku.Controls.Add(this.txt_Shukkinjikan);
            this.pnl_nippotouroku.Controls.Add(this.lbl_Shukkinjikan);
            this.pnl_nippotouroku.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_nippotouroku.Location = new System.Drawing.Point(0, 65);
            this.pnl_nippotouroku.Name = "pnl_nippotouroku";
            this.pnl_nippotouroku.Size = new System.Drawing.Size(800, 385);
            this.pnl_nippotouroku.TabIndex = 0;
            // 
            // hiddenlabel
            // 
            this.hiddenlabel.AutoSize = true;
            this.hiddenlabel.Location = new System.Drawing.Point(389, 21);
            this.hiddenlabel.Name = "hiddenlabel";
            this.hiddenlabel.Size = new System.Drawing.Size(0, 12);
            this.hiddenlabel.TabIndex = 16;
            this.hiddenlabel.Visible = false;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_date.Location = new System.Drawing.Point(256, 267);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(44, 21);
            this.lbl_date.TabIndex = 15;
            this.lbl_date.Text = "日付";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(391, 269);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 19);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.Value = new System.DateTime(2021, 1, 15, 0, 0, 0, 0);
            // 
            // txt_gyomunaiyou
            // 
            this.txt_gyomunaiyou.Location = new System.Drawing.Point(391, 197);
            this.txt_gyomunaiyou.Name = "txt_gyomunaiyou";
            this.txt_gyomunaiyou.Size = new System.Drawing.Size(165, 46);
            this.txt_gyomunaiyou.TabIndex = 13;
            this.txt_gyomunaiyou.Text = "";
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.Red;
            this.cancel.FlatAppearance.BorderSize = 0;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Location = new System.Drawing.Point(296, 322);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(92, 31);
            this.cancel.TabIndex = 12;
            this.cancel.Text = "キャンセル";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // btn_Nippotouroku
            // 
            this.btn_Nippotouroku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(51)))));
            this.btn_Nippotouroku.FlatAppearance.BorderSize = 0;
            this.btn_Nippotouroku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Nippotouroku.Location = new System.Drawing.Point(451, 322);
            this.btn_Nippotouroku.Name = "btn_Nippotouroku";
            this.btn_Nippotouroku.Size = new System.Drawing.Size(105, 31);
            this.btn_Nippotouroku.TabIndex = 10;
            this.btn_Nippotouroku.Text = "登録";
            this.btn_Nippotouroku.UseVisualStyleBackColor = false;
            this.btn_Nippotouroku.Click += new System.EventHandler(this.btn_Nippotouroku_Click);
            // 
            // lbl_Gyoumunaiyou
            // 
            this.lbl_Gyoumunaiyou.AutoSize = true;
            this.lbl_Gyoumunaiyou.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_Gyoumunaiyou.Location = new System.Drawing.Point(256, 197);
            this.lbl_Gyoumunaiyou.Name = "lbl_Gyoumunaiyou";
            this.lbl_Gyoumunaiyou.Size = new System.Drawing.Size(78, 21);
            this.lbl_Gyoumunaiyou.TabIndex = 7;
            this.lbl_Gyoumunaiyou.Text = "業務内容";
            // 
            // txt_Kyukeijikan
            // 
            this.txt_Kyukeijikan.Location = new System.Drawing.Point(391, 148);
            this.txt_Kyukeijikan.Name = "txt_Kyukeijikan";
            this.txt_Kyukeijikan.Size = new System.Drawing.Size(165, 19);
            this.txt_Kyukeijikan.TabIndex = 6;
            // 
            // lbl_Kyukeijikan
            // 
            this.lbl_Kyukeijikan.AutoSize = true;
            this.lbl_Kyukeijikan.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_Kyukeijikan.Location = new System.Drawing.Point(256, 148);
            this.lbl_Kyukeijikan.Name = "lbl_Kyukeijikan";
            this.lbl_Kyukeijikan.Size = new System.Drawing.Size(78, 21);
            this.lbl_Kyukeijikan.TabIndex = 5;
            this.lbl_Kyukeijikan.Text = "休憩時間";
            // 
            // txt_Taikinjikan
            // 
            this.txt_Taikinjikan.Location = new System.Drawing.Point(391, 103);
            this.txt_Taikinjikan.Name = "txt_Taikinjikan";
            this.txt_Taikinjikan.Size = new System.Drawing.Size(165, 19);
            this.txt_Taikinjikan.TabIndex = 3;
            // 
            // lbl_Taikinjikan
            // 
            this.lbl_Taikinjikan.AutoSize = true;
            this.lbl_Taikinjikan.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_Taikinjikan.Location = new System.Drawing.Point(246, 103);
            this.lbl_Taikinjikan.Name = "lbl_Taikinjikan";
            this.lbl_Taikinjikan.Size = new System.Drawing.Size(78, 21);
            this.lbl_Taikinjikan.TabIndex = 2;
            this.lbl_Taikinjikan.Text = "退勤時間";
            // 
            // txt_Shukkinjikan
            // 
            this.txt_Shukkinjikan.Location = new System.Drawing.Point(391, 51);
            this.txt_Shukkinjikan.Name = "txt_Shukkinjikan";
            this.txt_Shukkinjikan.Size = new System.Drawing.Size(165, 19);
            this.txt_Shukkinjikan.TabIndex = 1;
            // 
            // lbl_Shukkinjikan
            // 
            this.lbl_Shukkinjikan.AutoSize = true;
            this.lbl_Shukkinjikan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Shukkinjikan.Location = new System.Drawing.Point(246, 51);
            this.lbl_Shukkinjikan.Name = "lbl_Shukkinjikan";
            this.lbl_Shukkinjikan.Size = new System.Drawing.Size(78, 21);
            this.lbl_Shukkinjikan.TabIndex = 0;
            this.lbl_Shukkinjikan.Text = "出勤時間";
            // 
            // lbl_Nippotouroku
            // 
            this.lbl_Nippotouroku.AutoSize = true;
            this.lbl_Nippotouroku.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Nippotouroku.Location = new System.Drawing.Point(324, 15);
            this.lbl_Nippotouroku.Name = "lbl_Nippotouroku";
            this.lbl_Nippotouroku.Size = new System.Drawing.Size(131, 32);
            this.lbl_Nippotouroku.TabIndex = 9;
            this.lbl_Nippotouroku.Text = "日報登録";
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.pnl_top.Controls.Add(this.btn_close);
            this.pnl_top.Controls.Add(this.lbl_Nippotouroku);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(800, 69);
            this.pnl_top.TabIndex = 1;
            // 
            // btn_close
            // 
            this.btn_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_close.BackgroundImage")));
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(754, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(34, 35);
            this.btn_close.TabIndex = 11;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // frm_nippotouroku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_top);
            this.Controls.Add(this.pnl_nippotouroku);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_nippotouroku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NippoRegister";
            this.Load += new System.EventHandler(this.frm_nippotouroku_Load);
            this.pnl_nippotouroku.ResumeLayout(false);
            this.pnl_nippotouroku.PerformLayout();
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_nippotouroku;
        private System.Windows.Forms.Label lbl_Kyukeijikan;
        private System.Windows.Forms.TextBox txt_Taikinjikan;
        private System.Windows.Forms.Label lbl_Taikinjikan;
        private System.Windows.Forms.TextBox txt_Shukkinjikan;
        private System.Windows.Forms.Label lbl_Shukkinjikan;
        private System.Windows.Forms.TextBox txt_Kyukeijikan;
        private System.Windows.Forms.Label lbl_Gyoumunaiyou;
        private System.Windows.Forms.Label lbl_Nippotouroku;
        private System.Windows.Forms.Button btn_Nippotouroku;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.RichTextBox txt_gyomunaiyou;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label hiddenlabel;
    }
}