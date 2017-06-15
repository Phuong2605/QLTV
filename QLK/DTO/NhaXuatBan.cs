using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;


namespace DTO
{
    public  class NhaXuatBan
    {
        private int ma;
        private string ten;
        private string diachi;
        private string sdt;

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

        public string Ten
        {
            get
            {
                return ten;
            }

            set
            {
                ten = value;
            }
        }

        public string Diachi
        {
            get
            {
                return diachi;
            }

            set
            {
                diachi = value;
            }
        }

        public string Sdt
        {
            get
            {
                return sdt;
            }

            set
            {
                sdt = value;
            }
        }
        public DataTable get_nhaxuatban()
        {
            return DATA.get_nhaxuatban();
        }
     
        public void them_nhaxuatban()
        {
            DATA.them_nhaxuatban(ten, diachi,sdt);
        }
        public void sua_nhaxuatban()
        {
            DATA.sua_nhaxuatban(ma, ten, diachi, sdt);
        }
        public void xoa_nhaxuatban(int ma)
        {
            DATA.xoa_nhaxuatban(ma);
        }

    }
}
