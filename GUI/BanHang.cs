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
        static int width = 100;
        static int height = 100;
        static float tongTien = 0;
        static int maBanClick = -1;
        static int maNV = 1;
        Button myButtonClick = new Button();
        public BanHang()
        {
            InitializeComponent();

        }
        // load ban
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
                string MaBan =ChangeMaban(item.IMaBan).ToString();
                btn.Text = "Ban " + MaBan + "";
                btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                fPannelBan.Controls.Add(btn);
            }
        }
        int  ChangeMaban(string maBan)
        {
            string ma = maBan.Substring(4);
           
            int soBan = Convert.ToInt32(ma);
            return soBan;
        }
        //Bắt sự kiện click
        private void btn_Click(object sender, EventArgs e)
        {
            tongTien = 0;
           
          
          
           
            string  idBan = ((sender as Button).Tag as TableDTO).IMaBan;
            //lay ra ma ban dang duoc click 
            maBanClick = ChangeMaban(idBan);
            //gán Cho drv với đối tượng là mã bàn
            drvBillInfo.Tag = (sender as Button).Tag;
            lblBan.Text = maBanClick.ToString();
            //Lay ra Trang thai cua ban
            int Trangthai = ((sender as Button).Tag as TableDTO).ITrangThai;
           
            if (Trangthai == 0)
            {
                lblTrangThai.Text = "Trạng thái: trống";
                drvBillInfo.DataSource = null;
                if (myButtonClick != null && myButtonClick.BackColor == Color.Blue)
                {
                    myButtonClick.BackColor = Color.PeachPuff;
                }

            }
            else if (Trangthai == 1)
            {
                lblTrangThai.Text = "Trạng thái: Đang Phục vụ";
                drvBillInfo.DataSource = BillInfoBus.Instance.getBillInfoByIDTable(maBanClick, ref tongTien);
                txtTongTien.Text = tongTien + "";
                if (myButtonClick != null && myButtonClick.BackColor == Color.Blue)
                {
                    myButtonClick.BackColor = Color.LightGray;
                }

            }
            myButtonClick = (sender as Button);
            myButtonClick.BackColor = Color.Blue;

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            //lau ra bill hien tai
            int idBill = BillBus.Instance.GetUncheckBillIDByTableID(maBanClick);
            int idMenu = (cboMenu.SelectedItem as MenuDTO).ID;
            float giamGia = (float)numGiamGia.Value;
            int soLuong = (int)numSoLuong.Value;
            int exec;

            if (idBill == -1)
            {
                BillBus.Instance.InsertBill(maBanClick, maNV);
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
            cboBanTrong.DataSource = TableBus.Instance.LoadListTableNull();

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            
        }

        private void billInfoDTOBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnChuyenBan_Click(object sender, EventArgs e)
        {

            tongTien = 0;
            //Lay ra ban mơi từ combobox
            int banMoi = (int)cboBanTrong.SelectedValue;
            //Chuyen Ban
            BillBus.Instance.DoiBan(maBanClick, banMoi);
            //Cap Nhat Ban Cu
            int exec = TableBus.Instance.UpdateStatusBan(maBanClick, 0);
            //Cap Nhât Ban Mới
            exec = TableBus.Instance.UpdateStatusBan(banMoi, 1);
            //Lay ra mã ban hienj hanh
            maBanClick = banMoi;
            lblBan.Text = maBanClick + "";
            //Load Loai Danh Sach Ban
            LoadBan();
            //Load Vao datagrid view
            drvBillInfo.DataSource = BillInfoBus.Instance.getBillInfoByIDTable(maBanClick, ref tongTien);
        }

        private void BanHang_Load(object sender, EventArgs e)
        {
            cboLoaiMenu.DataSource = LoaiMenuBus.Instance.ListLoaiMenu();
            LoadBan();
            cboBanTrong.DataSource = TableBus.Instance.LoadListTableNull();
        }

        private void cboBanTrong_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idLoaiMenu = (int)cboLoaiMenu.SelectedValue;
            List<MenuDTO> listMenu = MenuBus.Instance.ListMenuByID(idLoaiMenu);
            cboMenu.DataSource = listMenu;
        }
    }
}
