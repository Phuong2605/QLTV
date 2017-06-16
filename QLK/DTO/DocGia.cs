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
    public class DocGia
    {
        private int ma;
        private string ten;
        private string gioitinh;
        private DateTime ngaysinh;
        private string sodienthoai;

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

        public DateTime Ngaysinh
        {
            get
            {
                return ngaysinh;
            }

            set
            {
                ngaysinh = value;
            }
        }

        public string Sodienthoai
        {
            get
            {
                return sodienthoai;
            }

            set
            {
                sodienthoai = value;
            }
        }
        public DataTable get_docgia()
        {
            return DATA.get_docgia();
        }
        public void them()
        {
            DATA.them_docgia(ma, ten, gioitinh, ngaysinh, sodienthoai);
        }
        public void sua()
        {
            DATA.sua_docgia(ma, ten, gioitinh, ngaysinh, sodienthoai);
        }
        public void xoa(int ma)
        {
            DATA.xoa_docgia(ma);
        }
    }
}
