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
    public partial class UCTuaSach : UserControl
    {
        public UCTuaSach()
        {
            InitializeComponent();
        }
        TuaSach ts = new TuaSach();
       // TuaSach_TacGia tstg=new TuaSach_TacGia();
        bool ThemMoi;

        void KhoaDieuKhien()
        {
            txtMa.Enabled = false;
            txtTen.Enabled = false;
            txtSoLuong.Enabled = false;
         //   cboTacGia.Enabled = false;
            txtNamXuatBan.Enabled = false;
            cboNhaXuatBan.Enabled = false;
            cboTheLoai.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnCapNhat.Enabled = false;
        }

        void MoDieuKhien()
        {
           // txtMa.Enabled = true;
            txtTen.Enabled = true;
            txtSoLuong.Enabled = true;
          //  cboTacGia.Enabled = true;
            txtNamXuatBan.Enabled = true;
            cboNhaXuatBan.Enabled = true;
            cboTheLoai.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = true;
        }

        void SetNull()
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtSoLuong.Text = "";
            //cboTacGia.Text = "";
            cboNhaXuatBan.Text = "";
            cboTheLoai.Text = "";
            txtNamXuatBan.Text = "";
        }


        void HienThi()
        {
            DataTable dt = ts.get_tuasach();
            dgvTuaSach.DataSource = dt;
        }

        void HienThi_cboNhaXuatBan()
        {
            DataTable dt = new DataTable();
            dt = DBConnect.GetData(@"Select ma from nhaxuatban");
            cboNhaXuatBan.DataSource = dt;
            cboNhaXuatBan.DisplayMember = "ma";
            cboNhaXuatBan.ValueMember = "ma";

        }

        void HienThi_cboTheLoai()
        {
            DataTable dt = new DataTable();
            dt = DBConnect.GetData(@"Select ma from theloai");
            cboTheLoai.DataSource = dt;
            cboTheLoai.DisplayMember = "ma";
            cboTheLoai.ValueMember = "ma";

        }

        void TimKiem()
        {
            DataTable dt = new DataTable();
            string sql = @"Select ma as N'Mã tựa sách', ten as N'Tên tựa sách', soluong as N'Số lượng', namXB as N'Năm xuất bản', nhaXBma as N'Nhà xuất bản', theloaima as N'Thể loại'  from tuasach where ten like '%" + txtTimKiem.Text.Trim() + "%'";
            dt = DBConnect.GetData(sql);
            dgvTuaSach.DataSource = dt;
        }


        private void TuaSach_Load(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            HienThi();
            HienThi_cboNhaXuatBan();
            HienThi_cboTheLoai();
        }

        private void dgvTuaSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KhoaDieuKhien();
            try
            {
                int Row_Index = e.RowIndex;
                txtMa.Text = dgvTuaSach.Rows[Row_Index].Cells[0].Value.ToString();
                txtTen.Text = dgvTuaSach.Rows[Row_Index].Cells[1].Value.ToString();
                txtSoLuong.Text = dgvTuaSach.Rows[Row_Index].Cells[2].Value.ToString();
                txtNamXuatBan.Text = dgvTuaSach.Rows[Row_Index].Cells[3].Value.ToString();
                //cboTacGia.Text= dgvTuaSach.Rows[Row_Index].Cells[4].Value.ToString();
                cboNhaXuatBan.Text = dgvTuaSach.Rows[Row_Index].Cells[4].Value.ToString();
                cboTheLoai.Text = dgvTuaSach.Rows[Row_Index].Cells[5].Value.ToString();
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
               
                ts.Ma = a;              
                ts.xoa_tuasach(ts.Ma);
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
                    int a,  c, d, k;                 
                    int.TryParse(txtSoLuong.Text, out a);
                   // int.TryParse(cboTacGia.Text, out b);
                    int.TryParse(cboNhaXuatBan.Text, out c);
                    int.TryParse(cboTheLoai.Text, out d);
                    int.TryParse(txtNamXuatBan.Text, out k);
                    ts.Ten = txtTen.Text;
                    ts.Soluong = a;
                    ts.NamXB = k;
                    ts.NhaXBma = c;
                    ts.Theloaima = d;
                  
                    ts.them_tuasach();
                  
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
                    int a,b, c, d, k;
                    int.TryParse(txtSoLuong.Text, out a);
                   int.TryParse(txtMa.Text, out b);
                    int.TryParse(cboNhaXuatBan.Text, out c);
                    int.TryParse(cboTheLoai.Text, out d);
                    int.TryParse(txtNamXuatBan.Text, out k);
                    ts.Ma = b;
                    ts.Ten = txtTen.Text;
                    ts.Soluong = a;
                    ts.NamXB = k;
                    ts.NhaXBma = c;
                    ts.Theloaima = d;                
                    ts.sua_tuasach();                  
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

        private void r_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
