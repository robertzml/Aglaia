using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Aglaia.Data;
using Aglaia.Model;

namespace Aglaia.API.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class TreeController : ApiController
    {
        #region Field
        private ITreeRepository treeRepository;
        #endregion //Field

        #region Constructor
        public TreeController()
        {
            this.treeRepository = new FakeTreeRepository();
        }
        #endregion //Constructor

        #region Action
        public List<TreeNode> Get(int id)
        {
            return this.treeRepository.GetTree(id);
        }
        #endregion //Action
    }
}
