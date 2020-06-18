using DTO;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BillDao
    {
    
        private static BillDao instance;
        private BillDao()
        {

        }

        public static BillDao Instance { get {
                if (instance == null)
                    instance = new BillDao();
                return instance;
            }

            private set => instance = value;
        }
        //public int inSertHoaDon(string ban,DateTime date)
        //{
        //    string sql="insert into HoaDon(NgayLap,CMMD,MaBan,TrangThai,CheckOut) values({0},"
        //}
        public int  getCheckBillByTableID(string idTable)
        {
            string sqlInsert = "select * from HOADON where MaBan= '{0}' and TrangThai=0";
            string sqlICmd = string.Format(sqlInsert, idTable);
            DataTable data = DataProvider.Instance.ExecuteQuery(sqlICmd);
            if (data.Rows.Count > 0)
            {
                BillDTO billDTO = new BillDTO(data.Rows[0]);
                return billDTO.ISoHD;
            }
            return -1;
        }
        //public string getMaHDByBan(string idTable)
        //{
        //    DataTable data = DataProvider.Instance.ExecuteQuery("select * from HOADON where MaBan=" + idTable + "and TrangThai=0");
        //    if (data.Rows.Count > 0)
        //    {
        //        BillDTO billDTO = new BillDTO(data.Rows[0]);
        //        return billDTO.ISoHD;
        //    }
        //}
        public int insertBill(DateTime  ngayLap,string strCmnd,string MaBan)
        {
            string strSqlInsert = "insert into HOADON(NGAYLAP,CMND,TRANGTHAI,GIAMGIA,MABAN) values('{0}','{1}','{2}','{3}','{4}')";
            string strInsert = string.Format(strSqlInsert, ngayLap, strCmnd,0,0,MaBan);


            int sqlCmd = DataProvider.Instance.ExecuteNonQuery(strInsert);
            
            return sqlCmd;
        }
    }

}
