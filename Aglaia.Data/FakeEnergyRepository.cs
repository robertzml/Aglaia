using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aglaia.Model;

namespace Aglaia.Data
{
    public class FakeEnergyRepository : IEnergyRepository
    {
        public IEnumerable<Energy> GetHourRandom(DateTime date)
        {
            List<Energy> data = new List<Energy>();
            Random random = new Random(DateTime.Now.Millisecond);

            for (DateTime step = date.AddDays(-1); step < date.AddDays(2); step = step.AddHours(1))
            {
                Energy e = new Energy
                {
                    time = step,
                    value = Math.Round(random.NextDouble() * 10, 2)
                };

                data.Add(e);
            }

            return data;
        }

        public IEnumerable<Energy> GetDayRandom(DateTime start, DateTime end)
        {
            List<Energy> data = new List<Energy>();
            Random random = new Random(start.Month + DateTime.Now.Millisecond);

            for (DateTime step = start; step < end.AddMonths(1); step = step.AddDays(1))
            {
                Energy e = new Energy
                {
                    time = step,
                    value = Math.Round(random.NextDouble() * 10, 2)
                };

                data.Add(e);
            }

            return data;
        }

        public IEnumerable<Energy> GetHourRandom(DateTime start, DateTime end)
        {
            List<Energy> data = new List<Energy>();
            Random random = new Random(start.Day + DateTime.Now.Millisecond);

            for (DateTime step = start; step < end.AddDays(1); step = step.AddHours(1))
            {
                Energy e = new Energy
                {
                    time = step,
                    value = Math.Round(random.NextDouble() * 10, 2)
                };

                data.Add(e);
            }

            return data;
        }

        public IEnumerable<AmmeterEnergy> GetBuildingRandom(int buildingId, DateTime start, DateTime end)
        {
            List<AmmeterEnergy> data = new List<AmmeterEnergy>();
            Random random = new Random(buildingId + start.Day);

            for (int i = 0; i < 10; i++)
            {
                AmmeterEnergy ae = new AmmeterEnergy();

                ae.ammeterId = random.Next(10000);
                ae.roomName = "A" + (i + 1).ToString();
                ae.startDisplay = random.Next(10000);
                ae.endDisplay = ae.startDisplay + random.Next(1000);
                ae.multiply = 1;
                ae.subitem = "照明";
                ae.nature = "生活";
                ae.startTime = start;
                ae.endTime = end;

                data.Add(ae);
            }

            return data;
        }
    }
}
