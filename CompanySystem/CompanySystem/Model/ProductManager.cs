using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanySystem
{
    class ProductManager : Manager
    {
        public ProductManager()
        {

        }
        public ProductManager(String Fname, String Lname, DateTime Dob, String Empno, String Department, String Designation) : base(Fname, Lname, Dob, Empno, Department, Designation)
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }
        public override bool AddEmp(Employee e)
        {
            throw new NotImplementedException();
        }

        public override bool CalculateSal()
        {
            throw new NotImplementedException();
        }

        public override Employee RemoveEmp(string empno)
        {
            throw new NotImplementedException();
        }

        public override bool Work()
        {
            Console.WriteLine("Product Manager Work");
            return true;
        }
    }
}
