namespace GUI
{
    partial class QuanLy
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuQuanLy = new System.Windows.Forms.MenuStrip();
            this.quảnLýHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýDoanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýBànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýLoạiBànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyDoanhThu1 = new GUI.QuanLyDoanhThu();
            this.quanLyHoaDon1 = new GUI.QuanLyHoaDon();
            this.quanLyNhanVien1 = new GUI.QuanLyNhanVien();
            this.quanLySanPham1 = new GUI.QuanLySanPham();
            this.menuQuanLy.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuQuanLy
            // 
            this.menuQuanLy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuQuanLy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýHóaĐơnToolStripMenuItem,
            this.quảnLýNhânViênToolStripMenuItem,
            this.quảnLýSảnPhẩmToolStripMenuItem,
            this.quảnLýDoanhThuToolStripMenuItem,
            this.quảnLýBànToolStripMenuItem,
            this.quảnLýLoạiBànToolStripMenuItem});
            this.menuQuanLy.Location = new System.Drawing.Point(0, 0);
            this.menuQuanLy.Name = "menuQuanLy";
            this.menuQuanLy.Size = new System.Drawing.Size(989, 24);
            this.menuQuanLy.TabIndex = 0;
            this.menuQuanLy.Text = "menuStrip1";
            // 
            // quảnLýHóaĐơnToolStripMenuItem
            // 
            this.quảnLýHóaĐơnToolStripMenuItem.Name = "quảnLýHóaĐơnToolStripMenuItem";
            this.quảnLýHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.quảnLýHóaĐơnToolStripMenuItem.Text = "Quản Lý Hóa Đơn";
            this.quảnLýHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.quảnLýHóaĐơnToolStripMenuItem_Click);
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản Lý Nhân Viên";
            this.quảnLýNhânViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNhânViênToolStripMenuItem_Click);
            // 
            // quảnLýSảnPhẩmToolStripMenuItem
            // 
            this.quảnLýSảnPhẩmToolStripMenuItem.Name = "quảnLýSảnPhẩmToolStripMenuItem";
            this.quảnLýSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.quảnLýSảnPhẩmToolStripMenuItem.Text = "Quản Lý Sản Phẩm";
            this.quảnLýSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.quảnLýSảnPhẩmToolStripMenuItem_Click);
            // 
            // quảnLýDoanhThuToolStripMenuItem
            // 
            this.quảnLýDoanhThuToolStripMenuItem.Name = "quảnLýDoanhThuToolStripMenuItem";
            this.quảnLýDoanhThuToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.quảnLýDoanhThuToolStripMenuItem.Text = "Quản Lý Doanh Thu";
            this.quảnLýDoanhThuToolStripMenuItem.Click += new System.EventHandler(this.quảnLýDoanhThuToolStripMenuItem_Click);
            // 
            // quảnLýBànToolStripMenuItem
            // 
            this.quảnLýBànToolStripMenuItem.Name = "quảnLýBànToolStripMenuItem";
            this.quảnLýBànToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.quảnLýBànToolStripMenuItem.Text = "Quản Lý Bàn";
            // 
            // quảnLýLoạiBànToolStripMenuItem
            // 
            this.quảnLýLoạiBànToolStripMenuItem.Name = "quảnLýLoạiBànToolStripMenuItem";
            this.quảnLýLoạiBànToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.quảnLýLoạiBànToolStripMenuItem.Text = "Quản Lý Loại Bàn";
            // 
            // quanLyDoanhThu1
            // 
            this.quanLyDoanhThu1.Location = new System.Drawing.Point(0, 27);
            this.quanLyDoanhThu1.Name = "quanLyDoanhThu1";
            this.quanLyDoanhThu1.Size = new System.Drawing.Size(986, 481);
            this.quanLyDoanhThu1.TabIndex = 1;
            // 
            // quanLyHoaDon1
            // 
            this.quanLyHoaDon1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quanLyHoaDon1.Location = new System.Drawing.Point(0, 24);
            this.quanLyHoaDon1.Name = "quanLyHoaDon1";
            this.quanLyHoaDon1.Size = new System.Drawing.Size(989, 414);
            this.quanLyHoaDon1.TabIndex = 2;
            // 
            // quanLyNhanVien1
            // 
            this.quanLyNhanVien1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quanLyNhanVien1.Location = new System.Drawing.Point(0, 24);
            this.quanLyNhanVien1.Name = "quanLyNhanVien1";
            this.quanLyNhanVien1.Size = new System.Drawing.Size(989, 414);
            this.quanLyNhanVien1.TabIndex = 3;
            // 
            // quanLySanPham1
            // 
            this.quanLySanPham1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quanLySanPham1.Location = new System.Drawing.Point(0, 24);
            this.quanLySanPham1.Name = "quanLySanPham1";
            this.quanLySanPham1.Size = new System.Drawing.Size(989, 414);
            this.quanLySanPham1.TabIndex = 4;
            // 
            // QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.quanLySanPham1);
            this.Controls.Add(this.quanLyNhanVien1);
            this.Controls.Add(this.quanLyHoaDon1);
            this.Controls.Add(this.quanLyDoanhThu1);
            this.Controls.Add(this.menuQuanLy);
            this.Name = "QuanLy";
            this.Size = new System.Drawing.Size(989, 438);
            this.menuQuanLy.ResumeLayout(false);
            this.menuQuanLy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýDoanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýBànToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLoạiBànToolStripMenuItem;
        private QuanLyDoanhThu quanLyDoanhThu1;
        private QuanLyHoaDon quanLyHoaDon1;
        private QuanLyNhanVien quanLyNhanVien1;
        private QuanLySanPham quanLySanPham1;
    }
}
