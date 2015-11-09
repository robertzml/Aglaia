using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aglaia.Model
{
    /// <summary>
    /// 建筑类
    /// </summary>
    public class Building
    {
        /// <summary>
        /// ID
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// 父级ID
        /// </summary>
        public string parent { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public string li_attr { get; set; }
    }
}
