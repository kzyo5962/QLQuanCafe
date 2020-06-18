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
        public int upDateStatusBan(string strMaBan,int iTrangThai)
        {
            string strSqlUpdate = "update Ban set trangthai={0} where MaBan='{1}'";
            string strInsert = string.Format(strSqlUpdate,iTrangThai,strMaBan);


            int sqlCmd = DataProvider.Instance.ExecuteNonQuery(strInsert);

            return sqlCmd;

        }
    }
}
