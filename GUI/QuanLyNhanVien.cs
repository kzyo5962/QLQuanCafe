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
    public partial class QuanLyNhanVien : UserControl
    {
        public QuanLyNhanVien()
        {
            InitializeComponent();
            load();
            //ChucVuNV();
          

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
                {
                    if(ofd.ShowDialog()==DialogResult.OK)
                    {
                        pic.Image = Image.FromFile(ofd.FileName);
                    }    
                }                    
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if(txtTenNV.Text==""||txtSDT.Text==""||txtDiaChi.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else
            {
                if (BUS.NhanVienBUS.Instance.ThemNhanVien(txtTenNV.Text, txtDiaChi.Text, txtSDT.Text, dtpNgayVaoLam.Text, "",cboChucVu.Text) >= 1)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    load();
                }
            }
         
        }

      

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            else
            {
                txtDiaChi.Text = dgvNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenNV.Text = dgvNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSDT.Text = dgvNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpNgayVaoLam.Text= dgvNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtMaNV.Text= dgvNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString();
                cboChucVu.Text= dgvNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString();
            }                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            load();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(txtMaNV.Text=="")
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
            else
            {
                int ID = int.Parse(txtMaNV.Text);
                if (BUS.NhanVienBUS.Instance.XoaNhanVien(ID) > 0)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();
                }
            }         
        }
        private void load()
        {
            txtMaNV.ResetText();
            txtTenNV.ResetText();
            txtSDT.ResetText();
            txtDiaChi.ResetText();
            dgvNhanVien.DataSource = BUS.NhanVienBUS.Instance.listNhanVien();
           
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int ID = int.Parse(txtMaNV.Text);
                if(BUS.NhanVienBUS.Instance.CapNhatNhanVien(txtTenNV.Text,txtDiaChi.Text,txtSDT.Text,dtpNgayVaoLam.Text,ID,cboChucVu.Text)>0)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();
                }    
                else
                {
                    MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    load();
                }    
            }    
        }

        public void ChucVuNV()
        {
            cboChucVu.DataSource = BUS.NhanVienBUS.Instance.ChucVuNV();
            cboChucVu.DisplayMember = "TenLoai";
            cboChucVu.ValueMember = "TenLoai";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
