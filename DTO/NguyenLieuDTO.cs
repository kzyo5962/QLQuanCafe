using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NguyenLieuDTO
    {
        private string strMANL;
        private string strTENNL;
        private string strDONVITINH;
        private int iDONGIA;
       
        public string StrNguyenLieu { get => strMANL; set => strMANL = value; }
        public string StrTENNL { get => strTENNL; set => strTENNL = value; }
        public string StrDONVITINH { get => strDONVITINH; set => strDONVITINH = value; }
        public int IDONGIA { get => iDONGIA; set => iDONGIA = value; }
       

        public NguyenLieuDTO(string maNL, string tenNL, string dvt, int donGia, int trangThai)
        {
            this.strMANL = maNL;
            this.strTENNL=tenNL;
            this.StrDONVITINH = dvt;
            this.IDONGIA = donGia;

        }
        public NguyenLieuDTO(DataRow dataRow)
        {
            this.strMANL = (string)dataRow["MANL"]; 
            this.strTENNL = (string)dataRow["TENNL"]; 
            this.StrDONVITINH = (string)dataRow["DONVITINH"]; 
            this.iDONGIA = (int)dataRow["DONGIA"];
          
            
        } 
    }
}
