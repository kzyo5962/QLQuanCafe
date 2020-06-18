using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data.SqlClient;

namespace BUS
{
    public class NhanVienBUS
    {
        private static NhanVienBUS instance;

        public static NhanVienBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienBUS();
                return instance;
            }
            private set => NhanVienBUS.Instance = value;
        }

        public List<NhanVienDTO> listNhanVien()
        {
            return NhanVienDAO.Intance.getListNhanVien();
        }

        public int ThemNhanVien(string cmnd,string tenNV, string ngaySinh, string sdt, string ngayVaoLam)
        {
            return DAO.NhanVienDAO.Intance.ThemNhanVien(cmnd,tenNV,ngaySinh,sdt,ngayVaoLam);
        }

        public int CapNhatNhanVien(string cmnd, string tenNV, string ngaySinh, string sdt, string ngayVaoLam)
        {
            return DAO.NhanVienDAO.Intance.CapNhatNhanVien(cmnd, tenNV, ngaySinh, sdt, ngayVaoLam);
        }
        public int XoaNhanVien(string cmnd)
        {
            return DAO.NhanVienDAO.Intance.XoaNhanVien(cmnd);
        }

        public List<NhanVienDTO> TimKiemNV(string name)
        {

            return DAO.NhanVienDAO.Intance.TimKiemNV(name);
        }



    }
}
