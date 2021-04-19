using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Gymapp1.Data;

namespace Gymapp1.Service
{
    public interface IDepartmentRepository
    {
        Task<IEnumerable<Department>> GetDepartments();
        Task<Department> GetDepartment(int departmentId);
    }
}
