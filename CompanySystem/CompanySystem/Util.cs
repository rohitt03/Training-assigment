using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanySystem.Model;
namespace CompanySystem
{
    class Util
    {
        public static List<Employee> GetEmployee()
        {
            // Fname, String Lname, DateTime Dob, String Empno, String Department, String Designation
            List<Employee> empList = new List<Employee>();
            empList.Add(new Hr("suvijay","meshram",new DateTime(1995,5,3),"AT404","Admin-HR","HR"));
            empList.Add(new ProductManager("sanjay", "patil", new DateTime(1990, 5, 3), "GT508", "IT", "Manager"));
            empList.Add(new SnrDeveloper("gaurav", "salunke", new DateTime(1993, 3, 5), "KT300", "IT", "Sinior Developer"));
            empList.Add(new JnrDeveloper("Yash", "patil", new DateTime(1998, 12, 3), "AT404", "IT", "Junior Developer"));
            empList.Add(new JnrDeveloper("prathmesh", "shinde", new DateTime(1998, 12, 12), "At521", "IT", "Junior developer"));
            return empList;

        }
    }
}
