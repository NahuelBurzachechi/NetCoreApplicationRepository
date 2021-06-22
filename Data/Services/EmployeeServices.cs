using NetCoreApplicationRepository.Data.Interafaces;
using NetCoreApplicationRepository.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreApplicationRepository.Data.Services
{
    public class EmployeeServices : IEmployee
    {
        private EmployeeContext _employeeContext;
        public EmployeeServices(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }
        public void AddEmployee(Employee employee)
        {
            _employeeContext.Employees.Add(employee);
            _employeeContext.SaveChanges();
        }

        public void DeleteEmployee(Employee employee)
        {
            _employeeContext.Employees.Remove(employee);
            _employeeContext.SaveChanges();

        }

        public Employee GetEmployeeById(int id)
        {
            return _employeeContext.Employees.Find(id);
        }

        public List<Employee> GetEmployees()
        {
            return _employeeContext.Employees.ToList();
        }

        public void UpdateEmployee(Employee employee)
        {
            _employeeContext.Employees.Update(employee);
            _employeeContext.SaveChanges();
        }
    }
}
