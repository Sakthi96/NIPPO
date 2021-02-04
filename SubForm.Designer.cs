namespace MBNippo
{
    partial class SubForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubForm));
            this.txt_starttime = new System.Windows.Forms.TextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_end = new System.Windows.Forms.Button();
            this.txt_endtime = new System.Windows.Forms.TextBox();
            this.txt_break = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_reg = new System.Windows.Forms.Button();
            this.txt_comment = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_starttime
            // 
            this.txt_starttime.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_starttime.ForeColor = System.Drawing.Color.Silver;
            this.txt_starttime.Location = new System.Drawing.Point(24, 73);
            this.txt_starttime.Name = "txt_starttime";
            this.txt_starttime.Size = new System.Drawing.Size(89, 19);
            this.txt_starttime.TabIndex = 0;
            this.txt_starttime.Text = "出勤時間";
            this.txt_starttime.Enter += new System.EventHandler(this.txt_starttime_Enter);
            this.txt_starttime.Leave += new System.EventHandler(this.txt_starttime_Leave);
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_start.FlatAppearance.BorderSize = 0;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Location = new System.Drawing.Point(133, 73);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(62, 23);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "打刻";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_end
            // 
            this.btn_end.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_end.FlatAppearance.BorderSize = 0;
            this.btn_end.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_end.Location = new System.Drawing.Point(333, 77);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(62, 23);
            this.btn_end.TabIndex = 3;
            this.btn_end.Text = "打刻";
            this.btn_end.UseVisualStyleBackColor = false;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // txt_endtime
            // 
            this.txt_endtime.ForeColor = System.Drawing.Color.Silver;
            this.txt_endtime.Location = new System.Drawing.Point(224, 77);
            this.txt_endtime.Name = "txt_endtime";
            this.txt_endtime.Size = new System.Drawing.Size(89, 19);
            this.txt_endtime.TabIndex = 2;
            this.txt_endtime.Text = "退勤時間";
            this.txt_endtime.Enter += new System.EventHandler(this.txt_endtime_Enter);
            this.txt_endtime.Leave += new System.EventHandler(this.txt_endtime_Leave);
            // 
            // txt_break
            // 
            this.txt_break.Location = new System.Drawing.Point(426, 77);
            this.txt_break.Name = "txt_break";
            this.txt_break.Size = new System.Drawing.Size(89, 19);
            this.txt_break.TabIndex = 4;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.date.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(238, 20);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(54, 23);
            this.date.TabIndex = 5;
            this.date.Text = "date";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.date);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 59);
            this.panel1.TabIndex = 6;
            // 
            // btn_close
            // 
            this.btn_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_close.BackgroundImage")));
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(510, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(28, 30);
            this.btn_close.TabIndex = 6;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_reg
            // 
            this.btn_reg.BackColor = System.Drawing.Color.Lime;
            this.btn_reg.FlatAppearance.BorderSize = 0;
            this.btn_reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reg.Location = new System.Drawing.Point(224, 202);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(75, 23);
            this.btn_reg.TabIndex = 8;
            this.btn_reg.Text = "登録";
            this.btn_reg.UseVisualStyleBackColor = false;
            this.btn_reg.Click += new System.EventHandler(this.btn_reg_Click);
            // 
            // txt_comment
            // 
            this.txt_comment.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_comment.ForeColor = System.Drawing.Color.Silver;
            this.txt_comment.Location = new System.Drawing.Point(24, 116);
            this.txt_comment.Multiline = true;
            this.txt_comment.Name = "txt_comment";
            this.txt_comment.Size = new System.Drawing.Size(491, 69);
            this.txt_comment.TabIndex = 9;
            this.txt_comment.Text = "業務内容";
            this.txt_comment.Enter += new System.EventHandler(this.txt_comment_Enter);
            this.txt_comment.Leave += new System.EventHandler(this.txt_comment_Leave);
            // 
            // SubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(550, 250);
            this.Controls.Add(this.txt_comment);
            this.Controls.Add(this.btn_reg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_break);
            this.Controls.Add(this.btn_end);
            this.Controls.Add(this.txt_endtime);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.txt_starttime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SubForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_starttime;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_end;
        private System.Windows.Forms.TextBox txt_endtime;
        private System.Windows.Forms.TextBox txt_break;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_reg;
        private System.Windows.Forms.TextBox txt_comment;
    }
}