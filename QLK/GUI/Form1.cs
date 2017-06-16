using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void showControlND(System.Windows.Forms.Control obj)
        {
            RenderBody.Controls.Clear();
            obj.Dock = DockStyle.Fill;
            RenderBody.Controls.Add(obj);
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            UserControl us = new UCSach();
            showControlND(us);
            btnSach.BackColor = Color.Turquoise;
            btnNghiepVu.BackColor = Color.PaleTurquoise;
            btnMTS.BackColor = Color.PaleTurquoise;
        }

        private void btnNghiepVu_Click(object sender, EventArgs e)
        {
            UserControl us = new UCNghiepvu();
            showControlND(us);
            btnSach.BackColor = Color.PaleTurquoise;
            btnNghiepVu.BackColor = Color.Turquoise;
            btnMTS.BackColor = Color.PaleTurquoise;
        }
    }
}
