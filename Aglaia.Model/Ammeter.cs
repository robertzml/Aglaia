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

        /// <summary>
        /// 表号
        /// </summary>
        public string number { get; set; }

        /// <summary>
        /// 表名
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 房间名称
        /// </summary>
        public string roomName { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        public string departmentName { get; set; }

        public int buildingId { get; set; }

        /// <summary>
        /// 是否在线
        /// </summary>
        public bool online { get; set; }

        public double dailyUsage { get; set; }

        public double monthUsage { get; set; }

        /// <summary>
        /// 计量属性
        /// </summary>
        public string property { get; set; }

        /// <summary>
        /// 用电分项
        /// </summary>
        public string subitem { get; set; }

        /// <summary>
        /// 用电性质
        /// </summary>
        public string nature { get; set; }

        public double ammeterDisplay { get; set; }

        public double totalDisplay { get; set; }

        public double multiply { get; set; }

        public double unitPrice { get; set; }

        public DateTime communicateTime { get; set; }

        public string saveModel { get; set; }

        public string address { get; set; }
    }
}
