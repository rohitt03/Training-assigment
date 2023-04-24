using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCase1.CustomException
{
    class StudentNotFound:Exception
    {
        public StudentNotFound(string msg):base(msg){ }
    }
}
