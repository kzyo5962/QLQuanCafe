using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
namespace DAO
{
    public class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;

        public static TaiKhoanDAO Intance
        {
            get
            {
                if (instance == null)
                    instance = new TaiKhoanDAO();
                return instance;
            }
            private set { TaiKhoanDAO.Intance = value; }
        }

        public List<TaiKhoanDTO> GetListTaiKhoan()
        {
            List<TaiKhoanDTO> list = new List<TaiKhoanDTO>();
            string query = "select a.TenNV, b.username,b.pass,c.TenLoai,b.trangthai from NHANVIEN a, TAIKHOAN b, LOAITK c where a.ID=b.MaNV and b.MaLoai=c.ID and b.trangthai=1";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dataRow in data.Rows)
            {
                TaiKhoanDTO item = new TaiKhoanDTO(dataRow);
                list.Add(item);
            }
            return list;
        }
        public int AddTaiKhoan(string username, string pass, int maloai)
        {
            int result = 0;
            string query = string.Format("insert into TAIKHOAN(username,pass,MaLoai,trangthai) values('{0}','{1}','{2}',1)", username, pass, maloai);
            result = DataProvider.Instance.ExecuteNonQuery(query);
            return result;
        }
    }
}
