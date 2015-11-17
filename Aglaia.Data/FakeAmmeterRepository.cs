using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aglaia.Model;

namespace Aglaia.Data
{
    public class FakeAmmeterRepository : IAmmeterRepository
    {
        #region Field
        private List<Ammeter> ammeters;
        #endregion //Field

        #region Constructor
        public FakeAmmeterRepository()
        {
            Init();
        }
        #endregion //Constructor

        #region Function
        private void Init()
        {
            this.ammeters = new List<Ammeter>();

            Ammeter ammeter1 = new Ammeter
            {
                id = 100001,
                name = "进户表1",
                roomName = "A102",
                departmentName = "教务处",
                buildingId = 2,
                online = true
            };
            this.ammeters.Add(ammeter1);

            Ammeter ammeter2 = new Ammeter
            {
                id = 100002,
                name = "进户表2",
                roomName = "A103",
                departmentName = "教务处",
                buildingId = 2,
                online = true
            };
            this.ammeters.Add(ammeter2);

            Ammeter ammeter3 = new Ammeter
            {
                id = 100003,
                name = "进户表3",
                roomName = "A104",
                departmentName = "财务处",
                buildingId = 2,
                online = false
            };
            this.ammeters.Add(ammeter3);
        }
        #endregion //Function

        #region Method
        public IEnumerable<Ammeter> GetByBuilding(int buildingId)
        {
            return this.ammeters.Where(r => r.buildingId == buildingId);
        }

        public Ammeter Get(long id)
        {
            return this.ammeters.SingleOrDefault(r => r.id == id);
        }
        #endregion //Method
    }
}
