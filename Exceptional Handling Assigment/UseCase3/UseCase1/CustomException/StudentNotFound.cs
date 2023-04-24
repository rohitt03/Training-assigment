using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCase3.CustomException
{
    class StudentNotFound:Exception
    {
        public StudentNotFound(string msg):base(msg){ }
        public StudentNotFound(string msg,Exception ex) : base(msg, ex) { }
    }
}
