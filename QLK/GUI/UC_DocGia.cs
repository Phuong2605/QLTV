using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAL;

namespace GUI
{
    public partial class UC_DocGia : UserControl
    {
        public UC_DocGia()
        {
            InitializeComponent();
        }

        DocGia dg = new DocGia();
        bool ThemMoi;

        void KhoaDieuKhien()
        {
            txtMa.Enabled = false;
            txtTen.Enabled = false;
            dtpNgaysinh.Enabled = false;
            cboGioitinh.Enabled = false;
            txtsdt.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }

        void MoDieuKhien()
        {
            txtMa.Enabled = false;
            txtTen.Enabled = true;
            dtpNgaysinh.Enabled = true;
            cboGioitinh.Enabled = true;
            txtsdt.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }

        void SetNull()
        {
            txtMa.Text = "";
            txtTen.Text = "";
            dtpNgaysinh.Text = "";
            cboGioitinh.Text = "";
            txtsdt.Text = "";
        }


        void HienThi()
        {
            DataTable dt = DTO.DocGia.get_docgia();
            dgvDocGia.DataSource = dt;
        }

        void TimKiem()
        {
            DataTable dt = new DataTable();
            string sql = @"Select ma as N'Mã đọc giả', ten as N'Tên đọc giả', ngaysinh as N'Ngày sinh', gioitinh as N'Giới tính', sodienthoai as N'Số điện thoại'  from docgia where ten like '%" + txtTimKiem.Text.Trim() + "%'";
            dt = DBConnect.GetData(sql);
            dgvDocGia.DataSource = dt;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            SetNull();
            ThemMoi = true;
        }

        private void UC_DocGia_Load(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            HienThi();
        }

        private void dgvDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KhoaDieuKhien();
            try
            {
                int Row_Index = e.RowIndex;
                txtMa.Text = dgvDocGia.Rows[Row_Index].Cells[0].Value.ToString();
                txtTen.Text = dgvDocGia.Rows[Row_Index].Cells[1].Value.ToString();
                dtpNgaysinh.Text = dgvDocGia.Rows[Row_Index].Cells[2].Value.ToString();
                cboGioitinh.Text = dgvDocGia.Rows[Row_Index].Cells[3].Value.ToString();
                txtsdt.Text = dgvDocGia.Rows[Row_Index].Cells[4].Value.ToString();
            }
            catch
            {

            }
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

                dg.Ma = a;
                dg.xoa(dg.Ma);
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (ThemMoi == true)
            {
                try
                {
                    int a;
                    int.TryParse(txtMa.Text, out a);
                    dg.Ma = a;
                    dg.Ten = txtTen.Text;
                    dg.Ngaysinh = Convert.ToDateTime(dtpNgaysinh.Text);
                    dg.Gioitinh = cboGioitinh.Text;
                    dg.Sodienthoai = txtsdt.Text;

                    dg.them();

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
                    dg.Ma = a;
                    dg.Ten = txtTen.Text;
                    dg.Ngaysinh = Convert.ToDateTime(dtpNgaysinh.Text);
                    dg.Gioitinh = cboGioitinh.Text;
                    dg.Sodienthoai = txtsdt.Text;

                    dg.sua();
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
    }
}
