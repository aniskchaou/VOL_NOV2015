using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using gestion_reservation_vol.classes_ADO;
using gestion_reservation_vol.classes;

namespace gestion_reservation_vol.forms
{
    public partial class frm_reser_vol : Form
    {
        public string num_pass;
        public string num_vol;

        public frm_reser_vol()
        {
            InitializeComponent();
        }

        private void frm_reser_vol_Load(object sender, EventArgs e)
        {
            ReservationADO res = new ReservationADO();
            res.load_passager(combo_pass);
            res.load_vol(combo_vol);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
             ComboBox cm = (ComboBox)sender;


             num_pass = cm.SelectedItem.ToString();
            Connexion c = new Connexion();
            OleDbConnection cn = c.connect();
            cn.Open();
            OleDbCommand com_sql = new OleDbCommand();
            OleDbDataReader dr_sql;
            com_sql.Connection = cn;
            com_sql.CommandType = CommandType.Text;
            com_sql.CommandText = "select * from passager where num_pass='"+cm.SelectedItem.ToString()+"'";
            dr_sql = com_sql.ExecuteReader();
            dr_sql.Read();
            txt_adr.Text = dr_sql.GetValue(2).ToString();
            txt_email.Text = dr_sql.GetValue(3).ToString();
            txt_nom.Text = dr_sql.GetValue(4).ToString();
            txt_tel.Text = dr_sql.GetValue(5).ToString();
        }

        private void combo_vol_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cm = (ComboBox)sender;


            num_vol = cm.SelectedItem.ToString();
            Connexion c = new Connexion();
            OleDbConnection cn = c.connect();
            cn.Open();
            OleDbCommand com_sql = new OleDbCommand();
            OleDbDataReader dr_sql;
            com_sql.Connection = cn;
            com_sql.CommandType = CommandType.Text;
            com_sql.CommandText = "select * from vol where num_vol='"+cm.SelectedItem.ToString()+"'";
            dr_sql = com_sql.ExecuteReader();
            dr_sql.Read();
            txt_des.Text = dr_sql.GetValue(2).ToString();
            date_dep.Value = Convert.ToDateTime(dr_sql.GetValue(3).ToString());
            date_dep.Value = Convert.ToDateTime(dr_sql.GetValue(4).ToString());
            heure_dep.Text = dr_sql.GetValue(5).ToString();
            heure_arr.Text = dr_sql.GetValue(6).ToString();



        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connexion c = new Connexion();
            OleDbConnection cn = c.connect();
            cn.Open();
            Reservation r = new Reservation(12,date_res.Value,Int32.Parse(num_pass),Int32.Parse(num_vol));
            ReservationADO res = new ReservationADO();
            res.reserver(r, cn);

        }
        }
    }

