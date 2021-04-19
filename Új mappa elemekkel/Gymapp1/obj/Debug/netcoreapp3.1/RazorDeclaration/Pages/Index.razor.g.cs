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
#line 2 "/Users/erikolah/Projects/Gymapp1/Gymapp1/Pages/Index.razor"
using Gymapp1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/erikolah/Projects/Gymapp1/Gymapp1/Pages/Index.razor"
using Gymapp1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/erikolah/Projects/Gymapp1/Gymapp1/Pages/Index.razor"
using DataConnection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/erikolah/Projects/Gymapp1/Gymapp1/Pages/Index.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/erikolah/Projects/Gymapp1/Gymapp1/Pages/Index.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/foglalas")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 146 "/Users/erikolah/Projects/Gymapp1/Gymapp1/Pages/Index.razor"
       DayEvent dayEvent = new DayEvent()
    {
        FromDate = DateTime.Now,
        ToDate = DateTime.Now,
        Note = ""
    };

    bool displayModal = false;
    List<string> monthNames = new List<string>();
    List<string> days = new List<string>();
    List<WeekClass> weeks = new List<WeekClass>();
    DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
    DateTime date = DateTime.UtcNow;
    DateTime endDate = (new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)).AddMonths(1).AddDays(-1);
    int selectedWeekIndex = -1;
    int selectedDayIndex = -1;

    protected override void OnInitialized()
    {
        monthNames = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthGenitiveNames.ToList();
        GenerateCalenderHead();
        GenerateCalenderBody();
        LoadCalender(date.ToString("MMMM"));
    }
    public void LoadCalender(string Month)
    {

        var month = Month;
        int monthIndex = DateTime.ParseExact(month, "MMMM", System.Globalization.CultureInfo.CreateSpecificCulture("en-GB")).Month;
        startDate = new DateTime(DateTime.Now.Year, monthIndex, 1);
        endDate = (new DateTime(DateTime.Now.Year, monthIndex, 1)).AddMonths(1).AddDays(-1);
        GenerateCalenderHead();
        GenerateCalenderBody();
        StateHasChanged();

    }
    public void TESZT(ChangeEventArgs e)
    {
        var month = e.Value.ToString().ToLower();
        int tmp = DateTime.ParseExact(month, "MMMM", System.Globalization.CultureInfo.CreateSpecificCulture("en-GB")).Month;
        date = new DateTime(DateTime.Now.Year, tmp, 1);
        LoadCalender(month);
    }

    private void GenerateCalenderHead()
    {
        var day1 = new List<string>();
        for (var dt = startDate; dt <= endDate; dt = dt.AddDays(1))
        {
            day1.Add(dt.ToString("dddd"));
        }
        days = day1.Distinct().ToList();
    }
    private void GenerateCalenderBody()
    {
        weeks = new List<WeekClass>();
        var dayEvents = dayEventService.GetEvents(startDate, endDate);

        int flag = 0;
        WeekClass week = new WeekClass();
        List<DayEvent> dates = new List<DayEvent>();
        var totalDays = (int)(endDate - startDate).TotalDays;
        int countdays = 0;

        for (var dt = startDate; dt <= endDate; dt = dt.AddDays(1))
        {
            flag++;

            var currentObject = dayEvents.Find(x => x.EventDate.ToString("dd-MMM-yyyy") == dt.ToString("dd-MMM-yyyy"));

            dates.Add(new DayEvent()
            {
                DayEventId = currentObject == null ? 0 : currentObject.DayEventId,
                DateValue = dt.ToString("dd-MMM-yyyy"),
                DayName = dt.ToString("dddd"),
                Note = currentObject == null ? "" : currentObject.Note
            });

            if (flag == 7)
            {
                week = new WeekClass();
                week.Dates = dates;
                weeks.Add(week);

                dates = new List<DayEvent>();
                flag = 0;
            }
            if (countdays == totalDays)
            {
                week = new WeekClass();
                week.Dates = dates;
                weeks.Add(week);
                break;
            }
            countdays++;
        }
    }
    private void CloseModal()
    {
        ResetModal();
    }
    private void OpenModal(int wIndex, int dIndex)
    {
        selectedWeekIndex = wIndex;
        selectedDayIndex = dIndex;

        var dayEventObj = dayEventService.GetEvent(Convert.ToDateTime(weeks[wIndex].Dates[dIndex].DateValue));
        dayEvent = dayEventObj;

        displayModal = true;
    }

    private void ResetModal()
    {
        displayModal = false;
        selectedDayIndex = -1;
        selectedWeekIndex = -1;
    }
    List<TimeModel> Ido = new List<TimeModel>();
    string SelectedTime;
    protected override async Task OnInitializedAsync()
    {
        string sql = "select * from idopontok";

        Ido = await _data.LoadData<TimeModel, dynamic>(sql, new { }, _config.GetConnectionString("default"));
        
  

    }
    private async Task SaveNote()
    {
        //string sql = "INSERT INTO DayEvent(Note, EventDate) values (@Note, @EventDate);";
        // string sql = "insert into Foglalt(Note, EventDate, IdoPont) select tbl1.`Note`,tbl1.`EventDate`,tbl2.`IdoPont` from DayEvent tbl1,idopontok tbl2;";
        // string sql = "INSERT INTO DayEvent(Note, EventDate, idopont) values (@Note, @EventDate, @idopont) SELECT * FROM idopontok ORDER BY EventDate ASC";

        //  _data.SaveData(sql, new { dayEvent.Note, dayEvent.EventDate }, _onfig.GetConnectionString("default"));
        teszt.teszt(dayEvent.Note, dayEvent.EventDate,SelectedTime);
        ResetModal();
    }


    [Parameter]
    public int tmp { get; set; }
    public int tmp1 { get; set; }
    public DateTime month { get; set; }
    public void newWeek()
    {
        DateTime tmpdate = date;
        if (tmp <= 3)
        {
            tmp = tmp + 1;
        }
        else
        {
            date = date.AddMonths(1);
            LoadCalender(date.ToString("MMMM").ToLower());
            tmp = 0;



        }

    }
    void deleteWeek()
    {
        if (tmp > 0)
        {
            tmp -= 1;
        }
        else
        {
            date = date.AddMonths(-1);
            LoadCalender(date.ToString("MMMM").ToLower());
            //tmp = 0;
        }
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TESZT teszt { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataAccess _data { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Gymapp1.IService.IDayEventService dayEventService { get; set; }
    }
}
#pragma warning restore 1591
