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
    public partial class UC_TacGia : UserControl
    {
        public UC_TacGia()
        {
            InitializeComponent();
        }
        TacGia tg = new TacGia();
        bool ThemMoi;

        void KhoaDieuKhien()
        {
            txtMa.Enabled = false;
            txtTen.Enabled = false;
            cboGioitinh.Enabled = false;
            txtQuequan.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }

        void MoDieuKhien()
        {
            txtTen.Enabled = true;
            txtQuequan.Enabled = true;
            cboGioitinh.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }

        void SetNull()
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtQuequan.Text = "";
            cboGioitinh.Text = "";
        }


        void HienThi()
        {
            DataTable dt = tg.get_tacgia();
            dgvTacgia.DataSource = dt;
        }

        void TimKiem()
        {
            DataTable dt = new DataTable();
            string sql = @"Select ma as N'Mã tác gia', ten as N'Tên tác giả', gioitinh as N'Giới tính', quequan as N'Quê quán'  from tacgia where ten like '%" + txtTimKiem.Text.Trim() + "%'";
            dt = DBConnect.GetData(sql);
            dgvTacgia.DataSource = dt;
        }

        private void UC_TacGia_Load(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            HienThi();
        }

        private void dgvTacgia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KhoaDieuKhien();
            try
            {
                int Row_Index = e.RowIndex;
                txtMa.Text = dgvTacgia.Rows[Row_Index].Cells[0].Value.ToString();
                txtTen.Text = dgvTacgia.Rows[Row_Index].Cells[1].Value.ToString();
                cboGioitinh.Text = dgvTacgia.Rows[Row_Index].Cells[2].Value.ToString();
                txtQuequan.Text = dgvTacgia.Rows[Row_Index].Cells[3].Value.ToString();
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

        private void button1_Click(object sender, EventArgs e)
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

                tg.Ma = a;
                tg.xoa(tg.Ma);
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
                    tg.Ma = Int32.Parse(txtMa.Text);
                    tg.Ten = txtTen.Text;
                    tg.Gioitinh = cboGioitinh.Text;
                    tg.Quequan = txtQuequan.Text;
                    
                    tg.them();

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
                    tg.Ma = Int32.Parse(txtMa.Text);
                    tg.Ten = txtTen.Text;
                    tg.Gioitinh = cboGioitinh.Text;
                    tg.Quequan = txtQuequan.Text;
                    
                    tg.sua();
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
