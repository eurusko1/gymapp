// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 2 "/Users/erikolah/Projects/Gymapp1/Gymapp1/Pages/BookedBookings.razor"
using Gymapp1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/erikolah/Projects/Gymapp1/Gymapp1/Pages/BookedBookings.razor"
using DataConnection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/erikolah/Projects/Gymapp1/Gymapp1/Pages/BookedBookings.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/foglalt")]
    public partial class BookedBookings : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "/Users/erikolah/Projects/Gymapp1/Gymapp1/Pages/BookedBookings.razor"
       

    DayEvent dayEvent = new DayEvent();
    private List<DayEvent> booking;
    public bool Success { get; set; }
    protected override async Task OnInitializedAsync()
    {
        if (Success == true)
        {
            string sql = "select * from Foglalt";
            booking = await _data.LoadData<DayEvent, dynamic>(sql, new { }, _config.GetConnectionString("default"));
            StateHasChanged();
        }
        else
        {
            string sql = "select * from Foglalt";
            booking = await _data.LoadData<DayEvent, dynamic>(sql, new { }, _config.GetConnectionString("default"));
            StateHasChanged();
        }

    }

    public async Task Delete_Click(int id)
    {

        dayEvent.Message = teszt.Delete(id);
        booking = booking.Where(c => c.id != id).ToList();
        Success = true;

    }

    async Task CheckIn(DateTime date, int id)
    {
        Success = true;
        teszt.Checkin(date, id);
        string sql = "select * from Foglalt";
        booking = await _data.LoadData<DayEvent, dynamic>(sql, new { }, _config.GetConnectionString("default"));



    }
    async Task CheckOut(DateTime date, int id)
    {

        Success = true;
        teszt.Checkout(date, id);
        string sql = "select * from Foglalt";
        booking = await _data.LoadData<DayEvent, dynamic>(sql, new { }, _config.GetConnectionString("default"));

    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TESZT teszt { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataAccess _data { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Gymapp1.IService.IDayEventService dayEventService { get; set; }
    }
}
#pragma warning restore 1591
