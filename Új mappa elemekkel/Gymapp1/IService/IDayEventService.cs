using System;
using System.Collections.Generic;
using Gymapp1.Data;

namespace Gymapp1.IService
{
    public interface IDayEventService
    {
        DayEvent SaveOrUpdate(DayEvent oDayEvent);
        DayEvent GetEvent(DateTime eventDate);
        List<DayEvent> GetEvents(DateTime fromDate, DateTime toDate);
        string Delete(int id);
    }
}
