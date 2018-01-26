using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using gestion_reservation_vol.forms;

namespace gestion_reservation_vol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nouveauToolStripMenuItem_Click_1(object sender, EventArgs e)
        {   
            frm_nv_passager n = new frm_nv_passager();
            n.MdiParent = this;
            n.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
