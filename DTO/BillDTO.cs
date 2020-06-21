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
        public int ID { get; set; }
        public Nullable<System.DateTime> NgayLap { get; set; }
        public int trangthai { get; set; }
        public int MaNV { get; set; }
        public int MaBan { get; set; }
        public Nullable<System.DateTime> CheckOut { get; set; }
        public BillDTO(DataRow dataRow)
        {
            this.ID = (int)dataRow["Id"];
            this.NgayLap =Convert.ToDateTime( dataRow["NgayLap"]);
            this.trangthai = (int)dataRow["trangthai"];
            this.MaNV = (int)dataRow["MaNV"];
            this.MaBan = (int)dataRow["MaBan"];
            this.CheckOut = Convert.ToDateTime(dataRow["CheckOut"]);

        }
    }
}
