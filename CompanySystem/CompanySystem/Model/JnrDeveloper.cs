using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanySystem.Model
{
    class JnrDeveloper : Developer
    {
        public JnrDeveloper() { }
        public JnrDeveloper(String Fname, String Lname, DateTime Dob, String Empno, String Department, String Designation) : base(Fname, Lname, Dob, Empno, Department, Designation) { }

        public override string ToString()
        {
            return base.ToString();
        }
        public override bool AddLanguage(string lang)
        {
            throw new NotImplementedException();
        }

        public override bool AddManager(Manager mgr)
        {
            throw new NotImplementedException();
        }

        public override bool CalculateSal()
        {
            throw new NotImplementedException();
        }

        public override Manager ChangeManager(string mgrid)
        {
            throw new NotImplementedException();
        }

        public override bool Work()
        {
            throw new NotImplementedException();
        }
    }
}
