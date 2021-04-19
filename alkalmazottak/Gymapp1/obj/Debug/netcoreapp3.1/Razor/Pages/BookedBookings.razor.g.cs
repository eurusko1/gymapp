#pragma checksum "/Users/erikolah/Projects/Gymapp1/Gymapp1/Pages/BookedBookings.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "030ef095a705e42441a81f8d7471ed25db647454"
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
            __builder.AddMarkupContent(0, "<h3>Foglalt idopontok</h3>\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(1);
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\n");
#nullable restore
#line 13 "/Users/erikolah/Projects/Gymapp1/Gymapp1/Pages/BookedBookings.razor"
     if (booking is null)
    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(4, "        ");
                __builder2.AddMarkupContent(5, "<p><em>Loadings...</em></p>\n");
#nullable restore
#line 16 "/Users/erikolah/Projects/Gymapp1/Gymapp1/Pages/BookedBookings.razor"
    }
    else
    {


#line default
#line hidden
#nullable disable
                __builder2.AddContent(6, "        ");
                __builder2.OpenElement(7, "table");
                __builder2.AddAttribute(8, "class", "table table-bordered table-striped");
                __builder2.AddMarkupContent(9, "\n            ");
                __builder2.AddMarkupContent(10, @"<thead>
                <tr>
                    <th>Id</th>
                    <th>Note</th>
                    <th>Vezeteknev</th>
                    <th>Keresztnev</th>
                    <th>Datum</th>
                    <th>Idopont</th>
                    <th>Telefonszam</th>
                    <th>Email</th>
                    <th>Erkezes</th>
                    <th>Tavozas</th>
                    <th>Vezerlok</th>

                </tr>
            </thead>
            ");
                __builder2.OpenElement(11, "tbody");
                __builder2.AddMarkupContent(12, "\n");
#nullable restore
#line 38 "/Users/erikolah/Projects/Gymapp1/Gymapp1/Pages/BookedBookings.razor"
                 foreach (var book in booking)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(13, "                    ");
                __builder2.OpenElement(14, "tr");
                __builder2.AddMarkupContent(15, "\n                        ");
                __builder2.OpenElement(16, "td");
                __builder2.AddContent(17, 
#nullable restore
#line 41 "/Users/erikolah/Projects/Gymapp1/Gymapp1/Pages/BookedBookings.razor"
                             book.id

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\n                        ");
                __builder2.OpenElement(19, "td");
                __builder2.AddContent(20, 
#nullable restore
#line 42 "/Users/erikolah/Projects/Gymapp1/Gymapp1/Pages/BookedBookings.razor"
                             book.Note

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\n                        ");
                __builder2.OpenElement(22, "td");
                __builder2.AddContent(23, 
#nullable restore
#line 43 "/Users/erikolah/Projects/Gymapp1/Gymapp1/Pages/BookedBookings.razor"
                             book.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\n                        ");
                __builder2.OpenElement(25, "td");
                __builder2.AddContent(26, 
#nullable restore
#line 44 "/Users/erikolah/Projects/Gymapp1/Gymapp1/Pages/BookedBookings.razor"
                             book.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\n                        ");
                __builder2.OpenElement(28, "td");
                __builder2.AddContent(29, 
#nullable restore
#line 45 "/Users/erikolah/Projects/Gymapp1/Gymapp1/Pages/BookedBookings.razor"
                             book.EventDate.ToString("yyyy-MMM-ddd")

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\n                        ");
                __builder2.OpenElement(31, "td");
                __builder2.AddContent(32, 
#nullable restore
#line 46 "/Users/erikolah/Projects/Gymapp1/Gymapp1/Pages/BookedBookings.razor"
                             book.idopont

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\n                        ");
                __builder2.OpenElement(34, "td");
                __builder2.AddContent(35, 
#nullable restore
#line 47 "/Users/erikolah/Projects/Gymapp1/Gymapp1/Pages/BookedBookings.razor"
                             book.Tel

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\n                        ");
                __builder2.OpenElement(37, "td");
                __builder2.AddContent(38, 
#nullable restore
#line 48 "/Users/erikolah/Projects/Gymapp1/Gymapp1/Pages/BookedBookings.razor"
                             book.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\n                        ");
                __builder2.OpenElement(40, "td");
                __builder2.AddContent(41, 
#nullable restore
#line 49 "/Users/erikolah/Projects/Gymapp1/Gymapp1/Pages/BookedBookings.razor"
                             book.Erkezes.ToString("HH:mm:ss")

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\n                        ");
                __builder2.OpenElement(43, "td");
                __builder2.AddContent(44, 
#nullable restore
#line 50 "/Users/erikolah/Projects/Gymapp1/Gymapp1/Pages/BookedBookings.razor"
                             book.tavozas.ToString("HH:mm:ss")

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\n                        ");
                __builder2.OpenElement(46, "td");
                __builder2.AddMarkupContent(47, "\n                            ");
                __builder2.OpenElement(48, "button");
                __builder2.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "/Users/erikolah/Projects/Gymapp1/Gymapp1/Pages/BookedBookings.razor"
                                              ()=> Delete_Click(book.id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(50, "Torles");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\n                            ");
                __builder2.OpenElement(52, "button");
                __builder2.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "/Users/erikolah/Projects/Gymapp1/Gymapp1/Pages/BookedBookings.razor"
                                              ()=> CheckIn(DateTime.Now, book.id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(54, "Erkezes");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\n                            ");
                __builder2.OpenElement(56, "button");
                __builder2.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "/Users/erikolah/Projects/Gymapp1/Gymapp1/Pages/BookedBookings.razor"
                                              ()=> CheckOut(DateTime.Now, book.id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(58, "Tavozas");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\n");
#nullable restore
#line 57 "/Users/erikolah/Projects/Gymapp1/Gymapp1/Pages/BookedBookings.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(62, "            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\n");
#nullable restore
#line 60 "/Users/erikolah/Projects/Gymapp1/Gymapp1/Pages/BookedBookings.razor"

    }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
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