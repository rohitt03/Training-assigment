using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagment.Model;

namespace EmployeeManagment.Dto
{
    public class GetEmployeeHighestSalPerCityDto
    {
        public GetEmployeeHighestSalPerCityDto (){
            Employees = new List<Employee>();
            }
        public string City { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
