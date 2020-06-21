﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class BillInfoDao
    {
        private static BillInfoDao instance;
        private BillInfoDao()
        {

        }

        public static BillInfoDao Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillInfoDao();
                return instance;
            }

            private set => instance = value;
        }
        public List<BillInfoDTO> getBillInfoByIDTable(int idTable,ref float tongTien)
        {
            
            List<BillInfoDTO> listBillInfo = new List<BillInfoDTO>();
            string sqlQuery = "exec GetBill " + idTable;
            DataTable dt = DataProvider.Instance.ExecuteQuery(sqlQuery);
            foreach(DataRow dr in dt.Rows)
            {
               
                BillInfoDTO billInfo = new BillInfoDTO(dr);
                tongTien = tongTien + billInfo.ThanhTien;
               listBillInfo.Add(billInfo);
            }
            return listBillInfo;
        }
        public void InsertBillInfo(int maHD,int maMenu,int soLuong, float giamGia,float giaBan)
        {
            string sqlInsert = "inserBillInfo @idTable @maNv";
            object[] obj = new object[] { maHD,maHD,soLuong,giamGia,giaBan};
            DataProvider.Instance.ExecuteNonQuery(sqlInsert, obj);
        }
    }
}
