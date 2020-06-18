using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
     public class NhanVienDTO
    {
        private string CMND;
        private string TenNV;
        private string NgaySinh;
        private string SDT;
        private string NgayVaoLam;
       

        public string strCMND { get => CMND; set => CMND = value; }
        public string strTenNV { get => TenNV; set => TenNV = value; }
        public string strNgaySinh { get => NgaySinh; set => NgaySinh = value; }
        public string strSDT { get => SDT; set => SDT = value; }
        public string strNgayVaoLam { get => NgayVaoLam; set => NgayVaoLam = value; }
      

        public NhanVienDTO (string cmnd, string tenNV, string ngaySinh, string sdt, string ngayVaoLam, int trangThai) 
        {
            this.CMND = cmnd;
            this.TenNV = tenNV;
            this.NgaySinh = ngaySinh;
            this.SDT = sdt;
            this.NgayVaoLam = ngayVaoLam;
          
        }
        public NhanVienDTO(DataRow dataRow)
        {
            this.CMND = (string)dataRow["CMND"];
            this.TenNV = (string)dataRow["TenNV"];
            this.NgaySinh = dataRow["NgaySinh"].ToString();
            this.SDT = (string)dataRow["SDT"];
            this.NgayVaoLam = dataRow["NgayVaoLam"].ToString();
            
            
        }
    }
}
