using EmployeeManagment.Dto;
using EmployeeManagment.Model;

namespace EmployeeManagment.Service
{
    public interface IEmployeeService
    {
        object GetAllEmployee();
        object AddEmployee(EmployeeDto empDto);
        Employee GetById(int id);
        object GetEmployeeHighestSalPerCity();
    }
}