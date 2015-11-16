using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aglaia.Model;

namespace Aglaia.Data
{
    public interface IAmmeterRepository
    {
        IEnumerable<Ammeter> GetByBuilding(int buildingId);
    }
}
