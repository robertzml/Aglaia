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
                id = 1,
                text = "江南大学",
                hasChildren = true,
                type = 1,
                parentId = 0,
                spriteCssClass = "fa fa-folder"
            };
            buildings.Add(building);

            Building building2 = new Building
            {
                id = 2,
                text = "行政楼",
                hasChildren = true,
                type = 2,
                parentId = 1,
                spriteCssClass = "fa fa-folder"
            };
            buildings.Add(building2);

            Building building3 = new Building
            {
                id = 3,
                text = "教学楼",
                hasChildren = false,
                parentId = 1,
                type = 2,
                spriteCssClass = "fa fa-folder"
            };
            buildings.Add(building3);

            Building building4 = new Building
            {
                id = 100001,
                text = "A102",
                hasChildren = false,
                type = 3,
                parentId = 2,
                spriteCssClass = "fa fa-file"
            };
            buildings.Add(building4);

            Building building5 = new Building
            {
                id = 100002,
                text = "A103",
                hasChildren = false,
                type = 3,
                parentId = 2,
                spriteCssClass = "fa fa-file"
            };
            buildings.Add(building5);
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
