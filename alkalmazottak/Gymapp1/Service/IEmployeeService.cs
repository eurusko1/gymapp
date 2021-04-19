using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Gymapp1.Data;

namespace Gymapp1.Service
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployee(int id);
        Task<Employee> UpdateEmployee(Employee updatedEmployee);
    }



}
