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

      
    }
}
