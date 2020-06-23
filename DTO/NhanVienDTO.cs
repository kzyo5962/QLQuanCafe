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

        private int ID;
        private string TenNV;
        private string SDT;
        private string NgayVaoLam;
        private string Diachi;
       

      
        
        public string Diachi1 { get => Diachi; set => Diachi = value; }
        public string TenNV1 { get => TenNV; set => TenNV = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
        public string NgayVaoLam1 { get => NgayVaoLam; set => NgayVaoLam = value; }
        public int ID1 { get => ID; set => ID = value; }

        public NhanVienDTO (int id, string tenNV, string ngaySinh, string sdt, string ngayVaoLam, int trangThai) 
        {
            this.ID = id;
            this.TenNV = tenNV;
            this.SDT = sdt;
            this.NgayVaoLam = ngayVaoLam;
          
        }
        public NhanVienDTO(DataRow dataRow)
        {
            this.ID = (int)dataRow["ID"];
            this.TenNV = (string)dataRow["TenNV"];
            this.SDT = (string)dataRow["SDT"];
            this.NgayVaoLam = dataRow["NgayVaoLam"].ToString();
            this.Diachi = (string)dataRow["diachi"];
            
            
        }
    }
}
