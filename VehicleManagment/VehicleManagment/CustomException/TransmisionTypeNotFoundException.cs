using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleManagment.CustomException
{
    class TransmisionTypeNotFoundException:Exception
    {
        public TransmisionTypeNotFoundException(string msg) : base(msg)
        {

        }
    }
}
