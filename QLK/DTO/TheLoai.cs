using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
namespace DTO
{
    public class TheLoai
    {
        private int ma;
        private string ten;
        private string mota;

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

        public string Mota
        {
            get
            {
                return mota;
            }

            set
            {
                mota = value;
            }
        }

        public DataTable get_theloai()
        {
            return DATA.get_theloai();
        }

        public void them_theloai()
        {
            DATA.them_theloai(ten, mota);
        }
        public void sua_theloai()
        {
            DATA.sua_theloai(ma, ten, mota);
        }
        public void xoa_theloai(int ma)
        {
            DATA.xoa_theloai(ma);
        }
    }
}
