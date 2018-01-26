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
using gestion_reservation_vol.classes;

namespace gestion_reservation_vol.forms
{
    public partial class frm_nv_vol : Form
    {
        public frm_nv_vol()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connexion c = new Connexion();
            OleDbConnection con = c.connect();
            con.Open();

            Vol v = new Vol(Int32.Parse(txt_num_vol.Text),txt_dest_vol.Text,date_dep.Value,date_arr.Value,txt_heure_dep.Text,txt_heure_arr.Text);

            VolADO vol = new VolADO();
            vol.ajouter_vol(v,con);



        }
    }
}
