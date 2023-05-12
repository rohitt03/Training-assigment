using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleManagment.CustomException
{
    class DatabaseException:Exception
    {
        public DatabaseException(string msg) : base(msg)
        {

        }
    }
}
