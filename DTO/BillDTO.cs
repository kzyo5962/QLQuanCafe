using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BillDTO
    {
        string strCmnd;
        private DateTime? NgayLap;
        private DateTime? Checkout;
        string strMaBan;
        int iTrangThai;
        float fGiamGia;
        int iSoHD;
        public BillDTO(int id, DateTime? ngaylap, DateTime? checkOut, String maBan, int trangThai, float giamGia)
        {
            this.ISoHD = id;
            this.NgayLap = ngaylap;
            this.Checkout = checkOut;
            this.strMaBan = maBan;
            this.iTrangThai = trangThai;
            this.fGiamGia = giamGia;

        }
        public BillDTO(DataRow row)
        {
            this.ISoHD = (int)row["SoHD"];
            this.NgayLap1 = (DateTime?)row["NgayLap"];
           // this.Checkout = (DateTime?)row["checkOut"];
            this.strMaBan = (string)row["MaBan"];
            this.iTrangThai = (int)row["TrangThai"];
            this.fGiamGia = (int)row["GiamGia"];
        }
        public string StrCmnd { get => strCmnd; set => strCmnd = value; }
        public DateTime? NgayLap1 { get => NgayLap; set => NgayLap = value; }
        public DateTime? Checkout1 { get => Checkout; set => Checkout = value; }
        public string StrMaBan { get => strMaBan; set => strMaBan = value; }
        public int ITrangThai { get => iTrangThai; set => iTrangThai = value; }
        public float FGiamGia { get => fGiamGia; set => fGiamGia = value; }
        public int ISoHD { get => iSoHD; set => iSoHD = value; }
    }
}
