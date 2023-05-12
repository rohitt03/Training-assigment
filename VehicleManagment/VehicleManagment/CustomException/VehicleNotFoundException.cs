using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleManagment.CustomException
{
    class VehicleNotFoundException:Exception
    {
        public VehicleNotFoundException(string msg) : base(msg)
        {

        }
    }
}
