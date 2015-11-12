using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Aglaia.Data;
using Aglaia.Model;
using Newtonsoft.Json;
using System.Text;
using System.IO;

namespace Aglaia.UI.Controllers
{
    public class BuildingController : ApiController
    {
        #region Field
        private IBuildingRepository buildingRepository;
        #endregion //Field

        #region Constructor
        public BuildingController()
        {
            buildingRepository = new FakeBuildingRepository();
        }
        #endregion //Constructor

        #region Action
        public List<Building> GetChildren()
        {
            return buildingRepository.GetTop();
        }

        public List<Building> GetChildren(int id)
        {
            return buildingRepository.GetChildren(id);
        }
        #endregion //Action
    }
}
