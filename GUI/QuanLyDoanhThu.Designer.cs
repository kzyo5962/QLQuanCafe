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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_Tiltle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaThucUong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.panDanhThuContent = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtChi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTongQuyHienTai = new System.Windows.Forms.TextBox();
            this.txtDoanhThuThangNay = new System.Windows.Forms.TextBox();
            this.txtDoanhThuTuanNay = new System.Windows.Forms.TextBox();
            this.txtDoanhThuHomNay = new System.Windows.Forms.TextBox();
            this.lbTongQuy = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDoanhThuHomNay = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panDanhThuContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(923, 48);
            this.panel1.TabIndex = 12;
            // 
            // lb_Tiltle
            // 
            this.lb_Tiltle.AutoSize = true;
            this.lb_Tiltle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Tiltle.ForeColor = System.Drawing.Color.Black;
            this.lb_Tiltle.Location = new System.Drawing.Point(409, 10);
            this.lb_Tiltle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Tiltle.Name = "lb_Tiltle";
            this.lb_Tiltle.Size = new System.Drawing.Size(211, 22);
            this.lb_Tiltle.TabIndex = 8;
            this.lb_Tiltle.Text = "QUẢN LÍ DOANH THU";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(1, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(353, 332);
            this.panel2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaThucUong,
            this.colSoLuong,
            this.colThanhToan});
            this.dataGridView1.Location = new System.Drawing.Point(2, 36);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(330, 262);
            this.dataGridView1.TabIndex = 18;
            // 
            // colThanhToan
            // 
            this.colThanhToan.HeaderText = "Thanh toán";
            this.colThanhToan.MinimumWidth = 6;
            this.colThanhToan.Name = "colThanhToan";
            // 
            // colSoLuong
            // 
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.MinimumWidth = 6;
            this.colSoLuong.Name = "colSoLuong";
            // 
            // colMaThucUong
            // 
            this.colMaThucUong.HeaderText = "Tên thức uống";
            this.colMaThucUong.MinimumWidth = 6;
            this.colMaThucUong.Name = "colMaThucUong";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(88, 2);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Sản phẩm bán được";
            // 
            // panDanhThuContent
            // 
            this.panDanhThuContent.Controls.Add(this.panel3);
            this.panDanhThuContent.Controls.Add(this.label6);
            this.panDanhThuContent.Controls.Add(this.dataGridView2);
            this.panDanhThuContent.Controls.Add(this.panel2);
            this.panDanhThuContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panDanhThuContent.Location = new System.Drawing.Point(0, 48);
            this.panDanhThuContent.Name = "panDanhThuContent";
            this.panDanhThuContent.Size = new System.Drawing.Size(923, 433);
            this.panDanhThuContent.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(396, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Nguyên liệu trong kho";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView2.Location = new System.Drawing.Point(363, 52);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(275, 262);
            this.dataGridView2.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Tên NL";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Giá bán";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtChi);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtTongQuyHienTai);
            this.panel3.Controls.Add(this.txtDoanhThuThangNay);
            this.panel3.Controls.Add(this.txtDoanhThuTuanNay);
            this.panel3.Controls.Add(this.txtDoanhThuHomNay);
            this.panel3.Controls.Add(this.lbTongQuy);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lblDoanhThuHomNay);
            this.panel3.Location = new System.Drawing.Point(642, 26);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(277, 357);
            this.panel3.TabIndex = 22;
            // 
            // txtChi
            // 
            this.txtChi.Location = new System.Drawing.Point(71, 230);
            this.txtChi.Margin = new System.Windows.Forms.Padding(2);
            this.txtChi.Multiline = true;
            this.txtChi.Name = "txtChi";
            this.txtChi.Size = new System.Drawing.Size(169, 25);
            this.txtChi.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(104, 208);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Chi hôm nay";
            // 
            // txtTongQuyHienTai
            // 
            this.txtTongQuyHienTai.Location = new System.Drawing.Point(57, 300);
            this.txtTongQuyHienTai.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongQuyHienTai.Multiline = true;
            this.txtTongQuyHienTai.Name = "txtTongQuyHienTai";
            this.txtTongQuyHienTai.Size = new System.Drawing.Size(218, 36);
            this.txtTongQuyHienTai.TabIndex = 16;
            // 
            // txtDoanhThuThangNay
            // 
            this.txtDoanhThuThangNay.Location = new System.Drawing.Point(72, 182);
            this.txtDoanhThuThangNay.Margin = new System.Windows.Forms.Padding(2);
            this.txtDoanhThuThangNay.Multiline = true;
            this.txtDoanhThuThangNay.Name = "txtDoanhThuThangNay";
            this.txtDoanhThuThangNay.Size = new System.Drawing.Size(169, 24);
            this.txtDoanhThuThangNay.TabIndex = 15;
            // 
            // txtDoanhThuTuanNay
            // 
            this.txtDoanhThuTuanNay.Location = new System.Drawing.Point(72, 112);
            this.txtDoanhThuTuanNay.Margin = new System.Windows.Forms.Padding(2);
            this.txtDoanhThuTuanNay.Multiline = true;
            this.txtDoanhThuTuanNay.Name = "txtDoanhThuTuanNay";
            this.txtDoanhThuTuanNay.Size = new System.Drawing.Size(169, 24);
            this.txtDoanhThuTuanNay.TabIndex = 14;
            // 
            // txtDoanhThuHomNay
            // 
            this.txtDoanhThuHomNay.Location = new System.Drawing.Point(72, 43);
            this.txtDoanhThuHomNay.Margin = new System.Windows.Forms.Padding(2);
            this.txtDoanhThuHomNay.Multiline = true;
            this.txtDoanhThuHomNay.Name = "txtDoanhThuHomNay";
            this.txtDoanhThuHomNay.Size = new System.Drawing.Size(169, 23);
            this.txtDoanhThuHomNay.TabIndex = 13;
            // 
            // lbTongQuy
            // 
            this.lbTongQuy.AutoSize = true;
            this.lbTongQuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongQuy.ForeColor = System.Drawing.Color.Black;
            this.lbTongQuy.Location = new System.Drawing.Point(75, 264);
            this.lbTongQuy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTongQuy.Name = "lbTongQuy";
            this.lbTongQuy.Size = new System.Drawing.Size(173, 24);
            this.lbTongQuy.TabIndex = 12;
            this.lbTongQuy.Text = "Tổng quỹ hiện tại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Doanh thu tháng này";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Doanh thu tuần này";
            // 
            // lblDoanhThuHomNay
            // 
            this.lblDoanhThuHomNay.AutoSize = true;
            this.lblDoanhThuHomNay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoanhThuHomNay.Location = new System.Drawing.Point(75, 20);
            this.lblDoanhThuHomNay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDoanhThuHomNay.Name = "lblDoanhThuHomNay";
            this.lblDoanhThuHomNay.Size = new System.Drawing.Size(165, 20);
            this.lblDoanhThuHomNay.TabIndex = 9;
            this.lblDoanhThuHomNay.Text = "Doanh thu hôm nay";
            // 
            // QuanLyDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panDanhThuContent);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyDoanhThu";
            this.Size = new System.Drawing.Size(923, 481);
            this.Load += new System.EventHandler(this.QuanLyDoanhThu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panDanhThuContent.ResumeLayout(false);
            this.panDanhThuContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_Tiltle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaThucUong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhToan;
        private System.Windows.Forms.Panel panDanhThuContent;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtChi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTongQuyHienTai;
        private System.Windows.Forms.TextBox txtDoanhThuThangNay;
        private System.Windows.Forms.TextBox txtDoanhThuTuanNay;
        private System.Windows.Forms.TextBox txtDoanhThuHomNay;
        private System.Windows.Forms.Label lbTongQuy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDoanhThuHomNay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
