using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aglaia.Model;

namespace Aglaia.Data
{
    public class FakeBuildingRepository : IBuildingRepository
    {
        public IEnumerable<Building> Get()
        {
            List<Building> data = new List<Building>();

            Building building1 = new Building
            {
                id = "1",
                text = "江南大学",
                parent = "#",
                li_attr = "type: 0"
            };
            data.Add(building1);

            Building building2 = new Building
            {
                id = "2",
                text = "行政楼",
                parent = "1",
                li_attr = "type: 1"
            };
            data.Add(building2);

            Building building3 = new Building
            {
                id = "3",
                text = "教学楼",
                parent = "1",
                li_attr = "type: 1"
            };
            data.Add(building3);

            Building building4 = new Building
            {
                id = "4",
                text = "A102",
                parent = "2",
                li_attr = "type: 2"
            };
            data.Add(building4);

            Building building5 = new Building
            {
                id = "5",
                text = "A103",
                parent = "2",
                li_attr = "type: 2"
            };
            data.Add(building5);

            Building building6 = new Building
            {
                id = "6",
                text = "A104",
                parent = "6",
                li_attr = "type: 2"
            };
            data.Add(building4);
            return data;
        }
    }
}
