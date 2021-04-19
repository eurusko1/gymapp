using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Gymapp1.Data;
using Gymapp1.IService;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace Gymapp1.Service
{
    public class DayEventService : IDayEventService
    {
        DayEvent _oDayEvent = new DayEvent();
        List<DayEvent> _oDayEvents = new List<DayEvent>();

        public IConfiguration Configuration { get; }
        public DayEventService(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public string Delete(int id)
        {
            string message = "";
            try
            {
                _oDayEvent = new DayEvent()
                {
                    DayEventId = id
                };

                using (MySqlConnection con = new MySqlConnection(Configuration.GetConnectionString("default")))
                {
                    if (con.State == ConnectionState.Closed) con.Open();

                    var oDayEvents = con.Query<DayEvent>("DayEvent",
                        this.SetParameters(_oDayEvent, (int)OperationType.Delete),
                        commandType: CommandType.StoredProcedure);

                    message = "Deleted";
                }
                

            }
            catch (Exception ex)
            {
                message = ex.Message;
            }

            return message;
        }
        public DayEvent GetEvent(DateTime eventDate)
        {
            _oDayEvent = new DayEvent();
            using (MySqlConnection con = new MySqlConnection(Configuration.GetConnectionString("default")))
            {
                if (con.State == ConnectionState.Closed) con.Open();

                string sql = string.Format(@"SELECT * FROM DayEvent WHERE EventDate = '{0}'", eventDate.ToString("yyyy-MM-dd"));

                var oDayEvents = con.Query<DayEvent>(sql).ToList();

                if (oDayEvents != null && oDayEvents.Count() > 0)
                {
                    _oDayEvent = oDayEvents[oDayEvents.Count() - 1];

                    _oDayEvent.FromDate = eventDate;
                    _oDayEvent.ToDate = eventDate;
                }
                else
                {
                    _oDayEvent.EventDate = eventDate;
                    _oDayEvent.FromDate = eventDate;
                    _oDayEvent.ToDate = eventDate;
                }
            }
            return _oDayEvent;
        }
        public List<DayEvent> GetEvents(DateTime fromDate, DateTime toDate)
        {
            _oDayEvents = new List<DayEvent>();
            using (MySqlConnection con = new MySqlConnection(Configuration.GetConnectionString("default")))
            {
                if (con.State == ConnectionState.Closed) con.Open();

                string sql = string.Format(@"SELECT * FROM DayEvent WHERE EventDate BETWEEN '{0}' AND '{1}'", fromDate.ToString("yyyy-MM-dd"), toDate.ToString("yyyy-MM-dd"));

                var oDayEvents = con.Query<DayEvent>(sql).ToList();

                if (oDayEvents != null && oDayEvents.Count() > 0)
                {
                    _oDayEvents = oDayEvents;
                }
            }
            return _oDayEvents;
        }
        public DayEvent SaveOrUpdate(DayEvent oDayEvent)
        {
            _oDayEvent = new DayEvent();
            try
            {
                string sql = string.Format(@"insert into DayEvent(Note, EventDate) values ('{0}', '{1}')", (oDayEvent.Note, oDayEvent.EventDate));

                using (MySqlConnection con = new MySqlConnection(Configuration.GetConnectionString("default")))
                {
                    if (con.State == ConnectionState.Closed) con.Open();

                    var oDayEvents = con.Query<DayEvent>(sql);


                    if (oDayEvents != null && oDayEvents.Count() > 0)
                    {
                        _oDayEvent = oDayEvents.FirstOrDefault();
                    }
                }
            }
            catch (Exception ex)
            {

                _oDayEvent.Message = ex.Message;
            }
            return _oDayEvent;
        }

        private DynamicParameters SetParameters(DayEvent oDayEvent, int operationType)
        {
            DynamicParameters parameters = new DynamicParameters();

            parameters.Add("@DayEventId", oDayEvent.DayEventId);
            parameters.Add("@Note", oDayEvent.Note);
            parameters.Add("@EventDate", oDayEvent.EventDate);
            parameters.Add("@OperationType", operationType);

            return parameters;
        }
    }
}
