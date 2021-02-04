namespace MBNippo
{
    partial class frm_tsukibetsurisuto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_tsukibetsurisuto));
            this.grd_tsukibetsurisuto = new System.Windows.Forms.DataGridView();
            this.lbl_tsukibetsurisuto = new System.Windows.Forms.Label();
            this.changelog = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_filter = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.hidlabel = new System.Windows.Forms.Label();
            this.pop_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grd_tsukibetsurisuto)).BeginInit();
            this.pnl_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // grd_tsukibetsurisuto
            // 
            this.grd_tsukibetsurisuto.AllowDrop = true;
            this.grd_tsukibetsurisuto.AllowUserToAddRows = false;
            this.grd_tsukibetsurisuto.AllowUserToDeleteRows = false;
            this.grd_tsukibetsurisuto.AllowUserToResizeColumns = false;
            this.grd_tsukibetsurisuto.AllowUserToResizeRows = false;
            this.grd_tsukibetsurisuto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_tsukibetsurisuto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd_tsukibetsurisuto.BackgroundColor = System.Drawing.Color.White;
            this.grd_tsukibetsurisuto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grd_tsukibetsurisuto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grd_tsukibetsurisuto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_tsukibetsurisuto.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.grd_tsukibetsurisuto.Location = new System.Drawing.Point(116, 202);
            this.grd_tsukibetsurisuto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grd_tsukibetsurisuto.MultiSelect = false;
            this.grd_tsukibetsurisuto.Name = "grd_tsukibetsurisuto";
            this.grd_tsukibetsurisuto.ReadOnly = true;
            this.grd_tsukibetsurisuto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.grd_tsukibetsurisuto.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grd_tsukibetsurisuto.RowTemplate.Height = 21;
            this.grd_tsukibetsurisuto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grd_tsukibetsurisuto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_tsukibetsurisuto.Size = new System.Drawing.Size(807, 358);
            this.grd_tsukibetsurisuto.TabIndex = 0;
            // 
            // lbl_tsukibetsurisuto
            // 
            this.lbl_tsukibetsurisuto.AutoSize = true;
            this.lbl_tsukibetsurisuto.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tsukibetsurisuto.Location = new System.Drawing.Point(463, 13);
            this.lbl_tsukibetsurisuto.Name = "lbl_tsukibetsurisuto";
            this.lbl_tsukibetsurisuto.Size = new System.Drawing.Size(179, 44);
            this.lbl_tsukibetsurisuto.TabIndex = 1;
            this.lbl_tsukibetsurisuto.Text = "月別リスト";
            // 
            // changelog
            // 
            this.changelog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))));
            this.changelog.FlatAppearance.BorderSize = 0;
            this.changelog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changelog.Location = new System.Drawing.Point(471, 625);
            this.changelog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.changelog.Name = "changelog";
            this.changelog.Size = new System.Drawing.Size(105, 33);
            this.changelog.TabIndex = 3;
            this.changelog.Text = "ChangeLOG";
            this.changelog.UseVisualStyleBackColor = false;
            this.changelog.Click += new System.EventHandler(this.changelog_Click);
            // 
            // logout
            // 
            this.logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logout.BackgroundImage")));
            this.logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Location = new System.Drawing.Point(886, 13);
            this.logout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(37, 33);
            this.logout.TabIndex = 4;
            this.logout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.pnl_top.Controls.Add(this.btn_close);
            this.pnl_top.Controls.Add(this.lbl_tsukibetsurisuto);
            this.pnl_top.Controls.Add(this.logout);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(992, 79);
            this.pnl_top.TabIndex = 5;
            // 
            // btn_close
            // 
            this.btn_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_close.BackgroundImage")));
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(952, 13);
            this.btn_close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(28, 33);
            this.btn_close.TabIndex = 5;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy/MM";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(797, 165);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(83, 22);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // btn_filter
            // 
            this.btn_filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_filter.FlatAppearance.BorderSize = 0;
            this.btn_filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filter.Location = new System.Drawing.Point(886, 164);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(37, 23);
            this.btn_filter.TabIndex = 7;
            this.btn_filter.Text = "OK";
            this.btn_filter.UseVisualStyleBackColor = false;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(51)))));
            this.btn_register.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_register.FlatAppearance.BorderSize = 0;
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Location = new System.Drawing.Point(116, 164);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(148, 23);
            this.btn_register.TabIndex = 8;
            this.btn_register.Text = "こちらをクリックして登録";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // hidlabel
            // 
            this.hidlabel.AutoSize = true;
            this.hidlabel.Location = new System.Drawing.Point(122, 99);
            this.hidlabel.Name = "hidlabel";
            this.hidlabel.Size = new System.Drawing.Size(0, 17);
            this.hidlabel.TabIndex = 9;
            this.hidlabel.Visible = false;
            // 
            // pop_label
            // 
            this.pop_label.AutoSize = true;
            this.pop_label.Location = new System.Drawing.Point(261, 99);
            this.pop_label.Name = "pop_label";
            this.pop_label.Size = new System.Drawing.Size(0, 17);
            this.pop_label.TabIndex = 10;
            // 
            // frm_tsukibetsurisuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(992, 671);
            this.Controls.Add(this.pop_label);
            this.Controls.Add(this.hidlabel);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btn_filter);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pnl_top);
            this.Controls.Add(this.changelog);
            this.Controls.Add(this.grd_tsukibetsurisuto);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_tsukibetsurisuto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "月別リスト";
            this.Load += new System.EventHandler(this.frm_tsukibetsurisuto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_tsukibetsurisuto)).EndInit();
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grd_tsukibetsurisuto;
        private System.Windows.Forms.Label lbl_tsukibetsurisuto;
        private System.Windows.Forms.Button changelog;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Label hidlabel;
        private System.Windows.Forms.Label pop_label;
    }
}