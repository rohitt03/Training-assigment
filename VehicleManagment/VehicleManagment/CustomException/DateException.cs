using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleManagment.CustomException
{
    class DateException:Exception
    {
        public DateException(string msg) : base(msg)
        {

        }
    }
}
