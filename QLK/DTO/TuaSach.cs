using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace DTO
{
   public class TuaSach
    {
        private int ma;
        private string ten;
        private int namXB;
        private int nhaXBma;
        private int theloaima;
        private int soluong;

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

        public int NamXB
        {
            get
            {
                return namXB;
            }

            set
            {
                namXB = value;
            }
        }

        public int NhaXBma
        {
            get
            {
                return nhaXBma;
            }

            set
            {
                nhaXBma = value;
            }
        }

        public int Theloaima
        {
            get
            {
                return theloaima;
            }

            set
            {
                theloaima = value;
            }
        }

        public int Soluong
        {
            get
            {
                return soluong;
            }

            set
            {
                soluong = value;
            }
        }
        public DataTable get_tuasach()
        {
            return DATA.get_tuasach();
        }

        public void them_tuasach()
        {
            DATA.them_tuasach(ten, namXB, nhaXBma, soluong, theloaima);
        }
        public void sua_tuasach()
        {
            DATA.sua_tuasach(ma, ten, namXB, nhaXBma, soluong, theloaima);
        }
        public void xoa_tuasach(int ma)
        {
            DATA.xoa_tuasach(ma);
        }
    }
}
