using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleManagment.CustomException
{
    class FuelTypeException:Exception
    {
        public FuelTypeException(string msg) : base(msg)
        {

        }
    }
}
