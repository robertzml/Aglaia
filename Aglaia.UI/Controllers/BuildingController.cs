using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Aglaia.Data;
using Aglaia.Model;

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

        public IEnumerable<Building> Get()
        {
            return buildingRepository.Get();
        }
    }
}
