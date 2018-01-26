using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using gestion_reservation_vol.classes;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace gestion_reservation_vol.classes_ADO
{
    class PassagerADO
    {


        public void modifier( OleDbConnection connection,String numpass,String nompass,String adrpass,String telpass,String emailpass)
        {
            string connetionString = null;

            OleDbCommand command;
            // MessageBox.Show(row.Cells["num_pass"].Value.ToString());



            try
            {

                string sql = "UPDATE passager SET num_pass='" + numpass + "',nomprenom_pass='" + nompass + "',adr_pass='" + adrpass + "',tel_pass='" + telpass + "',email_pass='" + emailpass + "'";
                command = new OleDbCommand(sql, connection);
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);
            }

        }


        public void supprimer_passager(DataGridViewRow row,OleDbConnection connection)
        {
            string connetionString = null;

            OleDbCommand command;
           // MessageBox.Show(row.Cells["num_pass"].Value.ToString());



            try
            {
               
                string sql = "DELETE FROM passager WHERE num_pass='" + row.Cells["num_pass"].Value.ToString()+"'";
                command = new OleDbCommand(sql, connection);
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);
            }



        }

        public void ajouter_passager(Passager p,OleDbConnection connection)
        {
            string connetionString = null;
            
            OleDbCommand command;
           
            
            try
            {
                //MessageBox.Show("INSERT INTO passager (`num_pass`,`nomprenom_pass`,`adr_pass`,`tel_pass`,`email_pass`)VALUES('" + p._num_pass + "','" + p._nom_prenom_pass + "','" + p._adr_pass + "','" + p._tel_pass + "','" + p._email_pass + "')");

                string sql = "INSERT INTO passager (`num_pass`,`nomprenom_pass`,`adr_pass`,`tel_pass`,`email_pass`)VALUES('"+p._num_pass+"','"+p._nom_prenom_pass+"','"+p._adr_pass+"','"+p._tel_pass+"','"+p._email_pass+"')";
                command = new OleDbCommand(sql, connection);
                command.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);
            }



        }




        public DataTable liste_passager(OleDbConnection connection)
        {

            DataTable t = new DataTable();
            
            try
            {
               
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM passager", connection);
                
                da.Fill(t);
                
   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);
            }

            return t;
        }



        public DataTable recherche(String elem, OleDbConnection connection)
        {

            DataTable t = new DataTable();

            try
            {

                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM passager WHERE num_pass='" + elem + "'", connection);

                da.Fill(t);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);
            }

            return t;


        }
    }
}
