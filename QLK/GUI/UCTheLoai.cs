using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;
namespace GUI
{
    public partial class UCTheLoai : UserControl
    {
        public UCTheLoai()
        {
            InitializeComponent();
        }

        TheLoai tl = new TheLoai();
        bool ThemMoi;

        void KhoaDieuKhien()
        {
            txtMa.Enabled = false;
            txtTen.Enabled = false;
            rtbMoTa.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnCapNhat.Enabled = false;
        }

        void MoDieuKhien()
        {
          //  txtMa.Enabled = true;
            txtTen.Enabled = true;
            rtbMoTa.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = true;
        }

        void SetNull()
        {
            txtMa.Text = "";
            txtTen.Text = "";
            rtbMoTa.Text = "";
        }

        void HienThi()
        {
            DataTable dt = tl.get_theloai();
            dgvTheLoai.DataSource = dt;
        }

        void TimKiem()
        {
            DataTable dt = new DataTable();
            string sql = @"Select  ma as N'Mã', ten as N'Tên', mota as N'Mô tả'  from theloai where ten like '%" + txtTimKiem.Text.Trim() + "%'";
            dt = DBConnect.GetData(sql);
            dgvTheLoai.DataSource = dt;
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void UCTheLoai_Load(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            HienThi();
        }

        private void dgvTheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            KhoaDieuKhien();
            try
            {
                int Row_Index = e.RowIndex;
                txtMa.Text = dgvTheLoai.Rows[Row_Index].Cells[0].Value.ToString();
                txtTen.Text = dgvTheLoai.Rows[Row_Index].Cells[1].Value.ToString();
                rtbMoTa.Text = dgvTheLoai.Rows[Row_Index].Cells[2].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            SetNull();
            ThemMoi = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            txtMa.Enabled = false;
            ThemMoi = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int a;
                int.TryParse(txtMa.Text, out a);
                tl.Ma = a;
                tl.xoa_theloai(tl.Ma);
                MessageBox.Show("Đã xóa thành công!");
                KhoaDieuKhien();
                SetNull();
                HienThi();
            }
            catch
            {
                MessageBox.Show("Lỗi không thể xóa!");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (ThemMoi == true)
            {
                try
                {
                    tl.Ten = txtTen.Text;
                    tl.Mota = rtbMoTa.Text;
                    tl.them_theloai();
                    MessageBox.Show("Đã thêm thành công!");
                }
                catch
                {
                    MessageBox.Show("Lỗi!");
                    return;
                }
            }
            else
            {
                try
                {
                    int a;
                    int.TryParse(txtMa.Text, out a);
                    tl.Ma = a;
                    tl.Ten = txtTen.Text;
                    tl.Mota = rtbMoTa.Text;
                    tl.sua_theloai();
                    MessageBox.Show("Đã sửa thành công!");
                }
                catch
                {
                    MessageBox.Show("Lỗi!");
                    return;
                }
            }
            SetNull();
            KhoaDieuKhien();
            HienThi();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "nhập vào từ khóa cần tìm...")
            {
                HienThi();

            }
            else
                TimKiem();
        }

        private void txtTimKiem_MouseClick(object sender, MouseEventArgs e)
        {
            txtTimKiem.Text = "";
            txtTimKiem.ForeColor = Color.Black;
        }

        private void txtTimKiem_MouseLeave(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                txtTimKiem.ForeColor = Color.Gray;
                txtTimKiem.Text = "nhập vào từ khóa cần tìm...";
            }
        }
    }
}