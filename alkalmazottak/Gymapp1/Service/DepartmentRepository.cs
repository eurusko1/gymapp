using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Gymapp1.Data;
using Microsoft.EntityFrameworkCore;

namespace Gymapp1.Service
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly ApplicationDbContext appDbContext;

        public DepartmentRepository(ApplicationDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<Department> GetDepartment(int departmentId)
        {
            return await appDbContext.Departments
                .FirstOrDefaultAsync(d => d.DepartmentId == departmentId);
        }

        public async Task<IEnumerable<Department>> GetDepartments()
        {
            return await appDbContext.Departments.ToListAsync();
        }
    }
}
