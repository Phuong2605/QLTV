using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;

namespace DTO
{
    public class CuonSach
    {
        private int ma;
        private string trangthai;
        private int tuasachma;

        public int Ma
        {
            get
            {
                return ma;
            }

            set
            {
                ma = value;
            }
        }

        public string Trangthai
        {
            get
            {
                return trangthai;
            }

            set
            {
                trangthai = value;
            }
        }

        public int Tuasachma
        {
            get
            {
                return tuasachma;
            }

            set
            {
                tuasachma = value;
            }
        }
        public DataTable get_cuonsach()
        {
            return DATA.get_cuonsach();
        }
        public void them()
        {
            DATA.them_cuonsach(ma, trangthai, tuasachma);
        }
        public void sua()
        {
            DATA.sua_cuonsach(ma, trangthai, tuasachma);
        }
        public void xoa(int ma)
        {
            DATA.xoa_cuonsach(ma);
        }
    }
}
