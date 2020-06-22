using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }
        
        private void frmHoaDon_Load(object sender, EventArgs e)
        {

            this.rpvHoaDon.RefreshReport();
        }

        //public void HoaDon()
        //{
        //    List<BillInfoDTO> lstSanPham = BillInfoBus.Instance.getBillInfoByIDTable()
        //}
    }
}
