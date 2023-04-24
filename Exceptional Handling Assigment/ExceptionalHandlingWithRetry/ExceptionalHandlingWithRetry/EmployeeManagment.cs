using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExceptionalHandlingWithRetry.Model;
using ExceptionalHandlingWithRetry.Util;
using ExceptionalHandlingWithRetry.CustomException;
namespace ExceptionalHandlingWithRetry
{
    class EmployeeManagment
    {
        public static void DisplayAllEmp()
        {
            Console.WriteLine("Sample EMployee List");
            EmployeeUtil.GetAllEmployee().ForEach(e => Console.WriteLine(e));
        }
        public Employee GetEmp(String empid)
        {
            Employee emp = new Employee();
            emp.EmpID = empid;
            List<Employee> li = EmployeeUtil.GetAllEmployee();
            if (li.Contains(emp))
            {
                return li[li.IndexOf(emp)];


            }
            throw new EmployeeNotFound("Employee not found");
        }
        static void Main(string[] args)
        {
            try
            {
                DisplayAllEmp();
                EmployeeManagment emanag = new EmployeeManagment();
                try
                {
                   
                    Console.WriteLine("\n------------Welcome Employee Mangment System------------------");
                    Console.WriteLine("Enter Employee Id to Get Employee Detail");
                    String empid = Console.ReadLine();
                    Employee employee= emanag.GetEmp(empid);
                    Console.WriteLine(employee.ToString());

                }
                catch (Exception ex)
                {
                    Console.WriteLine("This is your last chance Please Enter valid Id");
                    String empid = Console.ReadLine();
                    Employee employee = emanag.GetEmp(empid);
                    Console.WriteLine(employee.ToString());
                }

            }catch(Exception ex)
            {
                Console.WriteLine("Sorry you cant try againg");


            }

            Console.WriteLine("------------Thank you---------------");
            Console.ReadKey();
           
            

        }
        
    }
}
