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
                number = "A1000381",
                name = "进户表1",
                roomName = "A102",
                departmentName = "教务处",
                buildingId = 2,
                online = true,
                dailyUsage = 25.3,
                monthUsage = 55.2,
                property = "该表不是总表；该表纳入计量。",
                subitem = "照明",
                nature = "办公",
                ammeterDisplay = 4588.2,
                totalDisplay = 15720.5,
                multiply = 1,
                unitPrice = 0.6,
                communicateTime = DateTime.Now,
                saveModel = "待机功耗监测",
                address = "A102"                
            };
            this.ammeters.Add(ammeter1);

            Ammeter ammeter2 = new Ammeter
            {
                id = 100002,
                number = "A1000382",
                name = "进户表2",
                roomName = "A103",
                departmentName = "财务处",
                buildingId = 2,
                online = true,
                dailyUsage = 15.7,
                monthUsage = 153.6,
                property = "该表不是总表；该表纳入计量。",
                subitem = "照明",
                nature = "办公",
                ammeterDisplay = 8588.2,
                totalDisplay = 36760.4,
                multiply = 1,
                unitPrice = 0.6,
                communicateTime = DateTime.Now,
                saveModel = "待机功耗监测",
                address = "A103"
            };
            this.ammeters.Add(ammeter2);
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
