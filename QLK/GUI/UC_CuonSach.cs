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
    public partial class UC_CuonSach : UserControl
    {
        public UC_CuonSach()
        {
            InitializeComponent();
        }
        CuonSach cs = new CuonSach();
        bool ThemMoi;

        void KhoaDieuKhien()
        {
            txtMa.Enabled = false;
            txtTrangthai.Enabled = false;
            cboMatuasach.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }

        void MoDieuKhien()
        {
            txtMa.Enabled = false;
            txtTrangthai.Enabled = true;
            cboMatuasach.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }

        void SetNull()
        {
            txtMa.Text = "";
            txtTrangthai.Text = "";
            txtTentuasach.Text = "";
            cboMatuasach.Text = "";
        }


        void HienThi()
        {
            DataTable dt = DTO.CuonSach.get_cuonsach();
            dgvCuonsach.DataSource = dt;
        }

        void TimKiem()
        {
            DataTable dt = new DataTable();
            string sql = @"Select cs.ma as N'Mã cuốn sách', cs.trangthai as N'Trạng thái', cs.tuasachma as N'Mã tựa sách',ts.ten as N'Tên tựa sách'  from cuonsach cs join tuasach ts where ten like '%" + txtTimKiem.Text.Trim() + "%'";
            dt = DBConnect.GetData(sql);
            dgvCuonsach.DataSource = dt;
        }
        void HienThi_cboMatuasach()
        {
            DataTable dt = new DataTable();
            dt = DBConnect.GetData(@"Select ma from tuasach");
            cboMatuasach.DataSource = dt;
            cboMatuasach.DisplayMember = "ma";
            cboMatuasach.ValueMember = "ma";

        }
        private void dgvTacgia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            SetNull();
            ThemMoi = true;
        }

        private void dgvCuonsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KhoaDieuKhien();
            try
            {
                int Row_Index = e.RowIndex;
                txtMa.Text = dgvCuonsach.Rows[Row_Index].Cells[0].Value.ToString();
                txtTrangthai.Text = dgvCuonsach.Rows[Row_Index].Cells[1].Value.ToString();
                cboMatuasach.Text = dgvCuonsach.Rows[Row_Index].Cells[2].Value.ToString();
                txtTentuasach.Text = dgvCuonsach.Rows[Row_Index].Cells[3].Value.ToString();
            }
            catch
            {

            }
        }

        private void UC_CuonSach_Load(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            HienThi();
            HienThi_cboMatuasach();
        }

        private void cboMatuasach_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = DBConnect.GetData(@"Select ten from tuasach where ma= '" + cboMatuasach.Text + "' ");
            if (dt.Rows.Count > 0)
            {
                txtTentuasach.Text = dt.Rows[0]["ten"].ToString();
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

                cs.Ma = a;
                cs.xoa(cs.Ma);
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
                    int a,b;
                    int.TryParse(txtMa.Text, out a);
                    int.TryParse(cboMatuasach.Text, out b);
                    cs.Ma = a;
                    cs.Trangthai = txtTrangthai.Text;
                    cs.Tuasachma = b;

                    cs.them();

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
                    int a, b;
                    int.TryParse(txtMa.Text, out a);
                    int.TryParse(cboMatuasach.Text, out b);
                    cs.Ma = a;
                    cs.Trangthai = txtTrangthai.Text;
                    cs.Tuasachma = b;


                    cs.sua();
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
