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
    public partial class UCSach : UserControl
    {
        public UCSach()
        {
            InitializeComponent();
        }

        public void showControlND(System.Windows.Forms.Control obj)
        {
            RB1.Controls.Clear();
            obj.Dock = DockStyle.Fill;
            RB1.Controls.Add(obj);
        }

        private void tựaSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControl us = new UCTuaSach();
            showControlND(us);
            tựaSáchToolStripMenuItem.BackColor = Color.Teal;
            thểLoạiToolStripMenuItem.BackColor = Color.LightSeaGreen;
            nhàXuấtBảnToolStripMenuItem.BackColor = Color.LightSeaGreen;
        }

        private void thểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControl us = new UCTheLoai();
            showControlND(us);
            tựaSáchToolStripMenuItem.BackColor = Color.LightSeaGreen;
            thểLoạiToolStripMenuItem.BackColor = Color.Teal;
            nhàXuấtBảnToolStripMenuItem.BackColor = Color.LightSeaGreen;
        }

        private void nhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControl us = new UCNhaXuatBan();
            showControlND(us);
            tựaSáchToolStripMenuItem.BackColor = Color.LightSeaGreen;
            thểLoạiToolStripMenuItem.BackColor = Color.LightSeaGreen;
            nhàXuấtBảnToolStripMenuItem.BackColor = Color.Teal;
        }
    }
}
