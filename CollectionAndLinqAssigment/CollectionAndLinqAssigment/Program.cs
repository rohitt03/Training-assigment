using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionAndLinqAssigment.Model;
using CollectionAndLinqAssigment.Util;
namespace CollectionAndLinqAssigment
{
    class Program
    {
        public static void Display(IEnumerable<Employee> employees)
        {
            foreach (var emp in employees)
            {
                Console.WriteLine(emp);
            }

        }
        static void Main(string[] args)
        {
            int choice = 1;
            Employee[] employee;
            IEnumerable<Employee> employees;
            List<Employee> li = EmployeeUtil.GetallEmployee();
            Console.WriteLine("--------------Welcome To Employee Managment-----------------");
            while (choice != 7)
            {
                Console.WriteLine("\n1:Employee with ID\n2:Employee with ID are even\n3:Employee with highest salary\n4:Employee with highest salary holder in pune\n5:Employee with highest salary holder in each city\n6:Show all employee\n7:Exit");
                if(!int.TryParse(Console.ReadLine(), out choice))
                    choice=100;
                switch (choice)
                {
                    case 1:
                        int id;
                        Console.WriteLine("Enter ID");
                        if (int.TryParse(Console.ReadLine(), out id))
                        {
                            employees = from emp in li
                                        where emp.Id == id
                                        select emp;
                            Display(employees);

                        }
                        else
                        {
                            Console.WriteLine("Enter valid id");
                        }
                        break;
                    case 2:
                        employees = from emp in li
                                    where (emp.Id % 2) == 0
                                    select emp;
                        Display(employees);
                        break;
                    case 3:
                        employee = (from emp in li
                                    orderby emp.Salary descending
                                    select emp).Take(1).ToArray();
                        employees = (from emp in li
                                     where emp.Salary == employee[0].Salary
                                     select emp);
                        Display(employees);
                        break;
                    case 4:
                        employee = (from emp in li
                                    where emp.City.ToLower() == "pune"
                                    orderby emp.Salary descending
                                    select emp).Take(1).ToArray();

                        employees = (from emp in li
                                     where emp.Salary == employee[0].Salary && emp.City.ToLower() == "pune"
                                     select emp);
                        Display(employees);
                        break;
                    case 5:
                        var empgroup = from emp in li
                                       group emp by emp.City;

                        foreach (var emp in empgroup)
                        {
                            Console.WriteLine("City " + emp.Key);
                            employee = emp.OrderByDescending(temp => temp.Salary).Take(1).ToArray();
                            employees = from e in emp
                                        where e.Salary == employee[0].Salary
                                        select e;
                            Display(employees);
                        }
                        break;
                    case 6:
                        Display(li);
                        break;
                    default:
                        Console.WriteLine("Enter vaid choise");
                        break;
                }           
            }
            Console.ReadKey();
        }
    }
}
