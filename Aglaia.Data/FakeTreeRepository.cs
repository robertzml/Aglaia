using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aglaia.Model;

namespace Aglaia.Data
{
    public class FakeTreeRepository : ITreeRepository
    {
        #region Field
        private List<TreeNode> tree1;

        private List<TreeNode> tree2;
        #endregion //Field

        #region Constructor
        public FakeTreeRepository()
        {
            Init();
            Init2();
        }
        #endregion //Constructor

        #region Function
        private void Init()
        {
            this.tree1 = new List<TreeNode>();

            TreeNode node1 = new TreeNode
            {
                id = 1,
                text = "江南大学",
                hasChildren = true,
                type = 1,
                parentId = 0,
                ammeterId = 0
            };
            tree1.Add(node1);

            TreeNode node2 = new TreeNode
            {
                id = 2,
                text = "一级表1",
                hasChildren = true,
                type = 2,
                parentId = 1,
                ammeterId = 200001
            };
            tree1.Add(node2);

            TreeNode node3 = new TreeNode
            {
                id = 3,
                text = "一级表2",
                hasChildren = false,
                parentId = 1,
                type = 2,
                ammeterId = 200002
            };
            tree1.Add(node3);

            TreeNode node4 = new TreeNode
            {
                id = 4,
                text = "进户表1",
                hasChildren = false,
                type = 3,
                parentId = 2,
                ammeterId = 100001
            };
            tree1.Add(node4);

            TreeNode node5 = new TreeNode
            {
                id = 5,
                text = "进户表2",
                hasChildren = false,
                type = 3,
                parentId = 2,
                ammeterId = 100002
            };
            tree1.Add(node5);
        }

        private void Init2()
        {
            this.tree2 = new List<TreeNode>();

            TreeNode node1 = new TreeNode
            {
                id = 1,
                text = "江南大学",
                hasChildren = true,
                type = 1,
                parentId = 0,
                objectId = 100000
            };
            tree2.Add(node1);

            TreeNode node2 = new TreeNode
            {
                id = 2,
                text = "1号公寓",
                hasChildren = true,
                type = 2,
                parentId = 1,
                objectId = 100001
            };
            tree2.Add(node2);

            TreeNode node3 = new TreeNode
            {
                id = 3,
                text = "2号公寓",
                hasChildren = true,
                type = 2,
                parentId = 1,
                objectId = 100002
            };
            tree2.Add(node3);

            TreeNode node4 = new TreeNode
            {
                id = 4,
                text = "1层",
                hasChildren = false,
                type = 3,
                parentId = 2,
                objectId = 200001
            };
            tree2.Add(node4);

            TreeNode node5 = new TreeNode
            {
                id = 5,
                text = "2层",
                hasChildren = false,
                type = 3,
                parentId = 2,
                objectId = 200002
            };
            tree2.Add(node5);
        }
        #endregion //Function


        #region Method
        public List<TreeNode> GetTree(int id)
        {
            if (id == 1)
                return tree1;
            else if (id == 2)
                return tree2;
            else
                return null;
        }
        #endregion //Method
    }
}
