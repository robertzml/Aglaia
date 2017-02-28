using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aglaia.Model
{
    public class AmmeterEnergy
    {
        public int ammeterId { get; set; }

        public string roomName { get; set; }

        public double startDisplay { get; set; }

        public double endDisplay { get; set; }

        public double multiply { get; set; }

        /// <summary>
        /// 用电分项
        /// </summary>
        public string subitem { get; set; }

        /// <summary>
        /// 用电性质
        /// </summary>
        public string nature { get; set; }

        public DateTime startTime { get; set; }

        public DateTime endTime { get; set; }
    }
}
