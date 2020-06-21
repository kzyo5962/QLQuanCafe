using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class LoaiMenuDao
    {
        QuanLyQuanCaFeEntities _qlqcfEF = new QuanLyQuanCaFeEntities();
        private static LoaiMenuDao instance;
        private LoaiMenuDao()
        {

        }

        public static LoaiMenuDao Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoaiMenuDao();
                return instance;
            }

            private set => instance = value;
        }
       public List<LoaiMenuDTO> ListLoaiMenu()
        {
            List<LoaiMenuDTO> listLoai = new List<LoaiMenuDTO>();
            listLoai = _qlqcfEF.LOAIMENUs.Where(u => u.TrangThai == 0).Select(v => new LoaiMenuDTO
            {
                ID=v.ID,
                TenLoai=v.TenLoai,
                TrangThai=v.TrangThai
            }).ToList();
            return listLoai;
        }
    }
}
