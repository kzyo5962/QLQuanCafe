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
            string sqlInsert = "exec inserBill "+idTable+", "+idNhanVien;
            
            DataProvider.Instance.ExecuteNonQuery(sqlInsert);
        }
        public int GetUncheckBillIDByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM HoaDon WHERE MaBan = " + id + " AND trangthai = 1");

            if (data.Rows.Count > 0)
            {
                BillDTO bill = new BillDTO(data.Rows[0]);
                return bill.ID;
            }

            return -1;
        }
        public int GetMaxIDBill()
        {
            return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(id) FROM HoaDon");
            //try
            //{
                
            //}
            //catch
            //{
            //    return 1;
            //}
        }

    }
}
