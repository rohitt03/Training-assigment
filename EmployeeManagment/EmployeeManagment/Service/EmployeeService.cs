using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagment.Model;
using EmployeeManagment.Dto;
using EmployeeManagment.CustomException;

namespace EmployeeManagment.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly EmployeeContext _employeeContext;
        
        public EmployeeService(EmployeeContext employeeContext)
        {
            this._employeeContext = employeeContext;
            
        }
        public Object AddEmployee(EmployeeDto empDto)
        {
            Employee employee = new Employee { FirstName = empDto.FirstName, LastName = empDto.LastName, Email = empDto.Email, City = empDto.City, Salary = empDto.Salary };          
          _employeeContext.Employees.Add(employee);
          _employeeContext.SaveChanges();
            var eemployee = _employeeContext.Employees.OrderByDescending(temp => temp.EmpId).FirstOrDefault();
            return eemployee;
        }
        public Employee GetById(int id)
        {
            Employee employee=_employeeContext.Employees.Find(id);
            if (employee == null)
                throw new EmployeeNotFoundException("Employee with ID "+id+" not plese enter valid ID");
            return employee ;
        }
        public object GetAllEmployee()
        {
            return _employeeContext.Employees;
        }

        public object GetEmployeeHighestSalPerCity()
        {
            List<GetEmployeeHighestSalPerCityDto> listgetEmployeeHighestSalPerCities = new List<GetEmployeeHighestSalPerCityDto>();
            var employees = _employeeContext.Employees.GroupBy(temp => temp.City);
            foreach (var employee in employees)
            {
                GetEmployeeHighestSalPerCityDto getEmployeeHighestSalPerCityDto = new GetEmployeeHighestSalPerCityDto();
                getEmployeeHighestSalPerCityDto.City = employee.Key;
                Employee tempemp = employee.OrderByDescending(temp => temp.Salary).FirstOrDefault();
                foreach (var emp in employee)
                {
                    if (tempemp.Salary == emp.Salary)
                        getEmployeeHighestSalPerCityDto.Employees.Add(emp);
                }
                listgetEmployeeHighestSalPerCities.Add(getEmployeeHighestSalPerCityDto);
            }
            return listgetEmployeeHighestSalPerCities;
        }

    }
}
