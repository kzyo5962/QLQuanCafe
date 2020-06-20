namespace GUI
{
    partial class QuanLyNhanVien
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
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTenNV = new System.Windows.Forms.Label();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lbNgayVaoLam = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayVaoLam = new System.Windows.Forms.DateTimePicker();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.btnUpLoad = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboChucVu = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.lb_Tiltle);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 46);
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
            this.lb_Tiltle.Size = new System.Drawing.Size(200, 22);
            this.lb_Tiltle.TabIndex = 8;
            this.lb_Tiltle.Text = "QUẢN LÍ NHÂN VIÊN";
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(159, 30);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TimKiem.Multiline = true;
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(252, 21);
            this.txt_TimKiem.TabIndex = 27;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.Coral;
            this.btn_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_TimKiem.Location = new System.Drawing.Point(415, 16);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(76, 35);
            this.btn_TimKiem.TabIndex = 28;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.Moccasin;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvNhanVien.Location = new System.Drawing.Point(11, 72);
            this.dgvNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.Size = new System.Drawing.Size(480, 341);
            this.dgvNhanVien.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 26);
            this.label1.TabIndex = 42;
            this.label1.Text = "Thông tin nhân viên";
            // 
            // lbTenNV
            // 
            this.lbTenNV.AutoSize = true;
            this.lbTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNV.Location = new System.Drawing.Point(190, 72);
            this.lbTenNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(72, 17);
            this.lbTenNV.TabIndex = 44;
            this.lbTenNV.Text = "Tên NV :";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgaySinh.Location = new System.Drawing.Point(190, 96);
            this.lbNgaySinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(90, 17);
            this.lbNgaySinh.TabIndex = 45;
            this.lbNgaySinh.Text = "Ngày sinh :";
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSDT.Location = new System.Drawing.Point(190, 120);
            this.lbSDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(49, 17);
            this.lbSDT.TabIndex = 46;
            this.lbSDT.Text = "SĐT :";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(320, 72);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(148, 20);
            this.txtTenNV.TabIndex = 48;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(320, 120);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(148, 20);
            this.txtSDT.TabIndex = 49;
            // 
            // lbNgayVaoLam
            // 
            this.lbNgayVaoLam.AutoSize = true;
            this.lbNgayVaoLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayVaoLam.Location = new System.Drawing.Point(190, 144);
            this.lbNgayVaoLam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNgayVaoLam.Name = "lbNgayVaoLam";
            this.lbNgayVaoLam.Size = new System.Drawing.Size(116, 17);
            this.lbNgayVaoLam.TabIndex = 50;
            this.lbNgayVaoLam.Text = "Ngày vào làm :";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(320, 96);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(148, 20);
            this.dtpNgaySinh.TabIndex = 51;
            // 
            // dtpNgayVaoLam
            // 
            this.dtpNgayVaoLam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayVaoLam.Location = new System.Drawing.Point(320, 144);
            this.dtpNgayVaoLam.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayVaoLam.Name = "dtpNgayVaoLam";
            this.dtpNgayVaoLam.Size = new System.Drawing.Size(148, 20);
            this.dtpNgayVaoLam.TabIndex = 52;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.BackColor = System.Drawing.Color.ForestGreen;
            this.btnThemMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThemMoi.Location = new System.Drawing.Point(370, 652);
            this.btnThemMoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(80, 35);
            this.btnThemMoi.TabIndex = 53;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = false;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Xoa.Location = new System.Drawing.Point(555, 652);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 35);
            this.btn_Xoa.TabIndex = 54;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCapNhat.Location = new System.Drawing.Point(467, 652);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(70, 35);
            this.btnCapNhat.TabIndex = 55;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            // 
            // pic
            // 
            this.pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic.Location = new System.Drawing.Point(22, 48);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(152, 161);
            this.pic.TabIndex = 56;
            this.pic.TabStop = false;
            // 
            // btnUpLoad
            // 
            this.btnUpLoad.Location = new System.Drawing.Point(300, 514);
            this.btnUpLoad.Name = "btnUpLoad";
            this.btnUpLoad.Size = new System.Drawing.Size(75, 23);
            this.btnUpLoad.TabIndex = 57;
            this.btnUpLoad.Text = "Chọn ảnh";
            this.btnUpLoad.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 13;
            this.comboBox1.Location = new System.Drawing.Point(11, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(131, 21);
            this.comboBox1.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnUpLoad);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.btnCapNhat);
            this.panel2.Controls.Add(this.dgvNhanVien);
            this.panel2.Controls.Add(this.btn_Xoa);
            this.panel2.Controls.Add(this.btn_TimKiem);
            this.panel2.Controls.Add(this.btnThemMoi);
            this.panel2.Controls.Add(this.txt_TimKiem);
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1007, 439);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cboChucVu);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtMaNV);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtTenNV);
            this.panel3.Controls.Add(this.lbSDT);
            this.panel3.Controls.Add(this.pic);
            this.panel3.Controls.Add(this.txtSDT);
            this.panel3.Controls.Add(this.lbNgaySinh);
            this.panel3.Controls.Add(this.lbNgayVaoLam);
            this.panel3.Controls.Add(this.lbTenNV);
            this.panel3.Controls.Add(this.dtpNgaySinh);
            this.panel3.Controls.Add(this.dtpNgayVaoLam);
            this.panel3.Location = new System.Drawing.Point(511, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(482, 314);
            this.panel3.TabIndex = 58;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(320, 48);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(148, 20);
            this.txtMaNV.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 57;
            this.label2.Text = "Mã NV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(190, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 59;
            this.label3.Text = "Địa chỉ:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(320, 170);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 84);
            this.textBox1.TabIndex = 60;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 32);
            this.button1.TabIndex = 61;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(190, 259);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 62;
            this.label4.Text = "Chức vụ:";
            // 
            // cboChucVu
            // 
            this.cboChucVu.FormattingEnabled = true;
            this.cboChucVu.Location = new System.Drawing.Point(320, 259);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.Size = new System.Drawing.Size(148, 21);
            this.cboChucVu.TabIndex = 63;
            // 
            // QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyNhanVien";
            this.Size = new System.Drawing.Size(1012, 491);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_Tiltle;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTenNV;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lbNgayVaoLam;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgayVaoLam;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btnUpLoad;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cboChucVu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label2;
    }
}
