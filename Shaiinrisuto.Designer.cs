namespace MBNippo
{
    partial class frm_shaiinrisuto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_shaiinrisuto));
            this.label1 = new System.Windows.Forms.Label();
            this.grd_shaiinrisuto = new System.Windows.Forms.DataGridView();
            this.btn_logout = new System.Windows.Forms.Button();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grd_shaiinrisuto)).BeginInit();
            this.pnl_top.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "社員リスト";
            // 
            // grd_shaiinrisuto
            // 
            this.grd_shaiinrisuto.AllowUserToAddRows = false;
            this.grd_shaiinrisuto.AllowUserToDeleteRows = false;
            this.grd_shaiinrisuto.AllowUserToResizeColumns = false;
            this.grd_shaiinrisuto.AllowUserToResizeRows = false;
            this.grd_shaiinrisuto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd_shaiinrisuto.BackgroundColor = System.Drawing.Color.White;
            this.grd_shaiinrisuto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grd_shaiinrisuto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grd_shaiinrisuto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_shaiinrisuto.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.grd_shaiinrisuto.Location = new System.Drawing.Point(34, 93);
            this.grd_shaiinrisuto.MultiSelect = false;
            this.grd_shaiinrisuto.Name = "grd_shaiinrisuto";
            this.grd_shaiinrisuto.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.grd_shaiinrisuto.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grd_shaiinrisuto.RowTemplate.Height = 21;
            this.grd_shaiinrisuto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grd_shaiinrisuto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_shaiinrisuto.Size = new System.Drawing.Size(674, 231);
            this.grd_shaiinrisuto.TabIndex = 1;
            // 
            // btn_logout
            // 
            this.btn_logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_logout.BackgroundImage")));
            this.btn_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Location = new System.Drawing.Point(657, 12);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(34, 35);
            this.btn_logout.TabIndex = 2;
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.pnl_top.Controls.Add(this.btn_close);
            this.pnl_top.Controls.Add(this.label1);
            this.pnl_top.Controls.Add(this.btn_logout);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(743, 62);
            this.pnl_top.TabIndex = 3;
            // 
            // btn_close
            // 
            this.btn_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_close.BackgroundImage")));
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(697, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(34, 35);
            this.btn_close.TabIndex = 3;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.grd_shaiinrisuto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 388);
            this.panel1.TabIndex = 4;
            // 
            // frm_shaiinrisuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_shaiinrisuto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shaiinrisuto";
            this.Load += new System.EventHandler(this.frm_shaiinrisuto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_shaiinrisuto)).EndInit();
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grd_shaiinrisuto;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel panel1;
    }
}