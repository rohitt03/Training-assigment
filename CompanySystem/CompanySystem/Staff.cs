using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanySystem
{
    abstract class Staff:Employee
    {
        Manager mgr;
        public abstract Boolean Addmgr(Manager mgr);
        public abstract Manager RemoveManager(String mgrid);
    }
}
