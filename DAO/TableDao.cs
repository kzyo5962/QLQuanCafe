using System;
using DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAO
{
    public class TableDao
    {
        private static TableDao instance;
        QuanLyQuanCaFeEntities _qlcfEf = new QuanLyQuanCaFeEntities();
        int ChangeMaban(string maBan)
        {
            string ma = maBan.Substring(3);

            int soBan = Convert.ToInt32(ma);
            return soBan;
        }
        public static TableDao Instance
        {
            get
            {
                if (instance == null)
                    instance = new TableDao();
                return instance;
            }
            private set { TableDao.instance = value; }
        }
        private  TableDao()
        {

        }
        //Them Ban
        public bool InsertBan(int soGhe,int trangThai=0,int tinhTrang=1)
        {
            try
            {
                BAN ban = new BAN
                {
                    SoGhe = soGhe,
                    TrangThai = trangThai,
                    TinhTrang = tinhTrang
                };
                _qlcfEf.BANs.Add(ban);
                _qlcfEf.SaveChanges();
               
                return true;
            }catch(Exception e)
            {
                return false;
            }
            
        }
        public List<TableDTO> LoadListTable()
        {
            string execGetBan = "select * from Ban";
            List<TableDTO> list = new List<TableDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery(execGetBan);
            foreach (DataRow row in data.Rows)
            {
                TableDTO item = new TableDTO(row);
                list.Add(item);
            }
            return list;
        }
        public bool CapNhatBan(int MaBan, int iTrangThai)
        {
            try
            {
                BAN ban = new BAN();
                ban = _qlcfEf.BANs.SingleOrDefault(u => u.ID == MaBan);
                ban.TrangThai = iTrangThai;
                _qlcfEf.SaveChanges();
                return true;
            }catch(Exception e)
            {
                return false;
            }
        }
        public int upDateStatusBan(int MaBan,int iTrangThai)
        {
            string strSqlUpdate = "update Ban set trangthai={0} where Id='{1}'";
            string strInsert = string.Format(strSqlUpdate,iTrangThai,MaBan);


            int sqlCmd = DataProvider.Instance.ExecuteNonQuery(strInsert);

            return sqlCmd;

        }
        public List<TableDTO> LoadListTableNull()
        {
            string execGetBan = "select * from Ban where trangthai=0";
            List<TableDTO> list = new List<TableDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery(execGetBan);
            foreach (DataRow row in data.Rows)
            {
              
                TableDTO item = new TableDTO(row,1);
                list.Add(item);
            }
            return list;
        }
       

    }
}
