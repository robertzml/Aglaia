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
        public int id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string name { get; set; }

        public bool hasChildren { get; set; }

        public int parentId { get; set; }

        public int type { get; set; }
    }
}
