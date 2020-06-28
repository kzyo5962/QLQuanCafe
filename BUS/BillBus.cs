﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class BillBus
    {
        private static BillBus instance;


        private BillBus()
        {

        }

        public static BillBus Instance
        {
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
        public int GetUncheckBillIDByTableID(int id)
        {
            return BillDAO.Instance.GetUncheckBillIDByTableID(id);
        }
        public int GetMaxIDBill()
        {
            return BillDAO.Instance.GetMaxIDBill();
        }
        public void InsertBill(int idTable, int idNhanVien)
        {
            BillDAO.Instance.InsertBill(idTable, idNhanVien);
        }
        public void DoiBan(int idCu, int idMoi)
        {
            BillDAO.Instance.DoiBan(idCu, idMoi);
        }
        public bool UpdateBill(int Mabill)
        {
            return BillDAO.Instance.UpdateBill(Mabill);
        }
        public List<BillDTO> getListHD(string tuNgay, string denNgay)
        {
            return BillDAO.Instance.getListHD(tuNgay, denNgay);
        }
    }
}
