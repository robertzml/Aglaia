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
    }
}
