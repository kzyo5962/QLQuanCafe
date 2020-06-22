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
using System.Runtime.InteropServices;

namespace GUI
{
    public partial class BanHang : UserControl
    {
        static int width = 70;
        static int height = 60;
        static float tongTien = 0;
        static int MaBan = 0;
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
                btn.ImageKey = "icons8-table-26.png";
                btn.ImageList = this.imageListIcon;
                btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                btn.Click += btn_Click;
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
                   
                    btn.BackColor = System.Drawing.Color.BurlyWood;

                }

                btn.Text = "Ban "+item.IMaBan+"";
                btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                fPannelBan.Controls.Add(btn);
            }
        }
        //CLick Vao 1 ban


        private void btn_Click(object sender, EventArgs e)
        {
            int idBan = ((sender as Button).Tag as TableDTO).IMaBan;
            MaBan = idBan;
            drvBillInfo.Tag = (sender as Button).Tag;
            lblBan.Text =idBan.ToString();
            int Trangthai = ((sender as Button).Tag as TableDTO).ITrangThai;
            if (Trangthai == 0)
            {
                lblTrangThai.Text = "Trạng thái: trống";
                drvBillInfo.DataSource = null;



            }
            else if (Trangthai == 1)
            {


              
                lblTrangThai.Text = "Trạng thái: Đang Phục vụ";
                drvBillInfo.DataSource = BillInfoBus.Instance.getBillInfoByIDTable(idBan,ref tongTien);
                txtTongTien.Text = tongTien + "";
               
            }

        }

        private void BanHang_Load(object sender, EventArgs e)
        {
            cboLoaiMenu.DataSource = LoaiMenuBus.Instance.ListLoaiMenu();
            LoadBan();
        }

        private void cboLoaiMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idLoaiMenu= (int)cboLoaiMenu.SelectedValue;
            List<MenuDTO> listMenu = MenuBus.Instance.ListMenuByID(idLoaiMenu);
            cboMenu.DataSource = listMenu;
           
        }

        private void cboMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TableDTO table = drvBillInfo.Tag as TableDTO;
            int idBill = BillBus.Instance.GetUncheckBillIDByTableID(table.IMaBan);
        }

        private void btnLapHD_Click(object sender, EventArgs e)
        {
            frmHoaDon frm = new frmHoaDon();
            frm.ShowDialog();
        }
    }
}
