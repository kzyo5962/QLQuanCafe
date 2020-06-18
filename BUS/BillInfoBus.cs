using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
     public class BillInfoBus
    {
        private static BillInfoBus instance;


        private BillInfoBus()
        {

        }

        public static BillInfoBus Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillInfoBus();
                return instance;
            }
            private set
            {
                BillInfoBus.instance = value;
            }
        }
        public List<BillinfoDTO> getBillInfoByBill(int soHd)
        {

            return BillinfoDAO.Instance.getBillInfoByBill(soHd);
        }
        public int insertBillInfo(string MaThucUong, int MaHD, int SoLuong)
        {

            return BillinfoDAO.Instance.insertBillInfo(MaThucUong, MaHD, SoLuong);
        }
    }
}
