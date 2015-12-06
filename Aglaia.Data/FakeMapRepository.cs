using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aglaia.Model;

namespace Aglaia.Data
{
    public class FakeMapRepository : IMapRepository
    {
        #region Field
        private List<MapPoint> points;
        #endregion //Field

        #region Constructor
        public FakeMapRepository()
        {
            Init();
        }
        #endregion //Constructor

        #region Function
        private void Init()
        {
            this.points = new List<MapPoint>();

            MapPoint p1 = new MapPoint
            {
                x = 230,
                y = 407,
                content = "<div class='map-point-content'><h4 class='text-success' style='text-align:center;'>行政楼</h4><dl><dt>用电评价</dt>" +
                    "<dd style='border-bottom: 1px #a3a3a3 solid;padding-top: 5px;height: 65px;'>根据历史数据分析，该建筑周三平均用电为63度，<font class='text-success'>低</font>" +
                    "于同类建筑（教学楼建筑）周三平均用电85度，目前该建筑今日已用电55.5度。</dd></dl>" +
                    "<div class='tab1'><strong>建筑类别：</strong>教学楼建筑<br><strong>建筑面积：</strong>23397.24㎡<br><strong>使用面积：</strong>12920.13㎡<br></div>" +
                    "<div class='tab2'><strong>今日用电：</strong><font class='tooltips text-primary' data-placement='top' data-original-title='统计时段数据完整'>55.54</font>度<br><strong>本周用电：</strong><font class='tooltips text-primary' data-placement='top' data-original-title='统计时段数据完整'>164.4</font>度<br><strong>本月用电：</strong><font class='tooltips text-primary' data-placement='top' data-original-title='统计时段数据完整'>302.01</font>度<br></div>" +
                    "</div>"
            };
            this.points.Add(p1);

            MapPoint p2 = new MapPoint
            {
                x = 703,
                y = 381,
                content = "<div class='map-point-content'><h4 class='text-success' style='text-align:center;'>教学楼</h4><dl><dt>用电评价</dt>" +
                    "<dd style='border-bottom: 1px #a3a3a3 solid;padding-top: 5px;height: 65px;'>根据历史数据分析，该建筑周三平均用电为63度，<font class='text-success'>低</font>" +
                    "于同类建筑（教学楼建筑）周三平均用电85度，目前该建筑今日已用电55.5度。</dd></dl>" +
                    "<div class='tab1'><strong>建筑类别：</strong>教学楼建筑<br><strong>建筑面积：</strong>23397.24㎡<br><strong>使用面积：</strong>12920.13㎡<br></div>" +
                    "<div class='tab2'><strong>今日用电：</strong><font class='tooltips text-primary' data-placement='top' data-original-title='统计时段数据完整'>55.54</font>度<br><strong>本周用电：</strong><font class='tooltips text-primary' data-placement='top' data-original-title='统计时段数据完整'>164.4</font>度<br><strong>本月用电：</strong><font class='tooltips text-primary' data-placement='top' data-original-title='统计时段数据完整'>302.01</font>度<br></div>" +
                    "</div>"
            };
            this.points.Add(p2);
        }
        #endregion //Function

        #region Method
        public List<MapPoint> GetPoints()
        {
            return this.points;
        }
        #endregion //Method
    }
}
