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

            Ammeter ammeter3 = new Ammeter
            {
                id = 200001,
                number = "B1000601",
                name = "一级表1",
                roomName = "配电间",
                departmentName = "公共用电",
                buildingId = 2,
                online = true,
                dailyUsage = 48.2,
                monthUsage = 603.4,
                property = "该表是总表；该表不纳入计量。",
                subitem = "照明",
                nature = "办公",
                ammeterDisplay = 13945.2,
                totalDisplay = 26882.8,
                multiply = 1,
                unitPrice = 0.6,
                communicateTime = DateTime.Now,
                saveModel = "待机功耗监测",
                address = "配电间"
            };
            this.ammeters.Add(ammeter3);

            Ammeter ammeter4 = new Ammeter
            {
                id = 200002,
                number = "B1000602",
                name = "一级表2",
                roomName = "配电间",
                departmentName = "公共用电",
                buildingId = 2,
                online = true,
                dailyUsage = 18.0,
                monthUsage = 93.5,
                property = "该表是总表；该表不纳入计量。",
                subitem = "照明",
                nature = "办公",
                ammeterDisplay = 8744.1,
                totalDisplay = 13942.5,
                multiply = 1,
                unitPrice = 0.6,
                communicateTime = DateTime.Now,
                saveModel = "待机功耗监测",
                address = "配电间"
            };
            this.ammeters.Add(ammeter4);
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
