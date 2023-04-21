using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanySystem
{
    class Hr : Employee
    {
        public Hr()
        {

        }
        public Hr(String Fname, String Lname, DateTime Dob, String Empno, String Department, String Designation) : base(Fname, Lname, Dob, Empno, Department, Designation) { }

        public override string ToString()
        {
            return base.ToString();
        }


        public override bool CalculateSal()
        {
            throw new NotImplementedException();
        }

        public override bool Work()
        {
            throw new NotImplementedException();
        }

    }
}
