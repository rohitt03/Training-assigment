using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanySystem
{
    abstract class Employee :Person
    {
        public String Empno { get; set; }
        public float Salary { get; set; }

        public int Attendence { get; set; }
        public String  Department { get; set; }

        public String Designation { get; set; }
        public String Degree { get; set; }

        public abstract Boolean Work();
        public abstract Boolean CalculateSal();

        public Employee()
        {

        }
        public Employee(String Fname, String Lname, DateTime Dob, String Empno, String Department, String Designation) : base(Fname,Lname, Dob)
        {
            this.Empno = Empno;
            this.Department = Department;
            this.Designation = Designation;
        }

        public override string ToString()
        {
            return base.ToString()+" Empno:-"+Empno+" DepartMent:-"+Department+" Designation:-"+Designation;
        }

    }
}
