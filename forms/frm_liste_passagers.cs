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
    public partial class frm_liste_passagers : Form
    {
        DataGridViewRow selected_row;
        public frm_liste_passagers()
        {
            InitializeComponent();
        }

        private void frm_liste_passagers_Load(object sender, EventArgs e)
        {
            Connexion c = new Connexion();
            OleDbConnection con = c.connect();
            con.Open();
            PassagerADO vol = new PassagerADO();
            DataTable dt = vol.liste_passager(con);
            dataGridView1.DataSource = dt;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cell_click(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            txt_nom.Text = row.Cells["nomprenom_pass"].Value.ToString();
            txt_cin.Text = row.Cells["num_pass"].Value.ToString();
            
           txt_telephone.Text = row.Cells["tel_pass"].Value.ToString();
            txt_adr.Text = row.Cells["adr_pass"].Value.ToString();
            txt_email.Text = row.Cells["email_pass"].Value.ToString();
            selected_row = row;
            //cellselected = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Connexion c = new Connexion();
            OleDbConnection  cn= c.connect();
            cn.Open();
            PassagerADO ps = new PassagerADO();
            ps.supprimer_passager(selected_row, cn);
            dataGridView1.Rows.Remove(selected_row);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_rech_pass.Visible = true;
            ok_bt.Visible = true;
        }

        private void ok_bt_Click(object sender, EventArgs e)
        {
            Connexion c = new Connexion();
            OleDbConnection cn = c.connect();
            cn.Open();
            PassagerADO pass = new PassagerADO();
            DataTable dt = pass.recherche(txt_rech_pass.Text, cn);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_nom.Enabled = true;
            txt_cin.Enabled = true;

            txt_telephone.Enabled = true;
            txt_adr.Enabled = true;
            txt_email.Enabled = true;
            conf_bt.Visible = true;



        }

        private void conf_bt_Click(object sender, EventArgs e)
        {
            Connexion c = new Connexion();
            OleDbConnection cn = c.connect();
            cn.Open();
            PassagerADO pass = new PassagerADO();
            pass.modifier(cn, txt_cin.Text, txt_nom.Text, txt_adr.Text, txt_telephone.Text, txt_email.Text);
        }
    }
}
