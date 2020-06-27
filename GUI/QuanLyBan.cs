using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace GUI
{
    public partial class QuanLyBan : UserControl
    {
        public QuanLyBan()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void QuanLyBan_Load_1(object sender, EventArgs e)
        {
            List<TableDTO> lstTable = TableBus.Instance.LoadTable();
            dtgvQLBan.DataSource = lstTable;
        }

        private void dtgvQLBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string trangThai = "Đang phục vụ";
            int iTrangThai = (int)dtgvQLBan.Rows[e.RowIndex].Cells[2].Value;
            string tinhTrang = "Có thể dùng";
            int iTinhTrang = (int)dtgvQLBan.Rows[e.RowIndex].Cells[3].Value;
            if (e.RowIndex < 0)
                return;
            else
            {
                txtMaBan.Text = dtgvQLBan.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtSoGhe.Text = dtgvQLBan.Rows[e.RowIndex].Cells[1].Value.ToString();
                
                
                
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int soGhe = Convert.ToInt32(txtSoGhe.Text);
           
        }
    }
}
