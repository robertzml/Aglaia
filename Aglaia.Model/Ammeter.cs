using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aglaia.Model
{
    public class Ammeter
    {
        public long id { get; set; }

        public string name { get; set; }

        public string roomName { get; set; }

        public string departmentName { get; set; }

        public int buildingId { get; set; }

        public bool online { get; set; }
    }
}
