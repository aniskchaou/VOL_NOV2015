using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using gestion_reservation_vol.classes_ADO;
using gestion_reservation_vol.classes;
namespace gestion_reservation_vol.forms
{
    public partial class frm_nv_passager : Form
    {
        public frm_nv_passager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string connetionString = null;
            OleDbConnection connection;
            OleDbCommand command;
            string sql = "INSERT INTO passager (`num_pass`,`nomprenom_pass`,`adr_pass`,`tel_pass`,`email_pass`)VALUES('234','34','234','324','234')";

            connetionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\kamel\Documents\as.mdb";
           // sql = "Your SQL Statemnt Here";

            connection = new OleDbConnection(connetionString);
            try
            {
                connection.Open();
              //  command = new OleDbCommand(sql, connection);
                  command = new OleDbCommand("SELECT * FROM passager", connection);
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM passager", connection);
                DataTable t = new DataTable();
                da.Fill(t);
                  //OleDbDataReader dr; dr = command.ExecuteReader();
                  dataGridView1.DataSource = t;
                  

              // command.ExecuteNonQuery();
                //command.Dispose();
                connection.Close();
                MessageBox.Show(" ExecuteNonQuery in SqlCommand executed !!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! "+ex.Message);
            }

            */

            Connexion c = new Connexion();
            OleDbConnection con =c.connect();
            con.Open();

            Passager p = new Passager(Int32.Parse(txt_pass_cin.Text), txt_pass_nom.Text, txt_pass_email.Text, Int32.Parse(txt_pass_tel.Text), txt_pass_adr.Text);

            PassagerADO pass = new PassagerADO();
            pass.ajouter_passager(p, con);






            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
