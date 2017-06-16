using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class UCNghiepvu : UserControl
    {
        public UCNghiepvu()
        {
            InitializeComponent();
        }
        public void showControlND(System.Windows.Forms.Control obj)
        {
            RB1.Controls.Clear();
            obj.Dock = DockStyle.Fill;
            RB1.Controls.Add(obj);
        }
        private void đọcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControl us = new UC_DocGia();
            showControlND(us);
            đọcGiảToolStripMenuItem.BackColor = Color.Teal;
            thủThưToolStripMenuItem.BackColor = Color.LightSeaGreen;
        }

        private void thủThưToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
