namespace GUI
{
    partial class QuanLyDoanhThu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_Tiltle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtChi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTongQuyHienTai = new System.Windows.Forms.TextBox();
            this.txtDoanhThuThangNay = new System.Windows.Forms.TextBox();
            this.txtDoanhThuHomNay = new System.Windows.Forms.TextBox();
            this.lbTongQuy = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDoanhThuHomNay = new System.Windows.Forms.Label();
            this.dgvNguyenLieuTrongKho = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvSanPhamBanDuoc = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panDanhThuContent = new System.Windows.Forms.Panel();
            this.tenSP1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giamGia1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTien1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doanhThuDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tenNL1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dVT1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGia1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguyenLieuDTOBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.nguyenLieuDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nguyenLieuDTOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieuTrongKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPhamBanDuoc)).BeginInit();
            this.panDanhThuContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doanhThuDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguyenLieuDTOBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguyenLieuDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguyenLieuDTOBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.lb_Tiltle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1261, 59);
            this.panel1.TabIndex = 12;
            // 
            // lb_Tiltle
            // 
            this.lb_Tiltle.AutoSize = true;
            this.lb_Tiltle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Tiltle.ForeColor = System.Drawing.Color.Black;
            this.lb_Tiltle.Location = new System.Drawing.Point(545, 12);
            this.lb_Tiltle.Name = "lb_Tiltle";
            this.lb_Tiltle.Size = new System.Drawing.Size(253, 26);
            this.lb_Tiltle.TabIndex = 8;
            this.lb_Tiltle.Text = "QUẢN LÍ DOANH THU";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Khaki;
            this.panel3.Controls.Add(this.txtChi);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtTongQuyHienTai);
            this.panel3.Controls.Add(this.txtDoanhThuThangNay);
            this.panel3.Controls.Add(this.txtDoanhThuHomNay);
            this.panel3.Controls.Add(this.lbTongQuy);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lblDoanhThuHomNay);
            this.panel3.Location = new System.Drawing.Point(845, 64);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(365, 455);
            this.panel3.TabIndex = 22;
            // 
            // txtChi
            // 
            this.txtChi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChi.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtChi.Location = new System.Drawing.Point(79, 267);
            this.txtChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtChi.Multiline = true;
            this.txtChi.Name = "txtChi";
            this.txtChi.ReadOnly = true;
            this.txtChi.Size = new System.Drawing.Size(224, 30);
            this.txtChi.TabIndex = 18;
            this.txtChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(130, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Chi hôm nay";
            // 
            // txtTongQuyHienTai
            // 
            this.txtTongQuyHienTai.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTongQuyHienTai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongQuyHienTai.ForeColor = System.Drawing.Color.Firebrick;
            this.txtTongQuyHienTai.Location = new System.Drawing.Point(54, 377);
            this.txtTongQuyHienTai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongQuyHienTai.Multiline = true;
            this.txtTongQuyHienTai.Name = "txtTongQuyHienTai";
            this.txtTongQuyHienTai.ReadOnly = true;
            this.txtTongQuyHienTai.Size = new System.Drawing.Size(266, 43);
            this.txtTongQuyHienTai.TabIndex = 16;
            this.txtTongQuyHienTai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDoanhThuThangNay
            // 
            this.txtDoanhThuThangNay.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDoanhThuThangNay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoanhThuThangNay.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtDoanhThuThangNay.Location = new System.Drawing.Point(79, 162);
            this.txtDoanhThuThangNay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDoanhThuThangNay.Multiline = true;
            this.txtDoanhThuThangNay.Name = "txtDoanhThuThangNay";
            this.txtDoanhThuThangNay.ReadOnly = true;
            this.txtDoanhThuThangNay.Size = new System.Drawing.Size(224, 29);
            this.txtDoanhThuThangNay.TabIndex = 15;
            this.txtDoanhThuThangNay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDoanhThuHomNay
            // 
            this.txtDoanhThuHomNay.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDoanhThuHomNay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoanhThuHomNay.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtDoanhThuHomNay.Location = new System.Drawing.Point(79, 56);
            this.txtDoanhThuHomNay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDoanhThuHomNay.Multiline = true;
            this.txtDoanhThuHomNay.Name = "txtDoanhThuHomNay";
            this.txtDoanhThuHomNay.ReadOnly = true;
            this.txtDoanhThuHomNay.Size = new System.Drawing.Size(224, 27);
            this.txtDoanhThuHomNay.TabIndex = 13;
            this.txtDoanhThuHomNay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbTongQuy
            // 
            this.lbTongQuy.AutoSize = true;
            this.lbTongQuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongQuy.ForeColor = System.Drawing.Color.Black;
            this.lbTongQuy.Location = new System.Drawing.Point(89, 336);
            this.lbTongQuy.Name = "lbTongQuy";
            this.lbTongQuy.Size = new System.Drawing.Size(214, 29);
            this.lbTongQuy.TabIndex = 12;
            this.lbTongQuy.Text = "Tổng quỹ hiện tại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Doanh thu tháng này";
            // 
            // lblDoanhThuHomNay
            // 
            this.lblDoanhThuHomNay.AutoSize = true;
            this.lblDoanhThuHomNay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoanhThuHomNay.Location = new System.Drawing.Point(91, 20);
            this.lblDoanhThuHomNay.Name = "lblDoanhThuHomNay";
            this.lblDoanhThuHomNay.Size = new System.Drawing.Size(199, 25);
            this.lblDoanhThuHomNay.TabIndex = 9;
            this.lblDoanhThuHomNay.Text = "Doanh thu hôm nay";
            // 
            // dgvNguyenLieuTrongKho
            // 
            this.dgvNguyenLieuTrongKho.AutoGenerateColumns = false;
            this.dgvNguyenLieuTrongKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNguyenLieuTrongKho.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvNguyenLieuTrongKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNguyenLieuTrongKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenNL1DataGridViewTextBoxColumn,
            this.dVT1DataGridViewTextBoxColumn,
            this.donGia1DataGridViewTextBoxColumn});
            this.dgvNguyenLieuTrongKho.DataSource = this.nguyenLieuDTOBindingSource2;
            this.dgvNguyenLieuTrongKho.Location = new System.Drawing.Point(472, 64);
            this.dgvNguyenLieuTrongKho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvNguyenLieuTrongKho.Name = "dgvNguyenLieuTrongKho";
            this.dgvNguyenLieuTrongKho.RowHeadersWidth = 51;
            this.dgvNguyenLieuTrongKho.RowTemplate.Height = 24;
            this.dgvNguyenLieuTrongKho.Size = new System.Drawing.Size(367, 455);
            this.dgvNguyenLieuTrongKho.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(528, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Nguyên liệu trong kho";
            // 
            // dgvSanPhamBanDuoc
            // 
            this.dgvSanPhamBanDuoc.AutoGenerateColumns = false;
            this.dgvSanPhamBanDuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPhamBanDuoc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSanPhamBanDuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPhamBanDuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenSP1DataGridViewTextBoxColumn,
            this.soLuong1DataGridViewTextBoxColumn,
            this.gia1DataGridViewTextBoxColumn,
            this.giamGia1DataGridViewTextBoxColumn,
            this.tongTien1DataGridViewTextBoxColumn});
            this.dgvSanPhamBanDuoc.DataSource = this.doanhThuDTOBindingSource;
            this.dgvSanPhamBanDuoc.Location = new System.Drawing.Point(26, 64);
            this.dgvSanPhamBanDuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSanPhamBanDuoc.Name = "dgvSanPhamBanDuoc";
            this.dgvSanPhamBanDuoc.RowHeadersWidth = 51;
            this.dgvSanPhamBanDuoc.RowTemplate.Height = 24;
            this.dgvSanPhamBanDuoc.Size = new System.Drawing.Size(440, 455);
            this.dgvSanPhamBanDuoc.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(124, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Sản phẩm bán được";
            // 
            // panDanhThuContent
            // 
            this.panDanhThuContent.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panDanhThuContent.Controls.Add(this.label5);
            this.panDanhThuContent.Controls.Add(this.panel3);
            this.panDanhThuContent.Controls.Add(this.dgvSanPhamBanDuoc);
            this.panDanhThuContent.Controls.Add(this.label6);
            this.panDanhThuContent.Controls.Add(this.dgvNguyenLieuTrongKho);
            this.panDanhThuContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panDanhThuContent.Location = new System.Drawing.Point(0, 59);
            this.panDanhThuContent.Margin = new System.Windows.Forms.Padding(4);
            this.panDanhThuContent.Name = "panDanhThuContent";
            this.panDanhThuContent.Size = new System.Drawing.Size(1261, 559);
            this.panDanhThuContent.TabIndex = 13;
            this.panDanhThuContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panDanhThuContent_Paint);
            // 
            // tenSP1DataGridViewTextBoxColumn
            // 
            this.tenSP1DataGridViewTextBoxColumn.DataPropertyName = "TenSP1";
            this.tenSP1DataGridViewTextBoxColumn.HeaderText = "Tên Sản Phẩm";
            this.tenSP1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenSP1DataGridViewTextBoxColumn.Name = "tenSP1DataGridViewTextBoxColumn";
            // 
            // soLuong1DataGridViewTextBoxColumn
            // 
            this.soLuong1DataGridViewTextBoxColumn.DataPropertyName = "SoLuong1";
            this.soLuong1DataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.soLuong1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soLuong1DataGridViewTextBoxColumn.Name = "soLuong1DataGridViewTextBoxColumn";
            // 
            // gia1DataGridViewTextBoxColumn
            // 
            this.gia1DataGridViewTextBoxColumn.DataPropertyName = "Gia1";
            this.gia1DataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            this.gia1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gia1DataGridViewTextBoxColumn.Name = "gia1DataGridViewTextBoxColumn";
            // 
            // giamGia1DataGridViewTextBoxColumn
            // 
            this.giamGia1DataGridViewTextBoxColumn.DataPropertyName = "GiamGia1";
            this.giamGia1DataGridViewTextBoxColumn.HeaderText = "Giảm giá";
            this.giamGia1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giamGia1DataGridViewTextBoxColumn.Name = "giamGia1DataGridViewTextBoxColumn";
            // 
            // tongTien1DataGridViewTextBoxColumn
            // 
            this.tongTien1DataGridViewTextBoxColumn.DataPropertyName = "TongTien1";
            this.tongTien1DataGridViewTextBoxColumn.HeaderText = "Tổng tiền";
            this.tongTien1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tongTien1DataGridViewTextBoxColumn.Name = "tongTien1DataGridViewTextBoxColumn";
            // 
            // doanhThuDTOBindingSource
            // 
            this.doanhThuDTOBindingSource.DataSource = typeof(DTO.DoanhThuDTO);
            // 
            // tenNL1DataGridViewTextBoxColumn
            // 
            this.tenNL1DataGridViewTextBoxColumn.DataPropertyName = "TenNL1";
            this.tenNL1DataGridViewTextBoxColumn.HeaderText = "Tên NL";
            this.tenNL1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenNL1DataGridViewTextBoxColumn.Name = "tenNL1DataGridViewTextBoxColumn";
            // 
            // dVT1DataGridViewTextBoxColumn
            // 
            this.dVT1DataGridViewTextBoxColumn.DataPropertyName = "DVT1";
            this.dVT1DataGridViewTextBoxColumn.HeaderText = "Đơn vị tính";
            this.dVT1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dVT1DataGridViewTextBoxColumn.Name = "dVT1DataGridViewTextBoxColumn";
            // 
            // donGia1DataGridViewTextBoxColumn
            // 
            this.donGia1DataGridViewTextBoxColumn.DataPropertyName = "DonGia1";
            this.donGia1DataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            this.donGia1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.donGia1DataGridViewTextBoxColumn.Name = "donGia1DataGridViewTextBoxColumn";
            // 
            // nguyenLieuDTOBindingSource2
            // 
            this.nguyenLieuDTOBindingSource2.DataSource = typeof(DTO.NguyenLieuDTO);
            // 
            // nguyenLieuDTOBindingSource
            // 
            this.nguyenLieuDTOBindingSource.DataSource = typeof(DTO.NguyenLieuDTO);
            // 
            // nguyenLieuDTOBindingSource1
            // 
            this.nguyenLieuDTOBindingSource1.DataSource = typeof(DTO.NguyenLieuDTO);
            // 
            // QuanLyDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.panDanhThuContent);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLyDoanhThu";
            this.Size = new System.Drawing.Size(1261, 618);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieuTrongKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPhamBanDuoc)).EndInit();
            this.panDanhThuContent.ResumeLayout(false);
            this.panDanhThuContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doanhThuDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguyenLieuDTOBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguyenLieuDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguyenLieuDTOBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_Tiltle;
        private System.Windows.Forms.BindingSource doanhThuDTOBindingSource;
        private System.Windows.Forms.BindingSource nguyenLieuDTOBindingSource;
        private System.Windows.Forms.BindingSource nguyenLieuDTOBindingSource1;
        private System.Windows.Forms.BindingSource nguyenLieuDTOBindingSource2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtChi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTongQuyHienTai;
        private System.Windows.Forms.TextBox txtDoanhThuThangNay;
        private System.Windows.Forms.TextBox txtDoanhThuHomNay;
        private System.Windows.Forms.Label lbTongQuy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDoanhThuHomNay;
        private System.Windows.Forms.DataGridView dgvNguyenLieuTrongKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNL1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dVT1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGia1DataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvSanPhamBanDuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSP1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giamGia1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTien1DataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panDanhThuContent;
    }
}
