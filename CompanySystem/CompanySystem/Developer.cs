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
        
        public abstract Boolean AddManager(Manager mgr);
        public abstract Manager ChangeManager(String mgrid);
        public abstract Boolean AddLanguage(String lang);


    }
}
