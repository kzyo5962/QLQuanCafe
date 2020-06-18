using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class BillBus
    {
        private static BillBus instance;


        private BillBus()
        {

        }

        public static BillBus Instance {
            get
            {
                if (instance == null)
                    instance = new BillBus();
                return instance;
            }
            private set
            {
                BillBus.instance = value;
            }
        }
        public int getCheckBillByTableIdBus(string strTableId)
        {
            return BillDao.Instance.getCheckBillByTableID(strTableId);
        }
        public int insertBillBus(DateTime ngayLap, string strCmnd, string strMaBan)
        {
            return BillDao.Instance.insertBill(ngayLap, strCmnd,strMaBan);
        }

    }
}
