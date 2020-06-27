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
        private QuanLyQuanCaFeEntities _qlcfEf = new QuanLyQuanCaFeEntities();

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
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM HoaDon WHERE MaBan = " + id + " AND trangthai = 0");

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
        public void DoiBan(int idCu, int idMoi)
        {

            string execChuyenBan = "exec ChuyenBan " + idCu + " , " + idMoi;
            int exec = DataProvider.Instance.ExecuteNonQuery(execChuyenBan);
        }
        public bool UpdateBill(int Mabill)
        {
            try
            {
                HOADON bill = new HOADON();
                bill = _qlcfEf.HOADONs.SingleOrDefault(u => u.ID==Mabill);
                DateTime now=DateTime.Now;
                bill.trangthai = 1;
                bill.CheckOut = now;
                _qlcfEf.SaveChanges();
                return true;


            }
            catch(Exception e)
            {
                return false;
            }
        }
    }
}
