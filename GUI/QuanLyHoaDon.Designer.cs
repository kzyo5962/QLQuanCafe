namespace GUI
{
    partial class QuanLyHoaDon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_Tiltle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.col_MaNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbThongTinHoaDon = new System.Windows.Forms.Label();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.lbMaHD = new System.Windows.Forms.Label();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.lbGiamGia = new System.Windows.Forms.Label();
            this.txtMaBan = new System.Windows.Forms.TextBox();
            this.txtSoHD = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.lbMaBan = new System.Windows.Forms.Label();
            this.lbSoHD = new System.Windows.Forms.Label();
            this.lbCMND = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.lb_Tiltle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 48);
            this.panel1.TabIndex = 11;
            // 
            // lb_Tiltle
            // 
            this.lb_Tiltle.AutoSize = true;
            this.lb_Tiltle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Tiltle.ForeColor = System.Drawing.Color.Black;
            this.lb_Tiltle.Location = new System.Drawing.Point(404, 12);
            this.lb_Tiltle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Tiltle.Name = "lb_Tiltle";
            this.lb_Tiltle.Size = new System.Drawing.Size(185, 22);
            this.lb_Tiltle.TabIndex = 8;
            this.lb_Tiltle.Text = "QUẢN LÍ HÓA ĐƠN";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dgvHoaDon);
            this.panel2.Controls.Add(this.btnTimKiem);
            this.panel2.Controls.Add(this.txtTimKiem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(871, 474);
            this.panel2.TabIndex = 12;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Coral;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimKiem.Location = new System.Drawing.Point(11, 14);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(76, 35);
            this.btnTimKiem.TabIndex = 26;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(92, 14);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(124, 35);
            this.txtTimKiem.TabIndex = 25;
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.Moccasin;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaNL,
            this.colCMND,
            this.colSoHoaDon,
            this.colMaBan,
            this.colGiamGia});
            this.dgvHoaDon.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvHoaDon.Location = new System.Drawing.Point(11, 61);
            this.dgvHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.Size = new System.Drawing.Size(412, 411);
            this.dgvHoaDon.TabIndex = 27;
            // 
            // col_MaNL
            // 
            this.col_MaNL.DataPropertyName = "strNguyenLieu";
            this.col_MaNL.HeaderText = "Mã NL";
            this.col_MaNL.MinimumWidth = 6;
            this.col_MaNL.Name = "col_MaNL";
            // 
            // colCMND
            // 
            this.colCMND.DataPropertyName = "none";
            this.colCMND.HeaderText = "CMND";
            this.colCMND.MinimumWidth = 6;
            this.colCMND.Name = "colCMND";
            // 
            // colSoHoaDon
            // 
            this.colSoHoaDon.HeaderText = "Số hóa đơn";
            this.colSoHoaDon.MinimumWidth = 6;
            this.colSoHoaDon.Name = "colSoHoaDon";
            // 
            // colMaBan
            // 
            this.colMaBan.DataPropertyName = "none";
            this.colMaBan.HeaderText = "Mã bàn";
            this.colMaBan.MinimumWidth = 6;
            this.colMaBan.Name = "colMaBan";
            // 
            // colGiamGia
            // 
            this.colGiamGia.HeaderText = "Giảm giá";
            this.colGiamGia.MinimumWidth = 6;
            this.colGiamGia.Name = "colGiamGia";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCapNhat);
            this.panel3.Controls.Add(this.btn_Xoa);
            this.panel3.Controls.Add(this.btnThemMoi);
            this.panel3.Controls.Add(this.txtGiamGia);
            this.panel3.Controls.Add(this.lbGiamGia);
            this.panel3.Controls.Add(this.txtMaBan);
            this.panel3.Controls.Add(this.txtSoHD);
            this.panel3.Controls.Add(this.txtCMND);
            this.panel3.Controls.Add(this.lbMaBan);
            this.panel3.Controls.Add(this.lbSoHD);
            this.panel3.Controls.Add(this.lbCMND);
            this.panel3.Controls.Add(this.dtpNgayLap);
            this.panel3.Controls.Add(this.lbMaHD);
            this.panel3.Controls.Add(this.lbThongTinHoaDon);
            this.panel3.Location = new System.Drawing.Point(443, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(425, 428);
            this.panel3.TabIndex = 28;
            // 
            // lbThongTinHoaDon
            // 
            this.lbThongTinHoaDon.AutoSize = true;
            this.lbThongTinHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongTinHoaDon.Location = new System.Drawing.Point(107, 18);
            this.lbThongTinHoaDon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbThongTinHoaDon.Name = "lbThongTinHoaDon";
            this.lbThongTinHoaDon.Size = new System.Drawing.Size(202, 26);
            this.lbThongTinHoaDon.TabIndex = 36;
            this.lbThongTinHoaDon.Text = "Thông tin hóa đơn";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLap.Location = new System.Drawing.Point(110, 58);
            this.dtpNgayLap.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(137, 20);
            this.dtpNgayLap.TabIndex = 38;
            // 
            // lbMaHD
            // 
            this.lbMaHD.AutoSize = true;
            this.lbMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaHD.Location = new System.Drawing.Point(24, 60);
            this.lbMaHD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaHD.Name = "lbMaHD";
            this.lbMaHD.Size = new System.Drawing.Size(82, 17);
            this.lbMaHD.TabIndex = 37;
            this.lbMaHD.Text = "Ngày lập :";
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(114, 241);
            this.txtGiamGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtGiamGia.Multiline = true;
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(137, 31);
            this.txtGiamGia.TabIndex = 46;
            // 
            // lbGiamGia
            // 
            this.lbGiamGia.AutoSize = true;
            this.lbGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiamGia.Location = new System.Drawing.Point(28, 241);
            this.lbGiamGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGiamGia.Name = "lbGiamGia";
            this.lbGiamGia.Size = new System.Drawing.Size(72, 17);
            this.lbGiamGia.TabIndex = 45;
            this.lbGiamGia.Text = "Giảm giá";
            // 
            // txtMaBan
            // 
            this.txtMaBan.Location = new System.Drawing.Point(114, 185);
            this.txtMaBan.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaBan.Multiline = true;
            this.txtMaBan.Name = "txtMaBan";
            this.txtMaBan.Size = new System.Drawing.Size(137, 31);
            this.txtMaBan.TabIndex = 44;
            // 
            // txtSoHD
            // 
            this.txtSoHD.Location = new System.Drawing.Point(114, 137);
            this.txtSoHD.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoHD.Multiline = true;
            this.txtSoHD.Name = "txtSoHD";
            this.txtSoHD.Size = new System.Drawing.Size(137, 31);
            this.txtSoHD.TabIndex = 43;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(114, 90);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(2);
            this.txtCMND.Multiline = true;
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(137, 31);
            this.txtCMND.TabIndex = 42;
            // 
            // lbMaBan
            // 
            this.lbMaBan.AutoSize = true;
            this.lbMaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaBan.Location = new System.Drawing.Point(28, 185);
            this.lbMaBan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaBan.Name = "lbMaBan";
            this.lbMaBan.Size = new System.Drawing.Size(71, 17);
            this.lbMaBan.TabIndex = 41;
            this.lbMaBan.Text = "Mã bàn :";
            // 
            // lbSoHD
            // 
            this.lbSoHD.AutoSize = true;
            this.lbSoHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoHD.Location = new System.Drawing.Point(22, 137);
            this.lbSoHD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSoHD.Name = "lbSoHD";
            this.lbSoHD.Size = new System.Drawing.Size(91, 17);
            this.lbSoHD.TabIndex = 40;
            this.lbSoHD.Text = "Số hóa đơn";
            // 
            // lbCMND
            // 
            this.lbCMND.AutoSize = true;
            this.lbCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCMND.Location = new System.Drawing.Point(24, 90);
            this.lbCMND.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCMND.Name = "lbCMND";
            this.lbCMND.Size = new System.Drawing.Size(62, 17);
            this.lbCMND.TabIndex = 39;
            this.lbCMND.Text = "CMND :";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCapNhat.Location = new System.Drawing.Point(124, 300);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(76, 35);
            this.btnCapNhat.TabIndex = 49;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Xoa.Location = new System.Drawing.Point(217, 300);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(76, 35);
            this.btn_Xoa.TabIndex = 48;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.BackColor = System.Drawing.Color.ForestGreen;
            this.btnThemMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThemMoi.Location = new System.Drawing.Point(33, 300);
            this.btnThemMoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(76, 35);
            this.btnThemMoi.TabIndex = 47;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = false;
            // 
            // QuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyHoaDon";
            this.Size = new System.Drawing.Size(871, 522);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_Tiltle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.Label lbGiamGia;
        private System.Windows.Forms.TextBox txtMaBan;
        private System.Windows.Forms.TextBox txtSoHD;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label lbMaBan;
        private System.Windows.Forms.Label lbSoHD;
        private System.Windows.Forms.Label lbCMND;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Label lbMaHD;
        private System.Windows.Forms.Label lbThongTinHoaDon;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiamGia;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
    }
}
