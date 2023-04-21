using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanySystem
{
    abstract class Developer:Employee
    {
        public Manager mgr;

        List<String> PrgLanguage;
        public Developer() { }
        public Developer(String Fname, String Lname, DateTime Dob, String Empno, String Department, String Designation) : base(Fname, Lname, Dob, Empno, Department, Designation) { }
        
        public override string ToString()
        {
            return base.ToString()+"Manager "+mgr;
        }

        public abstract Boolean AddManager(Manager mgr);
        public abstract Manager ChangeManager(String mgrid);
        public abstract Boolean AddLanguage(String lang);


    }
}
