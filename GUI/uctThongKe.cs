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

namespace GUI
{
    public partial class uctThongKe : UserControl
    {

        public uctThongKe()
        {
            InitializeComponent();
        }

        private void uctThongKe_Load(object sender, EventArgs e)
        {
            ShowTatCaHD();
        }
        public void ShowTatCaHD()
        {
            List<BillDTO> lstHD = new List<BillDTO>();
            lstHD = BUS.BillBus.Instance.getListHD(dtpTuNgay.Value.ToString(), dtpDenNgay.Value.ToString());
            this.reportViewer1.LocalReport.ReportPath = "GUI.rptThongKeHD.rdlc";
            //do du lieu
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsBill", lstHD));
            this.reportViewer1.RefreshReport();

        }
    }
}
