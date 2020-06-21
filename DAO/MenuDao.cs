using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class MenuDao
    {
        private static MenuDao instance;
        private MenuDao()
        {

        }

        public static MenuDao Instance { get {
                if (instance == null)
                    instance = new MenuDao();
                return instance;
            }

            private set => instance = value;
        }
        public List<MenuDTO> ListMenuById(int loai)
        {
            List<MenuDTO> listMenu = new List<MenuDTO>();
            listMenu = DataProvider.Instance._qlqcfEF.MENUs.Where(u => u.MaLoai == loai && u.TrangThai == 0).Select(
                v => new MenuDTO
                {
                    ID = v.ID,
                    TenMenu = v.TenMenu,
                    MaLoai = v.MaLoai,
                    TrangThai = v.TrangThai

                }).ToList();
           
            return listMenu;
        }
    }
}
