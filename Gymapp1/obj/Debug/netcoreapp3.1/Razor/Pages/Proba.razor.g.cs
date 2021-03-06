#pragma checksum "/Users/erikolah/Projects/Gymapp1/Gymapp1/Pages/Proba.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8467e3cc491d6a69b5afc5c6c02e40fc94af3b85"
// <auto-generated/>
#pragma warning disable 1591
namespace Gymapp1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/erikolah/Projects/Gymapp1/Gymapp1/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/erikolah/Projects/Gymapp1/Gymapp1/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/erikolah/Projects/Gymapp1/Gymapp1/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/erikolah/Projects/Gymapp1/Gymapp1/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/erikolah/Projects/Gymapp1/Gymapp1/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/erikolah/Projects/Gymapp1/Gymapp1/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/erikolah/Projects/Gymapp1/Gymapp1/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/erikolah/Projects/Gymapp1/Gymapp1/_Imports.razor"
using Gymapp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/erikolah/Projects/Gymapp1/Gymapp1/_Imports.razor"
using Gymapp1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/erikolah/Projects/Gymapp1/Gymapp1/_Imports.razor"
using Gymapp1.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/proba")]
    public partial class Proba : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Component1</h3>\n\n");
            __builder.OpenElement(1, "select");
            __builder.AddAttribute(2, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 4 "/Users/erikolah/Projects/Gymapp1/Gymapp1/Pages/Proba.razor"
                   LoadCalendar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(3, "\n");
#nullable restore
#line 5 "/Users/erikolah/Projects/Gymapp1/Gymapp1/Pages/Proba.razor"
     foreach(string monthName in monthNames)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "        ");
            __builder.OpenElement(5, "option");
            __builder.AddContent(6, 
#nullable restore
#line 7 "/Users/erikolah/Projects/Gymapp1/Gymapp1/Pages/Proba.razor"
                 monthName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n");
#nullable restore
#line 8 "/Users/erikolah/Projects/Gymapp1/Gymapp1/Pages/Proba.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n");
            __builder.OpenElement(9, "table");
            __builder.AddAttribute(10, "class", "table table-bordered table-striped");
            __builder.AddMarkupContent(11, "\n    ");
            __builder.OpenElement(12, "thead");
            __builder.AddMarkupContent(13, "\n        ");
            __builder.OpenElement(14, "tr");
            __builder.AddMarkupContent(15, "\n");
#nullable restore
#line 13 "/Users/erikolah/Projects/Gymapp1/Gymapp1/Pages/Proba.razor"
             for(var dayIndex = 0; dayIndex < days.Count(); dayIndex++)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "                ");
            __builder.OpenElement(17, "th");
            __builder.AddMarkupContent(18, "\n                    ");
            __builder.AddContent(19, 
#nullable restore
#line 16 "/Users/erikolah/Projects/Gymapp1/Gymapp1/Pages/Proba.razor"
                     days[dayIndex]

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(20, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n");
#nullable restore
#line 18 "/Users/erikolah/Projects/Gymapp1/Gymapp1/Pages/Proba.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "/Users/erikolah/Projects/Gymapp1/Gymapp1/Pages/Proba.razor"
       
    List<string> monthNames = new List<string>();
    List<string> days = new List<string>();
    DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
    DateTime endDate = (new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)).AddMonths(1).AddDays(1);

    protected override void OnInitialized()
    {
        monthNames = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthGenitiveNames.ToList();
        GenerateCalendarHead();
    }
    private void LoadCalendar(ChangeEventArgs e)
    {

    }
    private void GenerateCalendarHead()
    {
        var day1 = new List<string>();
        for(var dt = startDate;dt<= endDate;dt = dt.AddDays(1))
        {
            day1.Add(dt.ToString("dddd"));
        }
        days = day1.Distinct().ToList();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
