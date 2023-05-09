using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagment.CustomException
{
    public class EmployeeNotFoundException:Exception
    {
        public EmployeeNotFoundException(string msg) : base(msg)
        {

        }
    }
}
