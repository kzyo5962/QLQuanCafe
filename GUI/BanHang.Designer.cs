namespace GUI
{
    partial class BanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BanHang));
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBan = new System.Windows.Forms.Label();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.pHoaDon = new System.Windows.Forms.Panel();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.drvHoaDon = new System.Windows.Forms.DataGridView();
            this.MaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThucUong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pGoiMon = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHuyBan = new System.Windows.Forms.Button();
            this.btnGoiMon = new System.Windows.Forms.Button();
            this.btnDatCho = new System.Windows.Forms.Button();
            this.lblMaBan = new System.Windows.Forms.Label();
            this.lblBanCLick = new System.Windows.Forms.Label();
            this.lblGioDen = new System.Windows.Forms.Label();
            this.pButtonDatMon = new System.Windows.Forms.Panel();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.pMenuPhucVu = new System.Windows.Forms.Panel();
            this.imageListIcon = new System.Windows.Forms.ImageList(this.components);
            this.fPannelBan = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.pHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drvHoaDon)).BeginInit();
            this.pGoiMon.SuspendLayout();
            this.pButtonDatMon.SuspendLayout();
            this.pMenuPhucVu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(48, 185);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(118, 20);
            this.txtGia.TabIndex = 4;
            this.txtGia.TextChanged += new System.EventHandler(this.txtGia_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số Lượng:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblBan
            // 
            this.lblBan.AutoSize = true;
            this.lblBan.Location = new System.Drawing.Point(45, 16);
            this.lblBan.Name = "lblBan";
            this.lblBan.Size = new System.Drawing.Size(13, 13);
            this.lblBan.TabIndex = 2;
            this.lblBan.Text = "9";
            this.lblBan.Click += new System.EventHandler(this.lblBan_Click);
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(73, 150);
            this.nudSoLuong.Maximum = new decimal(new int[] {
            1500000,
            0,
            0,
            0});
            this.nudSoLuong.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            -2147483648});
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(120, 20);
            this.nudSoLuong.TabIndex = 0;
            this.nudSoLuong.ValueChanged += new System.EventHandler(this.nudSoLuong_ValueChanged);
            // 
            // pHoaDon
            // 
            this.pHoaDon.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pHoaDon.Controls.Add(this.btnThanhToan);
            this.pHoaDon.Controls.Add(this.btnThemMon);
            this.pHoaDon.Controls.Add(this.drvHoaDon);
            this.pHoaDon.Location = new System.Drawing.Point(19, 120);
            this.pHoaDon.Name = "pHoaDon";
            this.pHoaDon.Size = new System.Drawing.Size(406, 181);
            this.pHoaDon.TabIndex = 8;
            this.pHoaDon.Visible = false;
            this.pHoaDon.Paint += new System.Windows.Forms.PaintEventHandler(this.pHoaDon_Paint);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(320, 43);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(75, 23);
            this.btnThanhToan.TabIndex = 2;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnThemMon
            // 
            this.btnThemMon.Location = new System.Drawing.Point(320, 14);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(75, 23);
            this.btnThemMon.TabIndex = 1;
            this.btnThemMon.Text = "Thêm Món";
            this.btnThemMon.UseVisualStyleBackColor = true;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // drvHoaDon
            // 
            this.drvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.drvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBan,
            this.TenThucUong,
            this.SoLuong,
            this.Column4,
            this.ThanhTien});
            this.drvHoaDon.Location = new System.Drawing.Point(3, 3);
            this.drvHoaDon.Name = "drvHoaDon";
            this.drvHoaDon.ReadOnly = true;
            this.drvHoaDon.Size = new System.Drawing.Size(311, 150);
            this.drvHoaDon.TabIndex = 0;
            this.drvHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drvHoaDon_CellContentClick);
            // 
            // MaBan
            // 
            this.MaBan.DataPropertyName = "MaBan";
            this.MaBan.HeaderText = "Mã Bàn";
            this.MaBan.Name = "MaBan";
            this.MaBan.ReadOnly = true;
            // 
            // TenThucUong
            // 
            this.TenThucUong.DataPropertyName = "TenThucUong";
            this.TenThucUong.HeaderText = "Tên Món";
            this.TenThucUong.Name = "TenThucUong";
            this.TenThucUong.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Sô Lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Đơn Giá";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(91, 222);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Hùy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(10, 222);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Đồng Ý";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Giá:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pGoiMon
            // 
            this.pGoiMon.Controls.Add(this.btnHuy);
            this.pGoiMon.Controls.Add(this.btnOk);
            this.pGoiMon.Controls.Add(this.label4);
            this.pGoiMon.Controls.Add(this.txtGia);
            this.pGoiMon.Controls.Add(this.label3);
            this.pGoiMon.Controls.Add(this.lblBan);
            this.pGoiMon.Controls.Add(this.label2);
            this.pGoiMon.Controls.Add(this.nudSoLuong);
            this.pGoiMon.Location = new System.Drawing.Point(3, 3);
            this.pGoiMon.Name = "pGoiMon";
            this.pGoiMon.Size = new System.Drawing.Size(453, 363);
            this.pGoiMon.TabIndex = 6;
            this.pGoiMon.Visible = false;
            this.pGoiMon.Paint += new System.Windows.Forms.PaintEventHandler(this.pGoiMon_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bàn: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnHuyBan
            // 
            this.btnHuyBan.Location = new System.Drawing.Point(60, 22);
            this.btnHuyBan.Name = "btnHuyBan";
            this.btnHuyBan.Size = new System.Drawing.Size(75, 23);
            this.btnHuyBan.TabIndex = 2;
            this.btnHuyBan.Text = "Hủy Bàn";
            this.btnHuyBan.UseVisualStyleBackColor = true;
            this.btnHuyBan.Visible = false;
            this.btnHuyBan.Click += new System.EventHandler(this.btnHuyBan_Click);
            // 
            // btnGoiMon
            // 
            this.btnGoiMon.Location = new System.Drawing.Point(108, 22);
            this.btnGoiMon.Name = "btnGoiMon";
            this.btnGoiMon.Size = new System.Drawing.Size(75, 23);
            this.btnGoiMon.TabIndex = 1;
            this.btnGoiMon.Text = "Gọi Món";
            this.btnGoiMon.UseVisualStyleBackColor = true;
            this.btnGoiMon.Click += new System.EventHandler(this.btnGoiMon_Click);
            // 
            // btnDatCho
            // 
            this.btnDatCho.Location = new System.Drawing.Point(15, 22);
            this.btnDatCho.Name = "btnDatCho";
            this.btnDatCho.Size = new System.Drawing.Size(75, 23);
            this.btnDatCho.TabIndex = 0;
            this.btnDatCho.Text = "Đặt Chỗ";
            this.btnDatCho.UseVisualStyleBackColor = true;
            this.btnDatCho.Click += new System.EventHandler(this.btnDatCho_Click);
            // 
            // lblMaBan
            // 
            this.lblMaBan.AutoSize = true;
            this.lblMaBan.Location = new System.Drawing.Point(90, 21);
            this.lblMaBan.Name = "lblMaBan";
            this.lblMaBan.Size = new System.Drawing.Size(19, 13);
            this.lblMaBan.TabIndex = 4;
            this.lblMaBan.Text = "__";
            this.lblMaBan.Click += new System.EventHandler(this.lblMaBan_Click);
            // 
            // lblBanCLick
            // 
            this.lblBanCLick.AutoSize = true;
            this.lblBanCLick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanCLick.Location = new System.Drawing.Point(49, 16);
            this.lblBanCLick.Name = "lblBanCLick";
            this.lblBanCLick.Size = new System.Drawing.Size(46, 20);
            this.lblBanCLick.TabIndex = 0;
            this.lblBanCLick.Text = "Bàn:";
            this.lblBanCLick.Click += new System.EventHandler(this.lblBanCLick_Click);
            // 
            // lblGioDen
            // 
            this.lblGioDen.AutoSize = true;
            this.lblGioDen.Location = new System.Drawing.Point(16, 56);
            this.lblGioDen.Name = "lblGioDen";
            this.lblGioDen.Size = new System.Drawing.Size(61, 13);
            this.lblGioDen.TabIndex = 1;
            this.lblGioDen.Text = "Giờ Đến:__";
            this.lblGioDen.Click += new System.EventHandler(this.lblGioDen_Click);
            // 
            // pButtonDatMon
            // 
            this.pButtonDatMon.Controls.Add(this.btnHuyBan);
            this.pButtonDatMon.Controls.Add(this.btnGoiMon);
            this.pButtonDatMon.Controls.Add(this.btnDatCho);
            this.pButtonDatMon.Location = new System.Drawing.Point(134, 45);
            this.pButtonDatMon.Name = "pButtonDatMon";
            this.pButtonDatMon.Size = new System.Drawing.Size(197, 57);
            this.pButtonDatMon.TabIndex = 3;
            this.pButtonDatMon.Visible = false;
            this.pButtonDatMon.Paint += new System.Windows.Forms.PaintEventHandler(this.pButtonDatMon_Paint);
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(16, 89);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(58, 13);
            this.lblTrangThai.TabIndex = 2;
            this.lblTrangThai.Text = "Trạng thái:";
            this.lblTrangThai.Click += new System.EventHandler(this.lblTrangThai_Click);
            // 
            // pMenuPhucVu
            // 
            this.pMenuPhucVu.Controls.Add(this.pHoaDon);
            this.pMenuPhucVu.Controls.Add(this.lblMaBan);
            this.pMenuPhucVu.Controls.Add(this.lblBanCLick);
            this.pMenuPhucVu.Controls.Add(this.lblGioDen);
            this.pMenuPhucVu.Controls.Add(this.pButtonDatMon);
            this.pMenuPhucVu.Controls.Add(this.lblTrangThai);
            this.pMenuPhucVu.Controls.Add(this.pGoiMon);
            this.pMenuPhucVu.Location = new System.Drawing.Point(274, 3);
            this.pMenuPhucVu.Name = "pMenuPhucVu";
            this.pMenuPhucVu.Size = new System.Drawing.Size(825, 388);
            this.pMenuPhucVu.TabIndex = 6;
            this.pMenuPhucVu.Paint += new System.Windows.Forms.PaintEventHandler(this.pMenuPhucVu_Paint);
            // 
            // imageListIcon
            // 
            this.imageListIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListIcon.ImageStream")));
            this.imageListIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListIcon.Images.SetKeyName(0, "icons8-table-26.png");
            this.imageListIcon.Images.SetKeyName(1, "icons8-table-64.png");
            // 
            // fPannelBan
            // 
            this.fPannelBan.AutoScroll = true;
            this.fPannelBan.BackColor = System.Drawing.Color.BurlyWood;
            this.fPannelBan.Location = new System.Drawing.Point(3, 3);
            this.fPannelBan.Name = "fPannelBan";
            this.fPannelBan.Size = new System.Drawing.Size(265, 493);
            this.fPannelBan.TabIndex = 4;
            this.fPannelBan.Paint += new System.Windows.Forms.PaintEventHandler(this.fPannelBan_Paint);
            // 
            // BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pMenuPhucVu);
            this.Controls.Add(this.fPannelBan);
            this.Name = "BanHang";
            this.Size = new System.Drawing.Size(886, 449);
            this.Load += new System.EventHandler(this.BanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.pHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drvHoaDon)).EndInit();
            this.pGoiMon.ResumeLayout(false);
            this.pGoiMon.PerformLayout();
            this.pButtonDatMon.ResumeLayout(false);
            this.pMenuPhucVu.ResumeLayout(false);
            this.pMenuPhucVu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBan;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Panel pHoaDon;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.DataGridView drvHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThucUong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pGoiMon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHuyBan;
        private System.Windows.Forms.Button btnGoiMon;
        private System.Windows.Forms.Button btnDatCho;
        private System.Windows.Forms.Label lblMaBan;
        private System.Windows.Forms.Label lblBanCLick;
        private System.Windows.Forms.Label lblGioDen;
        private System.Windows.Forms.Panel pButtonDatMon;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Panel pMenuPhucVu;
        private System.Windows.Forms.ImageList imageListIcon;
        private System.Windows.Forms.FlowLayoutPanel fPannelBan;
    }
}
