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
                departmentName = "宿管部",
                buildingId = 2,
                online = true,
                totalDailyUsage = 25.3,
                totalMonthUsage = 55.2,
                property = "该表不是总表；该表纳入计量。",
                loops = new List<Loop>(),
                communicateTime = DateTime.Now,
                saveModel = "待机功耗监测",
                address = "A102"                
            };
            Loop loop1 = new Loop
            {
                number = 1,
                name = "回路1",
                dailyUsage = 25.3,
                monthUsage = 55.2,
                subitem = "照明",
                nature = "生活",
                ammeterDisplay = 1035.4,
                totalDisplay = 15430.5,
                multiply = 1,
                unitPrice = 0.6
            };
            ammeter1.loops.Add(loop1);

            Loop loop2 = new Loop
            {
                number = 2,
                name = "回路2",
                dailyUsage = 25.3,
                monthUsage = 55.2,
                subitem = "空调",
                nature = "生活",
                ammeterDisplay = 3588.2,
                totalDisplay = 25007.1,
                multiply = 1,
                unitPrice = 0.65
            };
            ammeter1.loops.Add(loop2);

            Loop loop3 = new Loop
            {
                number = 3,
                name = "回路3",
                dailyUsage = 25.3,
                monthUsage = 55.2,
                subitem = "动力",
                nature = "生活",
                ammeterDisplay = 1780.5,
                totalDisplay = 14697.3,
                multiply = 1,
                unitPrice = 0.6
            };
            ammeter1.loops.Add(loop3);

            Loop loop4 = new Loop
            {
                number = 4,
                name = "回路4",
                dailyUsage = 25.3,
                monthUsage = 55.2,
                subitem = "备用",
                nature = "生活",
                ammeterDisplay = 88.2,
                totalDisplay = 721.0,
                multiply = 1,
                unitPrice = 0.6
            };
            ammeter1.loops.Add(loop4);
            this.ammeters.Add(ammeter1);

            Ammeter ammeter2 = new Ammeter
            {
                id = 100002,
                number = "A1000382",
                name = "进户表2",
                roomName = "A103",
                departmentName = "宿管部",
                buildingId = 2,
                online = true,
                totalDailyUsage = 15.7,
                totalMonthUsage = 153.6,
                property = "该表不是总表；该表纳入计量。",
                loops = new List<Loop>(),
                communicateTime = DateTime.Now,
                saveModel = "待机功耗监测",
                address = "A103"
            };

            Loop loop5 = new Loop
            {
                number = 1,
                name = "回路1",
                dailyUsage = 25.3,
                monthUsage = 55.2,
                subitem = "照明",
                nature = "生活",
                ammeterDisplay = 8588.2,
                totalDisplay = 36760.4,
                multiply = 1,
                unitPrice = 0.6
            };
            ammeter2.loops.Add(loop5);

            Loop loop6 = new Loop
            {
                number = 2,
                name = "回路2",
                dailyUsage = 122.3,
                monthUsage = 305.1,
                subitem = "空调",
                nature = "生活",
                ammeterDisplay = 1571.4,
                totalDisplay = 26110.6,
                multiply = 1,
                unitPrice = 0.6
            };
            ammeter2.loops.Add(loop6);

            Loop loop7 = new Loop
            {
                number = 3,
                name = "回路3",
                dailyUsage = 98.0,
                monthUsage = 208.6,
                subitem = "动力",
                nature = "生活",
                ammeterDisplay = 1544.2,
                totalDisplay = 36779.2,
                multiply = 1,
                unitPrice = 0.6
            };
            ammeter2.loops.Add(loop7);

            Loop loop8 = new Loop
            {
                number = 4,
                name = "回路4",
                dailyUsage = 5.5,
                monthUsage = 12.2,
                subitem = "备用",
                nature = "生活",
                ammeterDisplay = 2588.2,
                totalDisplay = 4760.4,
                multiply = 1,
                unitPrice = 0.6
            };
            ammeter2.loops.Add(loop8);

            this.ammeters.Add(ammeter2);

            Ammeter ammeter3 = new Ammeter
            {
                id = 200001,
                number = "B1000601",
                name = "一级表1",
                roomName = "一层",
                departmentName = "公共用电",
                buildingId = 2,
                online = true,
                totalDailyUsage = 48.2,
                totalMonthUsage = 603.4,
                property = "该表是总表；该表不纳入计量。",
                loops = new List<Loop>(),
                communicateTime = DateTime.Now,
                saveModel = "待机功耗监测",
                address = "配电间"
            };

            Loop loop9 = new Loop
            {
                number = 1,
                name = "回路1",
                dailyUsage = 25.3,
                monthUsage = 55.2,
                subitem = "照明",
                nature = "生活",
                ammeterDisplay = 7581.2,
                totalDisplay = 26760.4,
                multiply = 1,
                unitPrice = 0.6
            };
            ammeter3.loops.Add(loop9);

            Loop loop10= new Loop
            {
                number = 2,
                name = "回路2",
                dailyUsage = 25.3,
                monthUsage = 55.2,
                subitem = "空调",
                nature = "生活",
                ammeterDisplay = 8608.2,
                totalDisplay = 33490.7,
                multiply = 1,
                unitPrice = 0.6
            };
            ammeter3.loops.Add(loop10);

            Loop loop11 = new Loop
            {
                number = 3,
                name = "回路3",
                dailyUsage = 25.3,
                monthUsage = 55.2,
                subitem = "动力",
                nature = "生活",
                ammeterDisplay = 8588.2,
                totalDisplay = 36760.4,
                multiply = 1,
                unitPrice = 0.6
            };
            ammeter3.loops.Add(loop11);

            Loop loop12 = new Loop
            {
                number = 4,
                name = "回路4",
                dailyUsage = 17.9,
                monthUsage = 22.2,
                subitem = "备用",
                nature = "生活",
                ammeterDisplay = 88.2,
                totalDisplay = 760.4,
                multiply = 1,
                unitPrice = 0.6
            };
            ammeter3.loops.Add(loop12);
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
                totalDailyUsage = 18.0,
                totalMonthUsage = 93.5,
                property = "该表是总表；该表不纳入计量。",
                loops = new List<Loop>(),
                communicateTime = DateTime.Now,
                saveModel = "待机功耗监测",
                address = "配电间"
            };

            Loop loop13 = new Loop
            {
                number = 1,
                name = "回路1",
                dailyUsage = 25.3,
                monthUsage = 55.2,
                subitem = "照明",
                nature = "生活",
                ammeterDisplay = 8588.2,
                totalDisplay = 36760.4,
                multiply = 1,
                unitPrice = 0.6
            };
            ammeter4.loops.Add(loop13);

            Loop loop14 = new Loop
            {
                number = 2,
                name = "回路2",
                dailyUsage = 25.3,
                monthUsage = 55.2,
                subitem = "空调",
                nature = "生活",
                ammeterDisplay = 8588.2,
                totalDisplay = 36760.4,
                multiply = 1,
                unitPrice = 0.6
            };
            ammeter4.loops.Add(loop14);

            Loop loop15 = new Loop
            {
                number = 3,
                name = "回路3",
                dailyUsage = 25.3,
                monthUsage = 55.2,
                subitem = "动力",
                nature = "生活",
                ammeterDisplay = 8588.2,
                totalDisplay = 36760.4,
                multiply = 1,
                unitPrice = 0.6
            };
            ammeter4.loops.Add(loop15);

            Loop loop16 = new Loop
            {
                number = 4,
                name = "回路4",
                dailyUsage = 25.3,
                monthUsage = 55.2,
                subitem = "备用",
                nature = "生活",
                ammeterDisplay = 8588.2,
                totalDisplay = 36760.4,
                multiply = 1,
                unitPrice = 0.6
            };
            ammeter4.loops.Add(loop16);
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
