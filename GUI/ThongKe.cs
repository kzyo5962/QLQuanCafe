using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ThongKe : UserControl
    {
        public ThongKe()
        {
            InitializeComponent();
        }

        private void thToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongkeHoaDon hd = new frmThongkeHoaDon();

            hd.ShowDialog();
        }
    }
}
