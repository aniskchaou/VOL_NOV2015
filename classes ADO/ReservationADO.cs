using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using gestion_reservation_vol.classes;

namespace gestion_reservation_vol.classes_ADO
{
    class ReservationADO
    {


        public void reserver(Reservation r, OleDbConnection connection)
        {
            string connetionString = null;

            OleDbCommand command;


            try
            {
                //MessageBox.Show("INSERT INTO passager (`num_pass`,`nomprenom_pass`,`adr_pass`,`tel_pass`,`email_pass`)VALUES('" + p._num_pass + "','" + p._nom_prenom_pass + "','" + p._adr_pass + "','" + p._tel_pass + "','" + p._email_pass + "')");

                string sql = "INSERT INTO reservation (`num_res`,`date_res`,`num_pass`,`num_v`)VALUES('" + r._date_res + "','" +r._date_res + "','" + r._num_pass + "','" + r._num_v + "')";
                command = new OleDbCommand(sql, connection);
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);
            }



        }

        public void load_vol( ComboBox combo_vol )
        {
                       Connexion c=new Connexion();
                       OleDbConnection cn= c.connect();
                       cn.Open();
                        OleDbCommand com_sql =new OleDbCommand();
            OleDbDataReader dr_sql ;
            com_sql.Connection = cn;
            com_sql.CommandType = CommandType.Text;
            com_sql.CommandText = "select * from vol";
            dr_sql = com_sql.ExecuteReader();
            if (dr_sql.HasRows)
            {

                String contenu = "";
                int i;
                while (dr_sql.Read())
                {


                    combo_vol.Items.Add(dr_sql.GetValue(1));
                   
                }

            }
         }

        public void load_passager(ComboBox combo_passager)
        {
             Connexion c=new Connexion();
                       OleDbConnection cn= c.connect();
                       cn.Open();
                        OleDbCommand com_sql =new OleDbCommand();
            OleDbDataReader dr_sql ;
            com_sql.Connection = cn;
            com_sql.CommandType = CommandType.Text;
            com_sql.CommandText = "select * from passager";
            dr_sql = com_sql.ExecuteReader();
            if (dr_sql.HasRows)
            {

                String contenu = "";
                int i;
                while (dr_sql.Read())
                {


                    combo_passager.Items.Add(dr_sql.GetValue(1));
                   
                }

            }
         }


        }

        }




       

    