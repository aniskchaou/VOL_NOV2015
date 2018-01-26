using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;
using gestion_reservation_vol.classes;
namespace gestion_reservation_vol.classes_ADO
{
    class VolADO
    {

        public void supprimer_vol(DataGridViewRow row, OleDbConnection connection)
        {
            string connetionString = null;

            OleDbCommand command;
            // MessageBox.Show(row.Cells["num_pass"].Value.ToString());



            try
            {

                string sql = "DELETE FROM vol WHERE num_vol='" + row.Cells["num_vol"].Value.ToString() + "'";
                command = new OleDbCommand(sql, connection);
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);
            }




        }


        public void ajouter_vol(Vol v, OleDbConnection connection)
        {
            string connetionString = null;

            OleDbCommand command;


            try
            {
                MessageBox.Show("INSERT INTO vol (`num_vol`,`destination_v`,`date_dep`,`date_arr`,`heure_dep`,`heure_arr`)VALUES('" + v._num_v + "','" + v._destination_v + "','" + v._date_dep.ToString() + "','" + v._date_arr.ToString() + "','" + v._heure_dep + ",'" + v._heure_arr + "')");

                string sql = "INSERT INTO vol (`num_vol`,`destination_v`,`date_dep`,`date_arr`,`heure_dep`,`heure_arr`)VALUES('" + v._num_v + "','" + v._destination_v + "','" + v._date_dep.ToString() + "','" + v._date_arr.ToString() + "','" + v._heure_dep + "','"+v._heure_arr+"')";
                command = new OleDbCommand(sql, connection);
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);
            }



        }




        public DataTable liste_vol(OleDbConnection connection)
        {

            DataTable t = new DataTable();

            try
            {

                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM vol", connection);

                da.Fill(t);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);
            }

            return t;
        }



        public DataTable recherche(String elem,OleDbConnection connection)
        {

            DataTable t = new DataTable();

            try
            {

                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM vol WHERE num_vol='"+elem+"'", connection);

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
