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
            this.imageListIcon = new System.Windows.Forms.ImageList(this.components);
            this.fPannelBan = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.cboLoaiMenu = new System.Windows.Forms.ComboBox();
            this.loaiMenuDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cboMenu = new System.Windows.Forms.ComboBox();
            this.menuDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.drvBillInfo = new System.Windows.Forms.DataGridView();
            this.tenMenuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billInfoDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Xh = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBan = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnChuyenBan = new System.Windows.Forms.Button();
            this.cboBanTrong = new System.Windows.Forms.ComboBox();
            this.tableDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.numGiamGia = new System.Windows.Forms.NumericUpDown();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnThanhToan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.loaiMenuDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drvBillInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billInfoDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiamGia)).BeginInit();
            this.SuspendLayout();
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
            this.fPannelBan.Location = new System.Drawing.Point(0, 0);
            this.fPannelBan.Name = "fPannelBan";
            this.fPannelBan.Size = new System.Drawing.Size(454, 449);
            this.fPannelBan.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(470, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Loại Menu";
            // 
            // cboLoaiMenu
            // 
            this.cboLoaiMenu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboLoaiMenu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboLoaiMenu.DataSource = this.loaiMenuDTOBindingSource;
            this.cboLoaiMenu.DisplayMember = "TenLoai";
            this.cboLoaiMenu.FormattingEnabled = true;
            this.cboLoaiMenu.Location = new System.Drawing.Point(539, 53);
            this.cboLoaiMenu.Name = "cboLoaiMenu";
            this.cboLoaiMenu.Size = new System.Drawing.Size(197, 21);
            this.cboLoaiMenu.TabIndex = 5;
            this.cboLoaiMenu.ValueMember = "ID";
            // 
            // loaiMenuDTOBindingSource
            // 
            this.loaiMenuDTOBindingSource.DataSource = typeof(DTO.LoaiMenuDTO);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(472, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Menu";
            // 
            // cboMenu
            // 
            this.cboMenu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboMenu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboMenu.DataSource = this.menuDTOBindingSource;
            this.cboMenu.DisplayMember = "TenMenu";
            this.cboMenu.FormattingEnabled = true;
            this.cboMenu.Location = new System.Drawing.Point(538, 91);
            this.cboMenu.Name = "cboMenu";
            this.cboMenu.Size = new System.Drawing.Size(198, 21);
            this.cboMenu.TabIndex = 7;
            this.cboMenu.ValueMember = "ID";
            // 
            // menuDTOBindingSource
            // 
            this.menuDTOBindingSource.DataSource = typeof(DTO.MenuDTO);
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.CausesValidation = false;
            this.btnAdd.Location = new System.Drawing.Point(742, 53);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 60);
            this.btnAdd.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnAdd, "Thêm Món");
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(832, 58);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(52, 20);
            this.numSoLuong.TabIndex = 10;
            this.toolTip2.SetToolTip(this.numSoLuong, "Số Lượng");
            // 
            // drvBillInfo
            // 
            this.drvBillInfo.AutoGenerateColumns = false;
            this.drvBillInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.drvBillInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drvBillInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenMenuDataGridViewTextBoxColumn,
            this.giaBanDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.thanhTienDataGridViewTextBoxColumn});
            this.drvBillInfo.DataSource = this.billInfoDTOBindingSource;
            this.drvBillInfo.Location = new System.Drawing.Point(472, 161);
            this.drvBillInfo.Name = "drvBillInfo";
            this.drvBillInfo.RowHeadersWidth = 51;
            this.drvBillInfo.Size = new System.Drawing.Size(412, 119);
            this.drvBillInfo.TabIndex = 11;
            // 
            // tenMenuDataGridViewTextBoxColumn
            // 
            this.tenMenuDataGridViewTextBoxColumn.DataPropertyName = "TenMenu";
            this.tenMenuDataGridViewTextBoxColumn.HeaderText = "TenMenu";
            this.tenMenuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenMenuDataGridViewTextBoxColumn.Name = "tenMenuDataGridViewTextBoxColumn";
            // 
            // giaBanDataGridViewTextBoxColumn
            // 
            this.giaBanDataGridViewTextBoxColumn.DataPropertyName = "GiaBan";
            this.giaBanDataGridViewTextBoxColumn.HeaderText = "GiaBan";
            this.giaBanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giaBanDataGridViewTextBoxColumn.Name = "giaBanDataGridViewTextBoxColumn";
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            // 
            // thanhTienDataGridViewTextBoxColumn
            // 
            this.thanhTienDataGridViewTextBoxColumn.DataPropertyName = "ThanhTien";
            this.thanhTienDataGridViewTextBoxColumn.HeaderText = "ThanhTien";
            this.thanhTienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thanhTienDataGridViewTextBoxColumn.Name = "thanhTienDataGridViewTextBoxColumn";
            // 
            // billInfoDTOBindingSource
            // 
            this.billInfoDTOBindingSource.DataSource = typeof(DTO.BillInfoDTO);
            this.billInfoDTOBindingSource.CurrentChanged += new System.EventHandler(this.billInfoDTOBindingSource_CurrentChanged);
            // 
            // Xh
            // 
            this.Xh.AutoSize = true;
            this.Xh.Location = new System.Drawing.Point(472, 131);
            this.Xh.Name = "Xh";
            this.Xh.Size = new System.Drawing.Size(83, 13);
            this.Xh.TabIndex = 12;
            this.Xh.Text = "Chi Tiết Món Ăn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(468, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Bàn";
            // 
            // lblBan
            // 
            this.lblBan.AutoSize = true;
            this.lblBan.Location = new System.Drawing.Point(520, 30);
            this.lblBan.Name = "lblBan";
            this.lblBan.Size = new System.Drawing.Size(19, 13);
            this.lblBan.TabIndex = 14;
            this.lblBan.Text = "00";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(728, 30);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(13, 13);
            this.lblTrangThai.TabIndex = 15;
            this.lblTrangThai.Text = "..";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(603, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Trạng Thái:";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(628, 332);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(56, 13);
            this.lblTongTien.TabIndex = 17;
            this.lblTongTien.Text = "Tổng Tiền";
            // 
            // btnChuyenBan
            // 
            this.btnChuyenBan.Location = new System.Drawing.Point(472, 286);
            this.btnChuyenBan.Name = "btnChuyenBan";
            this.btnChuyenBan.Size = new System.Drawing.Size(75, 27);
            this.btnChuyenBan.TabIndex = 19;
            this.btnChuyenBan.Text = "Chuyển Bàn";
            this.btnChuyenBan.UseVisualStyleBackColor = true;
            this.btnChuyenBan.Click += new System.EventHandler(this.btnChuyenBan_Click);
            // 
            // cboBanTrong
            // 
            this.cboBanTrong.DataSource = this.tableDTOBindingSource;
            this.cboBanTrong.DisplayMember = "IMaBan";
            this.cboBanTrong.FormattingEnabled = true;
            this.cboBanTrong.Location = new System.Drawing.Point(554, 290);
            this.cboBanTrong.Name = "cboBanTrong";
            this.cboBanTrong.Size = new System.Drawing.Size(121, 21);
            this.cboBanTrong.TabIndex = 21;
            this.cboBanTrong.ValueMember = "IMaBan";
            this.cboBanTrong.SelectedIndexChanged += new System.EventHandler(this.cboBanTrong_SelectedIndexChanged);
            // 
            // tableDTOBindingSource
            // 
            this.tableDTOBindingSource.DataSource = typeof(DTO.TableDTO);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(700, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 22;
            this.button1.Text = "Giảm Giá";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // numGiamGia
            // 
            this.numGiamGia.Location = new System.Drawing.Point(782, 290);
            this.numGiamGia.Name = "numGiamGia";
            this.numGiamGia.Size = new System.Drawing.Size(103, 20);
            this.numGiamGia.TabIndex = 23;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(710, 329);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(100, 20);
            this.txtTongTien.TabIndex = 24;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(822, 329);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(62, 46);
            this.btnThanhToan.TabIndex = 25;
            this.btnThanhToan.Text = "Lập Hóa Đơn";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.numGiamGia);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboBanTrong);
            this.Controls.Add(this.btnChuyenBan);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.lblBan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Xh);
            this.Controls.Add(this.drvBillInfo);
            this.Controls.Add(this.numSoLuong);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboMenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboLoaiMenu);
            this.Controls.Add(this.fPannelBan);
            this.Name = "BanHang";
            this.Size = new System.Drawing.Size(897, 449);
            this.Load += new System.EventHandler(this.BanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loaiMenuDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drvBillInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billInfoDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiamGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageListIcon;
        private System.Windows.Forms.FlowLayoutPanel fPannelBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboLoaiMenu;
        private System.Windows.Forms.BindingSource loaiMenuDTOBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMenu;
        private System.Windows.Forms.BindingSource menuDTOBindingSource;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.DataGridView drvBillInfo;
        private System.Windows.Forms.Label Xh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMenuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource billInfoDTOBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBan;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnChuyenBan;
        private System.Windows.Forms.ComboBox cboBanTrong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numGiamGia;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.BindingSource tableDTOBindingSource;
    }
}
