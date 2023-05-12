using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleManagment.CustomException
{
    class ColorNotfoundException:Exception
    {
        public ColorNotfoundException(string msg) : base(msg)
        {

        }
    }
}
