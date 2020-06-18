using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DangNhapDAO
    {
        private static DangNhapDAO instance;


        public static DangNhapDAO Intance
        {
            get
            {
                if (instance == null)
                    instance = new DangNhapDAO();
                return instance;
            }
            private set { DangNhapDAO.Intance = value; }
        }

        
    }
}
