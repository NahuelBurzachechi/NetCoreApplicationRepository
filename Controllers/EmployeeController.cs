using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreApplicationRepository.Data.Interafaces;
using NetCoreApplicationRepository.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreApplicationRepository.Controllers
{
    
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployee _employee;

        public EmployeeController(IEmployee employee) 
        {
            _employee = employee;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetEmployees()
        {
            return Ok(_employee.GetEmployees());
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            var employee = _employee.GetEmployeeById(id);
            if (employee != null)
                return Ok(employee);
            else
                return NotFound($"Employee {id} was not found.");
        }

        [HttpPost]
        [Route("api/[controller]/addEmployee")]
        public IActionResult AddEmployee(Employee employee)
        {
            _employee.AddEmployee(employee);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + employee.Id, employee);
        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            var employee = _employee.GetEmployeeById(id);
            if (employee != null)
            {
                _employee.DeleteEmployee(employee);
                return Ok($"Employee {id} was eliminated.");
            }
            else
                return NotFound($"Employee {id} was not found.");
        }

        [HttpPatch]
        [Route("api/[controller]/{id}")]
        public IActionResult UpdateEmployee(int id, Employee employee)
        {
            var updateEmployee = _employee.GetEmployeeById(id);
            if(updateEmployee != null) 
            {
                updateEmployee.Name = employee.Name;
                _employee.UpdateEmployee(updateEmployee);
                return Ok($"Employee {id} was updated.");
            }
            else
            {
                return NotFound($"Employee {employee.Id} was not found.");
            }
        }
    }
}
