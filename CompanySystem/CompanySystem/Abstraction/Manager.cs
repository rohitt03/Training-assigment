using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanySystem
{
    abstract class Manager:Employee
    {
        List<Employee> emp;
        public Manager()
        {

        }
        public Manager(String Fname, String Lname, DateTime Dob, String Empno, String Department, String Designation) :base( Fname, Lname, Dob, Empno, Department, Designation)
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }

        public abstract Boolean AddEmp(Employee e);
        public abstract Employee RemoveEmp(String empno);
       
    }
}
