using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Aglaia.Model;

namespace Aglaia.API.Models
{
    public class CalendarEnergy
    {
        public DateTime start { get; set; }

        public DateTime end { get; set; }

        public List<CalendarMonthEnergy> monthEnergy { get; set; }
    }

    public class CalendarMonthEnergy
    {
        public int year { get; set; }

        public int month { get; set; }

        public List<Energy> energyData { get; set; }

        public double total { get; set; }

        public string[] formatData { get; set; }
    }
}