using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Http.Cors;
using Aglaia.API.Models;
using Aglaia.Data;
using Aglaia.Model;

namespace Aglaia.API.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class EnergyController : ApiController
    {
        #region Field
        private IEnergyRepository energyRepository;
        #endregion //Field

        #region Constructor
        public EnergyController()
        {
            this.energyRepository = new FakeEnergyRepository();
        }
        #endregion //Constructor

        #region Function
        private CalendarEnergy TransferToCalendar(DateTime start, DateTime end, List<Energy> energy)
        {
            CalendarEnergy data = new CalendarEnergy();
            data.start = start;
            data.end = end;
            data.monthEnergy = new List<CalendarMonthEnergy>();

            for (DateTime step = start; step <= end; step = step.AddMonths(1))
            {
                CalendarMonthEnergy mEnergy = new CalendarMonthEnergy();
                mEnergy.year = step.Year;
                mEnergy.month = step.Month;
                mEnergy.energyData = energy.Where(r => r.time >= step && r.time < step.AddMonths(1)).ToList();
                mEnergy.total = Math.Round(mEnergy.energyData.Sum(r => r.value), 2);
                mEnergy.formatData = new string[7];

                bool putBreak = true;
                for (int i = 0; i < 7; i++)
                {
                    var weekData = mEnergy.energyData.Where(r => (int)r.time.DayOfWeek == i);
                    StringBuilder sb = new StringBuilder();

                    if (weekData.First().time.Day == 1)
                        putBreak = false;
                    if (putBreak)
                        sb.Append("<br /><br />");

                    foreach(var item in weekData)
                    {
                        sb.Append(string.Format("<b class='calendar-date'>{0}</b><br /><b class='calendar-value'>{1}</b><br />", item.time.Day, item.value));
                    }

                    mEnergy.formatData[i] = sb.ToString();
                }
                data.monthEnergy.Add(mEnergy);
            }

            return data;
        }

        private MaintainEnergy TransferToMaintain(DateTime start, DateTime end, List<Energy> energy)
        {
            MaintainEnergy data = new MaintainEnergy();
            data.start = start;
            data.end = end;
            data.dailyEnergy = new List<MaintainDailyEnergy>();

            for(DateTime step = start; step <= end; step = step.AddDays(1))
            {
                MaintainDailyEnergy dEnergy = new MaintainDailyEnergy();
                dEnergy.year = step.Year;
                dEnergy.month = step.Month;
                dEnergy.day = step.Day;
                dEnergy.energyData = energy.Where(r => r.time >= step && r.time < step.AddDays(1)).ToList();

                StringBuilder sb1 = new StringBuilder();
                for (int i = 0; i < 12; i++)
                {                    
                    sb1.Append(string.Format("<td>{0}</td>", dEnergy.energyData[i].value));
                }
                dEnergy.formatData1 = sb1.ToString();

                StringBuilder sb2 = new StringBuilder();
                for(int i = 12; i < 24; i++)
                {
                    sb2.Append(string.Format("<td>{0}</td>", dEnergy.energyData[i].value));
                }
                dEnergy.formatData2 = sb2.ToString();

                data.dailyEnergy.Add(dEnergy);
            }

            return data;
        }
        #endregion //Function

        #region Action
        public List<Energy> Get(DateTime date)
        {
            return this.energyRepository.GetHourRandom(date).ToList();
        }

        public List<Energy> GetDays(DateTime start, DateTime end)
        {
            return this.energyRepository.GetDayRandom(start, end).ToList();
        }

        public CalendarEnergy GetCalendarEnergy(DateTime start, DateTime end)
        {
            var energy = this.energyRepository.GetDayRandom(start, end).ToList();
            var calendarEnergy = TransferToCalendar(start, end, energy);

            return calendarEnergy;
        }

        public MaintainEnergy GetMaintainEnergy(DateTime start, DateTime end)
        {
            var energy = this.energyRepository.GetHourRandom(start, end).ToList();
            var maintainEnergy = TransferToMaintain(start, end, energy);

            return maintainEnergy;
        }
        #endregion //Action
    }
}
