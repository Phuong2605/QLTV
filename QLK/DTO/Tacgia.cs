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
    public class TacGia
    {
        private int ma;
        private string ten;
        private string gioitinh;
        private string quequan;

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

        public string Gioitinh
        {
            get
            {
                return gioitinh;
            }

            set
            {
                gioitinh = value;
            }
        }

        public string Quequan
        {
            get
            {
                return quequan;
            }

            set
            {
                quequan = value;
            }
        }
        public static DataTable get_tacgia()
        {
            return DATA.get_tacgia();
        }
        public void them()
        {
            DATA.them_tacgia(ma, ten, gioitinh, quequan);
        }
        public void sua()
        {
            DATA.sua_tacgia(ma, ten, gioitinh, quequan);
        }
        public void xoa(int ma)
        {
            DATA.xoa_tacgia(ma);
        }
    }
}
