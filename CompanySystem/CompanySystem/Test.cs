using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanySystem
{
    class Test
    {
        static public void Main(String[] args)
        {
            List<Employee> li = Util.GetEmployee();
            li.ForEach((emp) => Console.WriteLine(emp));
            Console.ReadLine();
        }
    }
}
