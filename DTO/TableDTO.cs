using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TableDTO
    {
        public TableDTO(int maBan, int soghe, int trangthai)
        {
            this.IMaBan = maBan;
            this.ISoGhe = soghe;
            this.ITrangThai = trangthai;
        }
        public TableDTO(DataRow dataRow)
        {
            this.iMaBan = (int)dataRow["ID"];
            this.ISoGhe = (int)dataRow["SoGhe"];
            this.ITrangThai = (int)dataRow["TrangThai"];
        }
        private int iMaBan;
        private int iSoGhe;
        private int iTrangThai;

        public int IMaBan { get => iMaBan; set => iMaBan = value; }
        public int ISoGhe { get => iSoGhe; set => iSoGhe = value; }
        public int ITrangThai { get => iTrangThai; set => iTrangThai = value; }
    }
}
