using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
   public  class DATA
    {
        #region Tua Sach
        public static DataTable get_tuasach()
        {
            return DBConnect.GetData("get_tuasach");
        }

        public static int them_tuasach(string ten, int namXB, int nhaXBma, int soluong, int theloaima)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ten",(ten!=null && ten.Trim()!="")?(object)ten:DBNull.Value),
                new SqlParameter("@soluong",(soluong >0)?(object)soluong:DBNull.Value),
                new SqlParameter("@namXB",(namXB > 0)?(object)namXB:DBNull.Value),
                new SqlParameter("@nhaXBma",nhaXBma),
                new SqlParameter("@theloaima",theloaima)
            };
            return DBConnect.ExecuteNonQuery("them_tuasach", para);
        }

        public static int sua_tuasach(int ma, string ten, int namXB, int nhaXBma, int soluong, int theloaima)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@ten",(ten!=null && ten.Trim()!="")?(object)ten:DBNull.Value),
                new SqlParameter("@soluong",(soluong >0)?(object)soluong:DBNull.Value),
                new SqlParameter("@namXB",(namXB > 0)?(object)namXB:DBNull.Value),
                new SqlParameter("@nhaXBma",nhaXBma),
                new SqlParameter("@theloaima",theloaima)
            };
            return DBConnect.ExecuteNonQuery("sua_tuasach", para);
        }
        public static int xoa_tuasach(int ma)
        {
            SqlParameter[] para = new SqlParameter[]
           {
                 new SqlParameter("@ma",ma)
           };
            return DBConnect.ExecuteNonQuery("xoa_tuasach", para);
        }
        #endregion

        #region The Loai
        public static DataTable get_theloai()
        {
            return DBConnect.GetData("get_theloai");
        }

        public static int them_theloai(string ten, string mota)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ten",(ten!=null && ten.Trim()!="")?(object)ten:DBNull.Value),
                new SqlParameter("@mota",(mota!=null && mota.Trim()!="")?(object)mota:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("them_theloai", para);
        }

        public static int sua_theloai(int ma, string ten, string mota)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@ten",(ten!=null && ten.Trim()!="")?(object)ten:DBNull.Value),
                new SqlParameter("@mota",(mota!=null && mota.Trim()!="")?(object)mota:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("sua_theloai", para);
        }
        public static int xoa_theloai(int ma)
        {
            SqlParameter[] para = new SqlParameter[]
           {
                 new SqlParameter("@ma",ma)
           };
            return DBConnect.ExecuteNonQuery("xoa_theloai", para);
        }
        #endregion

        #region Nha Xuat Ban
        public static DataTable get_nhaxuatban()
        {
            return DBConnect.GetData("get_nhaxuatban");
        }

        public static int them_nhaxuatban(string ten,string diachi, string sdt)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ten",(ten!=null && ten.Trim()!="")?(object)ten:DBNull.Value),
                new SqlParameter("@diachi",(diachi!=null && diachi.Trim()!="")?(object)diachi:DBNull.Value),
                  new SqlParameter("@sdt",(sdt!=null && sdt.Trim()!="")?(object)sdt:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("them_nhaxuatban", para);
        }

        public static int sua_nhaxuatban(int ma, string ten, string diachi, string sdt)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
               new SqlParameter("@ten",(ten!=null && ten.Trim()!="")?(object)ten:DBNull.Value),
                new SqlParameter("@diachi",(diachi!=null && diachi.Trim()!="")?(object)diachi:DBNull.Value),
                  new SqlParameter("@sdt",(sdt!=null && sdt.Trim()!="")?(object)sdt:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("sua_nhaxuatban", para);
        }
        public static int xoa_nhaxuatban(int ma)
        {
            SqlParameter[] para = new SqlParameter[]
           {
                 new SqlParameter("@ma",ma)
           };
            return DBConnect.ExecuteNonQuery("xoa_nhaxuatban", para);
        }
        #endregion

        #region Doc Gia
        public static DataTable get_docgia()
        {
            return DBConnect.GetData("get_docgia");
        }

        public static int them_docgia(int ma,string ten, string gioitinh, DateTime ngaysinh, string sodienthoai)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@ten",(ten!=null && ten.Trim()!="")?(object)ten:DBNull.Value),
                new SqlParameter("@gioitinh",(gioitinh!= null && gioitinh.Trim()!="")?(object)gioitinh:DBNull.Value),
                new SqlParameter("@ngaysinh",ngaysinh),
                new SqlParameter("@sodienthoai",(sodienthoai != null && sodienthoai.Trim()!="")?(object)sodienthoai:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("them_docgia", para);
        }
        public static int sua_docgia(int ma,string ten, string gioitinh, DateTime ngaysinh, string sodienthoai)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@ten",(ten!=null && ten.Trim()!="")?(object)ten:DBNull.Value),
                new SqlParameter("@gioitinh",(gioitinh!= null && gioitinh.Trim()!="")?(object)gioitinh:DBNull.Value),
                new SqlParameter("@ngaysinh",ngaysinh),
                new SqlParameter("@sodienthoai",(sodienthoai != null && sodienthoai.Trim()!="")?(object)sodienthoai:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("sua_docgia", para);
        }
        public static int xoa_docgia(int ma)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma)
            };
            return DBConnect.ExecuteNonQuery("xoa_docgia", para);
        }
        #endregion

        #region Tac Gia
        public static DataTable get_tacgia()
        {
            return DBConnect.GetData("get_tacgia");
        }

        public static int them_tacgia(int ma, string ten, string gioitinh, string quequan)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@ten",(ten!=null && ten.Trim()!="")?(object)ten:DBNull.Value),
                new SqlParameter("@gioitinh",(gioitinh!= null && gioitinh.Trim()!="")?(object)gioitinh:DBNull.Value),
                new SqlParameter("@quequan",(quequan != null && quequan.Trim()!="")?(object)quequan:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("them_tacgia", para);
        }
        public static int sua_tacgia(int ma, string ten, string gioitinh, string quequan)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@ten",(ten!=null && ten.Trim()!="")?(object)ten:DBNull.Value),
                new SqlParameter("@gioitinh",(gioitinh!= null && gioitinh.Trim()!="")?(object)gioitinh:DBNull.Value),
                new SqlParameter("@quequan",(quequan != null && quequan.Trim()!="")?(object)quequan:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("sua_tacgia", para);
        }
        public static int xoa_tacgia(int ma)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma)
            };
            return DBConnect.ExecuteNonQuery("xoa_tacgia", para);
        }
        #endregion

        #region Cuon Sach
        public static DataTable get_cuonsach()
        {
            return DBConnect.GetData("get_cuonsach");
        }

        public static int them_cuonsach(int ma, string trangthai, int tuasachma)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@trangthai",(trangthai!=null && trangthai.Trim()!="")?(object)trangthai:DBNull.Value),
                new SqlParameter("@tuasachma",tuasachma)
            };
            return DBConnect.ExecuteNonQuery("them_cuonsach", para);
        }
        public static int sua_cuonsach(int ma, string trangthai, int tuasachma)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@trangthai",(trangthai!=null && trangthai.Trim()!="")?(object)trangthai:DBNull.Value),
                new SqlParameter("@tuasachma",tuasachma)
            };
            return DBConnect.ExecuteNonQuery("sua_cuonsach", para);
        }
        public static int xoa_cuonsach(int ma)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma)
            };
            return DBConnect.ExecuteNonQuery("xoa_cuonsach", para);
        }
        #endregion
    }
}
