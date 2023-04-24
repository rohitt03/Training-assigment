using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCase2.Model;

namespace UseCase2
{
    class StudentNodueseSystem
    {
        static void Main(string[] args)
        {
            try
            {
               // Console.WriteLine();
                Console.WriteLine("\n----------------Welcome to Student No-dues System--------------");
                Console.WriteLine("*Refer LabsDepartmentUtil and ElectricDepartmentUtil of util folder to Enter Non-exist Student ID*");
                Console.WriteLine("\nEnter Student ID");
                string id = Console.ReadLine();
                AccountDepartment actdept = new AccountDepartment();
                int nodues = actdept.Getdues(id);
                Console.WriteLine("Student {0} No-dues is {1}", id, nodues);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
           
        }
    }
}
