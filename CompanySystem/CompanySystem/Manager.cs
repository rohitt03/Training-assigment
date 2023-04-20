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
        public abstract Boolean AddEmp(Employee e);
        public abstract Employee RemoveEmp(String empno);
    }
}
