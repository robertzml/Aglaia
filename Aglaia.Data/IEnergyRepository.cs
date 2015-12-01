using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aglaia.Model;

namespace Aglaia.Data
{
    public interface IEnergyRepository
    {
        IEnumerable<Energy> GetHourRandom(DateTime date);

        IEnumerable<Energy> GetDayRandom(DateTime start, DateTime end);

        IEnumerable<Energy> GetHourRandom(DateTime start, DateTime end);
    }
}
