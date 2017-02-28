using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aglaia.Model
{
    /// <summary>
    /// 树形类
    /// </summary>
    public class TreeNode
    {
        /// <summary>
        /// ID
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string text { get; set; }

        public bool hasChildren { get; set; }

        public int parentId { get; set; }

        public int type { get; set; }

        public int ammeterId { get; set; }

        public int objectId { get; set; }
    }
}
