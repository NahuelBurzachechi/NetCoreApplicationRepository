using NetCoreApplicationRepository.Data.Interafaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreApplicationRepository.Data.Services
{
    public class EmployeeServices : IEmployee
    {
        public Task<bool> AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetEmployeeById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Employee>> GetEmployees()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
