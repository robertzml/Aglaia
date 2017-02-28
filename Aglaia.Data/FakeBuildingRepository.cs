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
        #region Field
        private List<Building> buildings;
        #endregion //Field

        #region Constructor
        public FakeBuildingRepository()
        {
            Init();
        }
        #endregion //Constructor

        #region Function
        private void Init()
        {
            this.buildings = new List<Building>();

            Building building = new Building
            {
                id = 100000,
                name = "江南大学",
                hasChildren = true,
                type = 1,
                parentId = 0
            };
            buildings.Add(building);

            Building building2 = new Building
            {
                id = 100001,
                name = "1号公寓",
                hasChildren = true,
                type = 2,
                parentId = 100000
            };
            buildings.Add(building2);

            Building building3 = new Building
            {
                id = 100002,
                name = "2号公寓",
                hasChildren = false,
                parentId = 100000,
                type = 2
            };
            buildings.Add(building3);
        }
        #endregion //Function


        public IEnumerable<Building> Get()
        {
            List<Building> data = new List<Building>();

            return data;
        }

        public Building Get(int id)
        {
            var data = this.buildings.SingleOrDefault(r => r.id == id);
            return data;
        }

        public List<Building> GetTop()
        {
            var data = this.buildings.Where(r => r.parentId == 0);
            return data.ToList();
        }

        public List<Building> GetChildren(int parentId)
        {
            var data = this.buildings.Where(r => r.parentId == parentId);
            return data.ToList();
        }
    }
}
