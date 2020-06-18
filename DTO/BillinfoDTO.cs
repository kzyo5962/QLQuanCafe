using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BillinfoDTO
    {
        private string strMaThucUong;
        private int iSoLuong;
        private int  iSoHd;

        public string StrMaThucUong { get => strMaThucUong; set => strMaThucUong = value; }
        public int ISoLuong { get => iSoLuong; set => iSoLuong = value; }
        public int ISoHd { get => iSoHd; set => iSoHd = value; }
        public BillinfoDTO(DataRow dr)
        {
            StrMaThucUong = (string)dr["MaThucUong"];
            ISoLuong = (int)dr["SoLuong"];
            ISoHd = (int)dr["SoHD"];
        }
        public BillinfoDTO(string maDoUong,int sl,int soHD)
        {
            this.ISoHd = soHD;
            this.StrMaThucUong = maDoUong;
            this.ISoLuong = sl;
        }
    }
}
