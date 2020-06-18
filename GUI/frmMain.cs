using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            panHover.Top = btnTrangChu.Top;
            panHover.Height = btnTrangChu.Height;
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {

            panHover.Top = btnBanHang.Top;
            panHover.Height = btnBanHang.Height;
            banHang1.BringToFront();

        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {

            panHover.Top = btnQuanLy.Top;
            panHover.Height = btnQuanLy.Height;
            quanLy1.BringToFront();

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {

            panHover.Top = btnThongKe.Top;
            panHover.Height = btnThongKe.Height;
        }

        private void btnInfomation_Click(object sender, EventArgs e)
        {

            panHover.Top = btnInfomation.Top;
            panHover.Height = btnInfomation.Height;
        }
    }
}
