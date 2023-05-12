using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleManagment.CustomException
{
    class RecordsNotFoundException:Exception
    {
        public RecordsNotFoundException(string msg):base(msg)
        {

        }
    }
}
