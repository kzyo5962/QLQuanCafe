using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO
{
    public  class NhanVienDAO
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Intance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienDAO();
                return instance;
            }
            private set { NhanVienDAO.Intance = value; }
        }


        public List<NhanVienDTO> getListNhanVien()
        {
            string strSQL = "SELECT * FROM NHANVIEN ";
            List<NhanVienDTO> listData = new List<NhanVienDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery(strSQL);
            foreach (DataRow row in data.Rows)
            {
                NhanVienDTO item = new NhanVienDTO(row);
                listData.Add(item);
            }
            return listData;
        }

        public int ThemNhanVien( string TenNV, string DiaChi, string SDT, string NgayVaoLam, string HinhAnh)
        {
            
            int result = 0;
            string sql =string.Format("INSERT INTO NHANVIEN(TenNV, NgayVaoLam,SDT, diachi, HinhAnh) VALUES(N'{0}', '{1}','{2}',N'{3}',N'{4}')",TenNV,NgayVaoLam,SDT,DiaChi,HinhAnh);
            result = DataProvider.Instance.ExecuteNonQuery(sql);
            return result;
        }

        public int CapNhatNhanVien(string cmnd, string tenNV, string ngaySinh, string sdt, string ngayVaoLam)
        {
            int result = 0;
            string sql = string.Format("UPDATE NHANVIEN SET TenNV=N'{0}', NgaySinh='{1}',SDT='{2}', NgayVaoLam='{3}' WHERE CMND='{4}' ", tenNV, ngaySinh, sdt, ngayVaoLam, cmnd);
            result = DataProvider.Instance.ExecuteNonQuery(sql);
            return result;
        }

        public int XoaNhanVien(int ID)
        {
            int result = 0;
            string sql = string.Format("UPDATE NHANVIEN SET TrangThai=0 WHERE ID={0}", ID);
            result = DataProvider.Instance.ExecuteNonQuery(sql);
            return result;
        }

        public List<NhanVienDTO> TimKiemNV(string name)
        {
            string strSQL =string.Format( "SELECT * FROM NHANVIEN WHERE TenNV LIKE N'{0}%'",name);
            List<NhanVienDTO> listData = new List<NhanVienDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery(strSQL);
            foreach (DataRow row in data.Rows)
            {
                NhanVienDTO item = new NhanVienDTO(row);
                listData.Add(item);
            }
            return listData;

        }
    }
}
