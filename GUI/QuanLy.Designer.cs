﻿namespace GUI
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
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýBànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýDoanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýLoạiBànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyNhanVien1 = new GUI.QuanLyNhanVien();
            this.quanLyBan1 = new GUI.QuanLyBan();
            this.quanLySanPham1 = new GUI.QuanLyNguyenLieu();
            this.quanLyDoanhThu2 = new GUI.QuanLyDoanhThu();
            this.menuQuanLy.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuQuanLy
            // 
            this.menuQuanLy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuQuanLy.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuQuanLy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNhânViênToolStripMenuItem,
            this.quảnLýSảnPhẩmToolStripMenuItem,
            this.quảnLýBànToolStripMenuItem,
            this.quảnLýDoanhThuToolStripMenuItem,
            this.quảnLýLoạiBànToolStripMenuItem});
            this.menuQuanLy.Location = new System.Drawing.Point(0, 0);
            this.menuQuanLy.Name = "menuQuanLy";
            this.menuQuanLy.Size = new System.Drawing.Size(1251, 30);
            this.menuQuanLy.TabIndex = 0;
            this.menuQuanLy.Text = "menuStrip1";
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản Lý Nhân Viên";
            this.quảnLýNhânViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNhânViênToolStripMenuItem_Click);
            // 
            // quảnLýSảnPhẩmToolStripMenuItem
            // 
            this.quảnLýSảnPhẩmToolStripMenuItem.Name = "quảnLýSảnPhẩmToolStripMenuItem";
            this.quảnLýSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.quảnLýSảnPhẩmToolStripMenuItem.Text = "Quản Lý Sản Phẩm";
            this.quảnLýSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.quảnLýSảnPhẩmToolStripMenuItem_Click);
            // 
            // quảnLýBànToolStripMenuItem
            // 
            this.quảnLýBànToolStripMenuItem.Name = "quảnLýBànToolStripMenuItem";
            this.quảnLýBànToolStripMenuItem.Size = new System.Drawing.Size(104, 26);
            this.quảnLýBànToolStripMenuItem.Text = "Quản Lý Bàn";
            this.quảnLýBànToolStripMenuItem.Click += new System.EventHandler(this.quảnLýBànToolStripMenuItem_Click);
            // 
            // quảnLýDoanhThuToolStripMenuItem
            // 
            this.quảnLýDoanhThuToolStripMenuItem.Name = "quảnLýDoanhThuToolStripMenuItem";
            this.quảnLýDoanhThuToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.quảnLýDoanhThuToolStripMenuItem.Text = "Quản Lý Doanh Thu";
            this.quảnLýDoanhThuToolStripMenuItem.Click += new System.EventHandler(this.quảnLýDoanhThuToolStripMenuItem_Click);
            // 
            // quảnLýLoạiBànToolStripMenuItem
            // 
            this.quảnLýLoạiBànToolStripMenuItem.Name = "quảnLýLoạiBànToolStripMenuItem";
            this.quảnLýLoạiBànToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.quảnLýLoạiBànToolStripMenuItem.Text = "Quản Lý Loại Bàn";
            // 
            // quanLyNhanVien1
            // 
            this.quanLyNhanVien1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quanLyNhanVien1.Location = new System.Drawing.Point(0, 30);
            this.quanLyNhanVien1.Margin = new System.Windows.Forms.Padding(4);
            this.quanLyNhanVien1.Name = "quanLyNhanVien1";
            this.quanLyNhanVien1.Size = new System.Drawing.Size(1251, 675);
            this.quanLyNhanVien1.TabIndex = 2;
            // 
            // quanLyBan1
            // 
            this.quanLyBan1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quanLyBan1.Location = new System.Drawing.Point(0, 30);
            this.quanLyBan1.Name = "quanLyBan1";
            this.quanLyBan1.Size = new System.Drawing.Size(1251, 675);
            this.quanLyBan1.TabIndex = 3;
            this.quanLyBan1.Load += new System.EventHandler(this.quanLyBan1_Load);
            // 
            // quanLySanPham1
            // 
            this.quanLySanPham1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quanLySanPham1.Location = new System.Drawing.Point(0, 30);
            this.quanLySanPham1.Margin = new System.Windows.Forms.Padding(4);
            this.quanLySanPham1.Name = "quanLySanPham1";
            this.quanLySanPham1.Size = new System.Drawing.Size(1251, 675);
            this.quanLySanPham1.TabIndex = 4;
            // 
            // quanLyDoanhThu2
            // 
            this.quanLyDoanhThu2.BackColor = System.Drawing.Color.Aquamarine;
            this.quanLyDoanhThu2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quanLyDoanhThu2.Location = new System.Drawing.Point(0, 30);
            this.quanLyDoanhThu2.Margin = new System.Windows.Forms.Padding(4);
            this.quanLyDoanhThu2.Name = "quanLyDoanhThu2";
            this.quanLyDoanhThu2.Size = new System.Drawing.Size(1251, 675);
            this.quanLyDoanhThu2.TabIndex = 5;
            this.quanLyDoanhThu2.Load += new System.EventHandler(this.quanLyDoanhThu2_Load);
            // 
            // QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.quanLyBan1);
            this.Controls.Add(this.quanLyDoanhThu2);
            this.Controls.Add(this.quanLySanPham1);
            this.Controls.Add(this.quanLyNhanVien1);
            this.Controls.Add(this.menuQuanLy);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLy";
            this.Size = new System.Drawing.Size(1251, 705);
            this.Load += new System.EventHandler(this.QuanLy_Load);
            this.menuQuanLy.ResumeLayout(false);
            this.menuQuanLy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýDoanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýBànToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLoạiBànToolStripMenuItem;
        private QuanLyNhanVien quanLyNhanVien1;
        private QuanLyBan quanLyBan1;
        private QuanLyNguyenLieu quanLySanPham1;
        private QuanLyDoanhThu quanLyDoanhThu1;
        private QuanLyDoanhThu quanLyDoanhThu2;
    }
}
