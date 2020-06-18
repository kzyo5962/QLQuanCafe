using System;
using System.Collections.Generic;
using DTO;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BillinfoDAO
    {
        private static BillinfoDAO instance;
        private BillinfoDAO()
        {

        }

        public  static BillinfoDAO Instance {
            get
            {
                if (instance == null)
                    instance = new BillinfoDAO();
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        public List<BillinfoDTO> getBillInfoByBill(int soHd)
        {
            string sql = "select * from CHITIETHOAHON Where SoHD='" + soHd+"'";
            List<BillinfoDTO> dsBillInfo = new List<BillinfoDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery(sql);
            foreach(DataRow dataRow in data.Rows)
            {
                BillinfoDTO item = new BillinfoDTO(dataRow);
                dsBillInfo.Add(item);

            }
            return dsBillInfo;
        }
        public int insertBillInfo(string MaThucUong1, int MaHD1,int SoLuong1)
        {
            string strSqlInsert = "insert into CHITIETHOADON(MaThucUong,SoHD,SoLuong) values('{0}',{1},{2})";
            string strInsert = string.Format(strSqlInsert,MaThucUong1,MaHD1,SoLuong1);


            int sqlCmd = DataProvider.Instance.ExecuteNonQuery(strInsert);

            return sqlCmd;
        }
    }
}
