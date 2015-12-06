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
    public class MapController : ApiController
    {
        #region Field
        private IMapRepository mapRepository;
        #endregion //Field

        #region Constructor
        public MapController()
        {
            this.mapRepository = new FakeMapRepository();
        }
        #endregion //Constructor

        #region Action
        public List<MapPoint> GetPoints()
        {
            return this.mapRepository.GetPoints();
        }
        #endregion //Action
    }
}
