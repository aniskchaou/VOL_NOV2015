using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using gestion_reservation_vol.classes_ADO;
using System.Data.OleDb;

namespace gestion_reservation_vol.forms
{
    public partial class frm_liste_vol : Form
    {
        bool cellselected = false;
        DataGridViewRow selected_row;
        public frm_liste_vol()
        {
            InitializeComponent();
        }

        private void frm_liste_vol_Load(object sender, EventArgs e)
        {
            Connexion c = new Connexion();
            OleDbConnection con = c.connect();
            con.Open();
            VolADO vol = new VolADO();
            DataTable dt = vol.liste_vol(con);
            dataGridView1.DataSource=dt;

        }

        private void click_datacell(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            MessageBox.Show(row.Cells["num_v"].Value.ToString());
        }

        private void click_cell(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            txt_numvol.Text=row.Cells["num_vol"].Value.ToString();
            txt_destination.Text = row.Cells["destination_v"].Value.ToString();
            dateç_depart.Value =Convert.ToDateTime( row.Cells["date_dep"].Value.ToString());
            date_arrivee.Value = Convert.ToDateTime(row.Cells["date_arr"].Value.ToString());
            heire_arrive.Text = row.Cells["heure_arr"].Value.ToString();
            heure_depart.Text = row.Cells["heure_dep"].Value.ToString();
            cellselected = true;
            selected_row = row;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Connexion c = new Connexion();
            OleDbConnection cn = c.connect();
            cn.Open();
            VolADO vl = new VolADO();
            vl.supprimer_vol(selected_row, cn);
            dataGridView1.Rows.Remove(selected_row);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_rech_vol.Visible = true;
            ok_bt.Visible = true;
            
        }

        private void ok_bt_Click(object sender, EventArgs e)
        {
            Connexion c = new Connexion();
            OleDbConnection cn = c.connect();
            cn.Open();
            VolADO vl = new VolADO();
            DataTable dt = vl.recherche(txt_rech_vol.Text,cn);
            dataGridView1.DataSource = dt;
        }
    }
}
