using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gymapp1.Data;
using Gymapp1.Service;
using Microsoft.AspNetCore.Components;

namespace Gymapp1.Pages
{
        public class EmployeeListBase : ComponentBase
        {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        public IEnumerable<Employee> Employees { get; set; }

        public bool ShowFooter { get; set; } = true;

        protected override async Task OnInitializedAsync()
        {
            Employees = (await EmployeeService.GetEmployees()).ToList();
        }

    }
    
}
