using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;

namespace gestion_reservation_vol.classes_ADO
{
    class Connexion
    {



        public Connexion()
        {
            
        


        }

        public OleDbConnection connect()
        {
            OleDbConnection connection=null;

            String connetionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\kamel\Documents\as.mdb";


            
            try
            {
                
               connection = new OleDbConnection(connetionString); 

            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur de  connection ! " + ex.Message);
                
            }

            return connection;

        }


    }
}
