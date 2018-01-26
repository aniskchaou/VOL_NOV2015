using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gestion_reservation_vol.classes
{
    class Reservation
    {
       public int _num_res;
        public DateTime _date_res;
       public int _num_pass;
      public   int _num_v;

        public Reservation(int num_res, DateTime date_res, int num_pass, int num_v)
        {
            _num_res = num_res;
            _date_res = date_res;
            _num_pass = num_pass;
            _num_v = num_v;
      
        }


    }
}
