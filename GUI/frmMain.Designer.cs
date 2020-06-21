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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInfomation = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnQuanLy = new System.Windows.Forms.Button();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.panHover = new System.Windows.Forms.Panel();
            this.panTop = new System.Windows.Forms.Panel();
            this.lblGiay = new System.Windows.Forms.Label();
            this.lblPhut = new System.Windows.Forms.Label();
            this.lblGio = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblLoaiTaiKhoan = new System.Windows.Forms.Label();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.lblNameStore = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timeBlock = new System.Windows.Forms.Timer(this.components);
            this.banHang1 = new GUI.BanHang();
            this.quanLy1 = new GUI.QuanLy();
            this.panel1.SuspendLayout();
            this.panTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
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
            this.panel1.Size = new System.Drawing.Size(156, 472);
            this.panel1.TabIndex = 0;
            // 
            // btnInfomation
            // 
            this.btnInfomation.BackColor = System.Drawing.Color.Bisque;
            this.btnInfomation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnTrangChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChu.ForeColor = System.Drawing.Color.Crimson;
            this.btnTrangChu.Location = new System.Drawing.Point(10, 11);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(139, 49);
            this.btnTrangChu.TabIndex = 0;
            this.btnTrangChu.Text = "Trang Chủ";
            this.btnTrangChu.UseVisualStyleBackColor = false;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // panHover
            // 
            this.panHover.BackColor = System.Drawing.Color.Red;
            this.panHover.Location = new System.Drawing.Point(2, 12);
            this.panHover.Name = "panHover";
            this.panHover.Size = new System.Drawing.Size(10, 47);
            this.panHover.TabIndex = 1;
            // 
            // panTop
            // 
            this.panTop.BackColor = System.Drawing.Color.Red;
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
            this.panTop.Size = new System.Drawing.Size(972, 58);
            this.panTop.TabIndex = 2;
            // 
            // lblGiay
            // 
            this.lblGiay.AutoSize = true;
            this.lblGiay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiay.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblGiay.Location = new System.Drawing.Point(714, 31);
            this.lblGiay.Name = "lblGiay";
            this.lblGiay.Size = new System.Drawing.Size(21, 13);
            this.lblGiay.TabIndex = 6;
            this.lblGiay.Text = "00";
            // 
            // lblPhut
            // 
            this.lblPhut.AutoSize = true;
            this.lblPhut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhut.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblPhut.Location = new System.Drawing.Point(689, 31);
            this.lblPhut.Name = "lblPhut";
            this.lblPhut.Size = new System.Drawing.Size(21, 13);
            this.lblPhut.TabIndex = 5;
            this.lblPhut.Text = "00";
            // 
            // lblGio
            // 
            this.lblGio.AutoSize = true;
            this.lblGio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGio.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblGio.Location = new System.Drawing.Point(664, 31);
            this.lblGio.Name = "lblGio";
            this.lblGio.Size = new System.Drawing.Size(21, 13);
            this.lblGio.TabIndex = 4;
            this.lblGio.Text = "00";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(773, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblLoaiTaiKhoan
            // 
            this.lblLoaiTaiKhoan.AutoSize = true;
            this.lblLoaiTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiTaiKhoan.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblLoaiTaiKhoan.Location = new System.Drawing.Point(705, 12);
            this.lblLoaiTaiKhoan.Name = "lblLoaiTaiKhoan";
            this.lblLoaiTaiKhoan.Size = new System.Drawing.Size(41, 13);
            this.lblLoaiTaiKhoan.TabIndex = 2;
            this.lblLoaiTaiKhoan.Text = "Admin";
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaiKhoan.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTaiKhoan.Location = new System.Drawing.Point(620, 11);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(65, 13);
            this.lblTaiKhoan.TabIndex = 1;
            this.lblTaiKhoan.Text = "Tài Khoản";
            // 
            // lblNameStore
            // 
            this.lblNameStore.AutoSize = true;
            this.lblNameStore.BackColor = System.Drawing.Color.Red;
            this.lblNameStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameStore.ForeColor = System.Drawing.SystemColors.Window;
            this.lblNameStore.Location = new System.Drawing.Point(6, 12);
            this.lblNameStore.Name = "lblNameStore";
            this.lblNameStore.Size = new System.Drawing.Size(317, 25);
            this.lblNameStore.TabIndex = 0;
            this.lblNameStore.Text = "Hệ Thống Chuỗi Cà Phê TTN";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.banHang1);
            this.panel2.Controls.Add(this.quanLy1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(156, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(972, 414);
            this.panel2.TabIndex = 3;
            // 
            // timeBlock
            // 
            this.timeBlock.Tick += new System.EventHandler(this.timeBlock_Tick);
            // 
            // banHang1
            // 
            this.banHang1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.banHang1.Location = new System.Drawing.Point(0, 0);
            this.banHang1.Name = "banHang1";
            this.banHang1.Size = new System.Drawing.Size(972, 414);
            this.banHang1.TabIndex = 1;
            // 
            // quanLy1
            // 
            this.quanLy1.Location = new System.Drawing.Point(-1, 0);
            this.quanLy1.Name = "quanLy1";
            this.quanLy1.Size = new System.Drawing.Size(989, 438);
            this.quanLy1.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 472);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panTop);
            this.Controls.Add(this.panHover);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.Text = "frmMain";
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
        private System.Windows.Forms.Panel panHover;
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
    }
}