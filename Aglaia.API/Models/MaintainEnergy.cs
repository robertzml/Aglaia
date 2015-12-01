using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Aglaia.Model;

namespace Aglaia.API.Models
{
    public class MaintainEnergy
    {
        public DateTime start { get; set; }

        public DateTime end { get; set; }

        public List<MaintainDailyEnergy> dailyEnergy { get; set; }
    }

    public class MaintainDailyEnergy
    {
        public int year { get; set; }

        public int month { get; set; }

        public int day { get; set; }

        public List<Energy> energyData { get; set; }

        public string formatData1 { get; set; }

        public string formatData2 { get; set; }
    }
}