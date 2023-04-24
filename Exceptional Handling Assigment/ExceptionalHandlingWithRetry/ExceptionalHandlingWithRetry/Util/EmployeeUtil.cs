using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExceptionalHandlingWithRetry.Model;
namespace ExceptionalHandlingWithRetry.Util
{
    class EmployeeUtil
    {
        public static List<Employee> GetAllEmployee()
        {
            List<Employee> li = new List<Employee>();
            li.Add(new Employee("AT100","Akash","Gugale"));
            li.Add(new Employee("AT101", "Bhushan", "Lnadage"));
            li.Add(new Employee("AT102", "Tushar", "Bhadane"));
            li.Add(new Employee("AT103", "Rajendra", "Tungar"));
            li.Add(new Employee("AT104", "Akash", "Pawar"));
            return li;
        }
    }
}
