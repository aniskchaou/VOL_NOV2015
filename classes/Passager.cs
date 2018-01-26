using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gestion_reservation_vol.classes
{
    class Passager
    {
     public   int _num_pass;
     public String _nom_prenom_pass;
     public String _email_pass;
     public int _tel_pass;
     public String _adr_pass;

        public Passager(int num_pass, String nom_prenom_pass, String email_pass, int tel_pass, String adr_pass)
        {
            _num_pass=num_pass;
            _nom_prenom_pass=nom_prenom_pass;
            _email_pass=email_pass;
            _tel_pass=tel_pass;
            _adr_pass=adr_pass;
           

        }

    }
}
