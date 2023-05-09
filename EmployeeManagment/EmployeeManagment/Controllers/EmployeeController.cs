using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagment.Dto;
using EmployeeManagment.Service;
using EmployeeManagment.Model;
using EmployeeManagment.CustomException;
namespace EmployeeManagment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        private readonly EmployeeContext _employeeContext;
        public EmployeeController(EmployeeContext employeeContext,IEmployeeService employeeService)
        {
            this._employeeContext = employeeContext;
            this._employeeService =employeeService;
        }

        [HttpGet]
        public  object GetAllEmployee()
        {
            try
            {
                return _employeeService.GetAllEmployee();
            }
            catch (Exception ex)
            {
                return new ResponseEntity { StatusCode = "501", Responce = "Internal Serval issue try after some time" };
            }
            
        }
        [HttpGet]
        [Route("{id}")]
        public Object GetById(int id)
        {
            try
            {
                return _employeeService.GetById(id);
            }
            catch (EmployeeNotFoundException enf)
            {
                return new ResponseEntity { StatusCode = "400", Responce = enf.Message };
            }
            catch(Exception ex)
            {
                return new ResponseEntity { StatusCode = "501", Responce = "Internal Serval issue try after some time" };
            }
           
           
        }

        [HttpGet]
        [Route("highestsalpercity")]
        public object GetEmployeeHighestSalPerCity()
        {
            try
            {
                return _employeeService.GetEmployeeHighestSalPerCity();
            }
            catch (Exception ex)
            {
                return new ResponseEntity { StatusCode = "501", Responce = "Internal Serval issue try after some time" };
            }
        
        }

        [HttpPost]
        public object AddEmployee(EmployeeDto employeeDto)
        {
            try
            {
                return _employeeService.AddEmployee(employeeDto);
            }
            catch (Exception ex)
            {
                return new ResponseEntity { StatusCode = "501", Responce = "Internal Serval issue try after some time" };
            }


        }
        


        }
}
