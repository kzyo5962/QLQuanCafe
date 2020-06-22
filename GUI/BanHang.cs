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
        static float tongTien = 0;
        static int maBanClick = -1;
        static int maNV = 1;
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
            tongTien = 0;
            int idBan = ((sender as Button).Tag as TableDTO).IMaBan;
            maBanClick = idBan;
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
            cboBanTrong.DataSource = TableBus.Instance.LoadListTableNull();
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
            
            int idBill = BillBus.Instance.GetUncheckBillIDByTableID(maBanClick);
            int idMenu = (cboMenu.SelectedItem as MenuDTO).ID;
            float giamGia = (float)numGiamGia.Value;
            int soLuong = (int)numSoLuong.Value;
            int exec;

            if(idBill==-1)
            {
                BillBus.Instance.InsertBill(maBanClick,maNV);
                int maHD = BillBus.Instance.GetMaxIDBill();
                BillInfoBus.Instance.InsertBillInfo(maHD, idMenu, soLuong, giamGia, 15000);
                exec = TableBus.Instance.UpdateStatusBan(maBanClick, 1);
                fPannelBan.Controls.Clear();
                LoadBan();
                drvBillInfo.DataSource = BillInfoBus.Instance.getBillInfoByIDTable(maBanClick, ref tongTien);
            }
            else
            {
                BillInfoBus.Instance.InsertBillInfo(idBill, idMenu, soLuong, giamGia, 15000);
            }
        }

        private void lblBan_Click(object sender, EventArgs e)
        {

        }
    }
}
