namespace GUI
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInfomation = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnQuanLy = new System.Windows.Forms.Button();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.panTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGiay = new System.Windows.Forms.Label();
            this.lblPhut = new System.Windows.Forms.Label();
            this.lblGio = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblLoaiTaiKhoan = new System.Windows.Forms.Label();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.lblNameStore = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.banHang1 = new GUI.BanHang();
            this.quanLy1 = new GUI.QuanLy();
            this.timeBlock = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnInfomation);
            this.panel1.Controls.Add(this.btnThongKe);
            this.panel1.Controls.Add(this.btnQuanLy);
            this.panel1.Controls.Add(this.btnBanHang);
            this.panel1.Controls.Add(this.btnTrangChu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 609);
            this.panel1.TabIndex = 0;
            // 
            // btnInfomation
            // 
            this.btnInfomation.BackColor = System.Drawing.Color.Bisque;
            this.btnInfomation.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfomation.ForeColor = System.Drawing.Color.Crimson;
            this.btnInfomation.Location = new System.Drawing.Point(10, 288);
            this.btnInfomation.Name = "btnInfomation";
            this.btnInfomation.Size = new System.Drawing.Size(139, 49);
            this.btnInfomation.TabIndex = 4;
            this.btnInfomation.Text = "Thông Tin";
            this.btnInfomation.UseVisualStyleBackColor = false;
            this.btnInfomation.Click += new System.EventHandler(this.btnInfomation_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.Bisque;
            this.btnThongKe.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.Crimson;
            this.btnThongKe.Location = new System.Drawing.Point(10, 219);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(139, 49);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnQuanLy
            // 
            this.btnQuanLy.BackColor = System.Drawing.Color.Bisque;
            this.btnQuanLy.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLy.ForeColor = System.Drawing.Color.Crimson;
            this.btnQuanLy.Location = new System.Drawing.Point(10, 148);
            this.btnQuanLy.Name = "btnQuanLy";
            this.btnQuanLy.Size = new System.Drawing.Size(139, 49);
            this.btnQuanLy.TabIndex = 2;
            this.btnQuanLy.Text = "Quản Lý";
            this.btnQuanLy.UseVisualStyleBackColor = false;
            this.btnQuanLy.Click += new System.EventHandler(this.btnQuanLy_Click);
            // 
            // btnBanHang
            // 
            this.btnBanHang.BackColor = System.Drawing.Color.Bisque;
            this.btnBanHang.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanHang.ForeColor = System.Drawing.Color.Crimson;
            this.btnBanHang.Location = new System.Drawing.Point(10, 76);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(139, 49);
            this.btnBanHang.TabIndex = 1;
            this.btnBanHang.Text = "Bán Hàng";
            this.btnBanHang.UseVisualStyleBackColor = false;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.BackColor = System.Drawing.Color.Bisque;
            this.btnTrangChu.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChu.ForeColor = System.Drawing.Color.Crimson;
            this.btnTrangChu.Location = new System.Drawing.Point(10, 11);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(139, 49);
            this.btnTrangChu.TabIndex = 0;
            this.btnTrangChu.Text = "Trang Chủ";
            this.btnTrangChu.UseVisualStyleBackColor = false;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // panTop
            // 
            this.panTop.BackColor = System.Drawing.Color.SaddleBrown;
            this.panTop.Controls.Add(this.label1);
            this.panTop.Controls.Add(this.lblGiay);
            this.panTop.Controls.Add(this.lblPhut);
            this.panTop.Controls.Add(this.lblGio);
            this.panTop.Controls.Add(this.button1);
            this.panTop.Controls.Add(this.lblLoaiTaiKhoan);
            this.panTop.Controls.Add(this.lblTaiKhoan);
            this.panTop.Controls.Add(this.lblNameStore);
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(156, 0);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(1048, 58);
            this.panTop.TabIndex = 2;
            this.panTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panTop_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(754, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Đăng xuất";
            // 
            // lblGiay
            // 
            this.lblGiay.AutoSize = true;
            this.lblGiay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGiay.Location = new System.Drawing.Point(636, 30);
            this.lblGiay.Name = "lblGiay";
            this.lblGiay.Size = new System.Drawing.Size(21, 13);
            this.lblGiay.TabIndex = 6;
            this.lblGiay.Text = "00";
            // 
            // lblPhut
            // 
            this.lblPhut.AutoSize = true;
            this.lblPhut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPhut.Location = new System.Drawing.Point(611, 30);
            this.lblPhut.Name = "lblPhut";
            this.lblPhut.Size = new System.Drawing.Size(21, 13);
            this.lblPhut.TabIndex = 5;
            this.lblPhut.Text = "00";
            // 
            // lblGio
            // 
            this.lblGio.AutoSize = true;
            this.lblGio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGio.Location = new System.Drawing.Point(586, 30);
            this.lblGio.Name = "lblGio";
            this.lblGio.Size = new System.Drawing.Size(21, 13);
            this.lblGio.TabIndex = 4;
            this.lblGio.Text = "00";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Image = global::GUI.Properties.Resources.icons8_export_301;
            this.button1.Location = new System.Drawing.Point(751, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 31);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblLoaiTaiKhoan
            // 
            this.lblLoaiTaiKhoan.AutoSize = true;
            this.lblLoaiTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiTaiKhoan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLoaiTaiKhoan.Location = new System.Drawing.Point(627, 11);
            this.lblLoaiTaiKhoan.Name = "lblLoaiTaiKhoan";
            this.lblLoaiTaiKhoan.Size = new System.Drawing.Size(41, 13);
            this.lblLoaiTaiKhoan.TabIndex = 2;
            this.lblLoaiTaiKhoan.Text = "Admin";
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaiKhoan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTaiKhoan.Location = new System.Drawing.Point(542, 10);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(73, 13);
            this.lblTaiKhoan.TabIndex = 1;
            this.lblTaiKhoan.Text = "Tài Khoản :";
            // 
            // lblNameStore
            // 
            this.lblNameStore.AutoSize = true;
            this.lblNameStore.BackColor = System.Drawing.Color.SaddleBrown;
            this.lblNameStore.Font = new System.Drawing.Font("Cooper Std Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameStore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNameStore.Location = new System.Drawing.Point(6, 12);
            this.lblNameStore.Name = "lblNameStore";
            this.lblNameStore.Size = new System.Drawing.Size(149, 26);
            this.lblNameStore.TabIndex = 0;
            this.lblNameStore.Text = "HHT Coffee";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.banHang1);
            this.panel2.Controls.Add(this.quanLy1);
            this.panel2.Location = new System.Drawing.Point(156, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(972, 591);
            this.panel2.TabIndex = 3;
            // 
            // banHang1
            // 
            this.banHang1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.banHang1.Location = new System.Drawing.Point(0, 0);
            this.banHang1.maNV = 0;
            this.banHang1.Margin = new System.Windows.Forms.Padding(4);
            this.banHang1.Name = "banHang1";
            this.banHang1.Size = new System.Drawing.Size(972, 591);
            this.banHang1.TabIndex = 1;
            this.banHang1.Load += new System.EventHandler(this.banHang1_Load);
            // 
            // quanLy1
            // 
            this.quanLy1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quanLy1.Location = new System.Drawing.Point(0, 0);
            this.quanLy1.Margin = new System.Windows.Forms.Padding(4);
            this.quanLy1.Name = "quanLy1";
            this.quanLy1.Size = new System.Drawing.Size(972, 591);
            this.quanLy1.TabIndex = 0;
            // 
            // timeBlock
            // 
            this.timeBlock.Tick += new System.EventHandler(this.timeBlock_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 609);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panTop);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Quản Lí Cửa Hàng Cafe";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panTop.ResumeLayout(false);
            this.panTop.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInfomation;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnQuanLy;
        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.Button btnTrangChu;
        private System.Windows.Forms.Panel panTop;
        private System.Windows.Forms.Label lblGiay;
        private System.Windows.Forms.Label lblPhut;
        private System.Windows.Forms.Label lblGio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblLoaiTaiKhoan;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.Label lblNameStore;
        private System.Windows.Forms.Panel panel2;
        private BanHang banHang1;
        private QuanLy quanLy1;
        private System.Windows.Forms.Timer timeBlock;
        private System.Windows.Forms.Label label1;
    }
}