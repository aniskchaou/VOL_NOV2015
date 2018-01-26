using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gestion_reservation_vol.forms
{
    public partial class frm_main : Form
    {
        private int childFormNumber = 0;

        public frm_main()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            frm_nv_passager childForm = new frm_nv_passager();
            childForm.MdiParent = this;
            
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            frm_nv_vol childForm = new frm_nv_vol();
            childForm.MdiParent = this;

            childForm.Show();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_liste_vol childForm = new frm_liste_vol();
            childForm.MdiParent = this;

            childForm.Show();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_liste_passagers childForm = new frm_liste_passagers();
            childForm.MdiParent = this;

            childForm.Show();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_reser_vol childForm = new frm_reser_vol();
            childForm.MdiParent = this;

            childForm.Show();
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
