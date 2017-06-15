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
    public partial class UCNhaXuatBan : UserControl
    {
        public UCNhaXuatBan()
        {
            InitializeComponent();
        }
        NhaXuatBan nxb = new NhaXuatBan();
        bool ThemMoi;

        void KhoaDieuKhien()
        {
            txtMa.Enabled = false;
            txtTen.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSDT.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnCapNhat.Enabled = false;
        }

        void MoDieuKhien()
        {
         //   txtMa.Enabled = true;
            txtTen.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSDT.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = true;
        }

        void SetNull()
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
        }

        void HienThi()
        {
            DataTable dt = nxb.get_nhaxuatban();
            dgvNhaXuatBan.DataSource = dt;
        }

        void TimKiem()
        {
            DataTable dt = new DataTable();
            string sql = @"Select ma as N'Mã NXB', ten as N'Tên NXB', diachi as N'Địa chỉ', sdt as N'Số điện thoại'  from nhaxuatban where ten like '%" + txtTimKiem.Text.Trim() + "%'";
            dt = DBConnect.GetData(sql);
            dgvNhaXuatBan.DataSource = dt;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UCNhaXuatBan_Load(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            HienThi();
        }

        private void dgvNhaXuatBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KhoaDieuKhien();
            try
            {
                int Row_Index = e.RowIndex;
                txtMa.Text = dgvNhaXuatBan.Rows[Row_Index].Cells[0].Value.ToString();
                txtTen.Text = dgvNhaXuatBan.Rows[Row_Index].Cells[1].Value.ToString();
                txtDiaChi.Text = dgvNhaXuatBan.Rows[Row_Index].Cells[2].Value.ToString();
                txtSDT.Text = dgvNhaXuatBan.Rows[Row_Index].Cells[3].Value.ToString();
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
                nxb.Ma = a;
                nxb.xoa_nhaxuatban(nxb.Ma);
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
                    nxb.Ten = txtTen.Text;
                    nxb.Diachi = txtDiaChi.Text;
                    nxb.Sdt = txtSDT.Text;
                    nxb.them_nhaxuatban();
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
                    nxb.Ma = a;
                    nxb.Ten = txtTen.Text;
                    nxb.Diachi = txtDiaChi.Text;
                    nxb.Sdt = txtSDT.Text;
                    nxb.sua_nhaxuatban();
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

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
