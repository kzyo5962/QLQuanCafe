using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class BanHang : UserControl
    {
        static int width = 70;
        static int height = 60;
        public BanHang()
        {
            InitializeComponent();
        }
        // Load Danh Sach Cac Ban
        void LoadBan()
        {
            fPannelBan.Controls.Clear();
            List<TableDTO> listTableDTO = TableBus.Instance.LoadTable();
            foreach (TableDTO item in listTableDTO)
            {
                Button btn = new Button();
                btn.Width = width;
                btn.Height = height;
                btn.Tag = item;
                btn.Click += btn_Click;
                btn.ImageKey = "icons8-table-26.png";
                btn.ImageList = this.imageListIcon;
                btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                if (item.ITrangThai == 0)
                {
                    //drvHoaDon.Visible = false;
                    btn.BackColor = System.Drawing.Color.PeachPuff;

                }
                else if (item.ITrangThai == 1)
                {
                    //drvHoaDon.Visible = false;
                    btn.BackColor = System.Drawing.Color.LightGray;
                }
                else
                {
                    // drvHoaDon.Visible = true;
                    pButtonDatMon.Location = new Point(29, 123);
                    btn.BackColor = System.Drawing.Color.BurlyWood;

                }

                btn.Text = item.IMaBan;
                btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                fPannelBan.Controls.Add(btn);
            }
        }
        //CLick Vao 1 ban
        private void btn_Click(object sender, EventArgs e)
        {
            btnHuyBan.Visible = false;
            btnGoiMon.Visible = true;
            btnDatCho.Visible = true;
            //int MaBan = Convert.ToInt32(((sender as Button).Tag as TableDTO).IMaBan);
            lblMaBan.Text = ((sender as Button).Tag as TableDTO).IMaBan;
            int Trangthai = ((sender as Button).Tag as TableDTO).ITrangThai;
            if (Trangthai == 0)
            {
                lblTrangThai.Text = "Trạng thái: trống";
                pButtonDatMon.Visible = true;
                pHoaDon.Visible = false;

            }
            else if (Trangthai == 1)
            {


                pButtonDatMon.Visible = false;
                lblTrangThai.Text = "Trạng thái: đặt trước";
                pHoaDon.Visible = false;
            }

            else
            {


                pButtonDatMon.Visible = false;
                lblTrangThai.Text = "Trạng thái: đang phục vụ";
                pHoaDon.Visible = true;
            }
            DateTime now = DateTime.Now;
            int giay = now.Second;
            int phut = now.Minute;
            int gio = now.Hour;
            lblGioDen.Text = "Giờ Đến: " + gio + ":" + phut + ":" + giay;

        }

        private void pPhucVu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fPannelBan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BanHang_Load(object sender, EventArgs e)
        {
            LoadBan();
        }

        private void lblMaBan_Click(object sender, EventArgs e)
        {

        }

        private void pMenuPhucVu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblGioDen_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }

        private void lblBanCLick_Click(object sender, EventArgs e)
        {

        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnHuyBan_Click(object sender, EventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {

        }

        private void pHoaDon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnDatCho_Click(object sender, EventArgs e)
        {

        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {

        }

        private void nudSoLuong_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pButtonDatMon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblTrangThai_Click(object sender, EventArgs e)
        {

        }

        private void btnGoiMon_Click(object sender, EventArgs e)
        {

        }

        private void drvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblBan_Click(object sender, EventArgs e)
        {

        }

        private void pGoiMon_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
