using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gestion_reservation_vol.classes
{
    class Vol
    {
      public  int _num_v;
       // int _code_comp_v;
      public String _destination_v;
      public DateTime _date_dep;
      public DateTime _date_arr;
      public String _heure_dep;
      public String _heure_arr;



        public Vol(int num_v, String destination_v, DateTime date_dep, DateTime date_arr, String heure_dep, String heure_arr)
        {
            _num_v=num_v;
            //_code_comp_v=code_comp_v;
            _destination_v=destination_v;
            _date_dep=date_dep;
            _date_arr=date_arr;
            _heure_dep=heure_dep;
            _heure_arr = heure_arr;
        }

    }
}
