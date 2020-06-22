using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BillDAO
    {
        private static BillDAO instance;


        public static BillDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillDAO();
                return instance;
            }
            private set { BillDAO.Instance = value; }
        }
        public void InsertBill(int idTable,int idNhanVien)
        {
            string sqlInsert = "inserBill @idTable @maNv";
            object[] obj = new object [] { idTable, idNhanVien };
            DataProvider.Instance.ExecuteNonQuery(sqlInsert, obj);
        }
        public int GetUncheckBillIDByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM HoaDon WHERE MaBan = " + id + " AND status = 0");

            if (data.Rows.Count > 0)
            {
                BillDTO bill = new BillDTO(data.Rows[0]);
                return bill.ID;
            }

            return -1;
        }

       
    }
}
