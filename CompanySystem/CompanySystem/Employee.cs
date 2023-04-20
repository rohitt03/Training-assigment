using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanySystem
{
    abstract class Employee :Human
    {
        public String Empno { get; set; }
        public float Salary { get; set; }

        public int Attendence { get; set; }
        public String  Department { get; set; }

        public String Designation { get; set; }
        public String Degree { get; set; }

        public abstract Boolean Work();
        public abstract Boolean CalculateSal();

    }
}
