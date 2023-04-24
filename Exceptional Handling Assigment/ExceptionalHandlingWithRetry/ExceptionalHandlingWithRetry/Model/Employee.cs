using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionalHandlingWithRetry.Model
{
    class Employee
    {
        public String EmpID { get; set; }
        public String FName { get; set; }
        public String LName { get; set; }
        
        public Employee() { }
        public Employee(String empId,String fName,String lName)
        {
            this.EmpID = empId;
            this.FName = fName;
            this.LName = lName;
        }
        public override bool Equals(object obj)
        {
            return this.EmpID==((Employee)obj).EmpID;
        }
        public override string ToString()
        {
            return " Employee ID:-"+EmpID+" First Name:-"+FName+" Last Name:-"+LName;
        }
    }
}
