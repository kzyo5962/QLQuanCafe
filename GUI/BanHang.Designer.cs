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
            ((System.ComponentModel.ISupportInitialize)(this.loaiMenuDTOBindingSource)).BeginInit();
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
            this.fPannelBan.Location = new System.Drawing.Point(3, 3);
            this.fPannelBan.Name = "fPannelBan";
            this.fPannelBan.Size = new System.Drawing.Size(265, 493);
            this.fPannelBan.TabIndex = 4;
            this.fPannelBan.Paint += new System.Windows.Forms.PaintEventHandler(this.fPannelBan_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Loại Menu";
            // 
            // cboLoaiMenu
            // 
            this.cboLoaiMenu.DataSource = this.loaiMenuDTOBindingSource;
            this.cboLoaiMenu.DisplayMember = "TenLoai";
            this.cboLoaiMenu.FormattingEnabled = true;
            this.cboLoaiMenu.Location = new System.Drawing.Point(365, 16);
            this.cboLoaiMenu.Name = "cboLoaiMenu";
            this.cboLoaiMenu.Size = new System.Drawing.Size(225, 21);
            this.cboLoaiMenu.TabIndex = 5;
            this.cboLoaiMenu.ValueMember = "ID";
            // 
            // loaiMenuDTOBindingSource
            // 
            this.loaiMenuDTOBindingSource.DataSource = typeof(DTO.LoaiMenuDTO);
            // 
            // BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboLoaiMenu);
            this.Controls.Add(this.fPannelBan);
            this.Name = "BanHang";
            this.Size = new System.Drawing.Size(886, 449);
            this.Load += new System.EventHandler(this.BanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loaiMenuDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageListIcon;
        private System.Windows.Forms.FlowLayoutPanel fPannelBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboLoaiMenu;
        private System.Windows.Forms.BindingSource loaiMenuDTOBindingSource;
    }
}
