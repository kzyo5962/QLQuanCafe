namespace GUI
{
    partial class ThongKe
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thốngKêHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêDoanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêNhậpHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêTheoMónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_Tiltle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thốngKêHóaĐơnToolStripMenuItem,
            this.thốngKêDoanhThuToolStripMenuItem,
            this.thốngKêNhậpHàngToolStripMenuItem,
            this.thốngKêTheoMónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(946, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thốngKêHóaĐơnToolStripMenuItem
            // 
            this.thốngKêHóaĐơnToolStripMenuItem.Name = "thốngKêHóaĐơnToolStripMenuItem";
            this.thốngKêHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.thốngKêHóaĐơnToolStripMenuItem.Text = "Thống kê Hóa Đơn";
            // 
            // thốngKêDoanhThuToolStripMenuItem
            // 
            this.thốngKêDoanhThuToolStripMenuItem.Name = "thốngKêDoanhThuToolStripMenuItem";
            this.thốngKêDoanhThuToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.thốngKêDoanhThuToolStripMenuItem.Text = "Thống Kê Doanh Thu";
            // 
            // thốngKêNhậpHàngToolStripMenuItem
            // 
            this.thốngKêNhậpHàngToolStripMenuItem.Name = "thốngKêNhậpHàngToolStripMenuItem";
            this.thốngKêNhậpHàngToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.thốngKêNhậpHàngToolStripMenuItem.Text = "Thống kê Nhập Hàng";
            // 
            // thốngKêTheoMónToolStripMenuItem
            // 
            this.thốngKêTheoMónToolStripMenuItem.Name = "thốngKêTheoMónToolStripMenuItem";
            this.thốngKêTheoMónToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.thốngKêTheoMónToolStripMenuItem.Text = "Thống kê Theo Món";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.lb_Tiltle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 48);
            this.panel1.TabIndex = 17;
            // 
            // lb_Tiltle
            // 
            this.lb_Tiltle.AutoSize = true;
            this.lb_Tiltle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Tiltle.ForeColor = System.Drawing.Color.Black;
            this.lb_Tiltle.Location = new System.Drawing.Point(404, 12);
            this.lb_Tiltle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Tiltle.Name = "lb_Tiltle";
            this.lb_Tiltle.Size = new System.Drawing.Size(210, 22);
            this.lb_Tiltle.TabIndex = 8;
            this.lb_Tiltle.Text = "THỐNG KÊ HÓA ĐƠN";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(946, 430);
            this.panel2.TabIndex = 18;
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ThongKe";
            this.Size = new System.Drawing.Size(946, 502);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thốngKêHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêDoanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêNhậpHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêTheoMónToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_Tiltle;
        private System.Windows.Forms.Panel panel2;
    }
}
