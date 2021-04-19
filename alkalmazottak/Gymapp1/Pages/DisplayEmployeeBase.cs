using System;
using System.Threading.Tasks;
using Gymapp1.Data;
using Gymapp1.Service;
using Microsoft.AspNetCore.Components;

namespace Gymapp1.Pages
{
    public class DisplayEmployeeBase : ComponentBase
    {
        [Parameter]
        public Employee Employee { get; set; }

        [Parameter]
        public bool ShowFooter { get; set; }

    }
}
