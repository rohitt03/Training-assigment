using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionalHandlingWithRetry.CustomException
{
    class EmployeeNotFound:Exception
    {
        public EmployeeNotFound(String msg) : base(msg) { }
    }
}
