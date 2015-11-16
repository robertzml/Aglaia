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
    public class AmmeterController : ApiController
    {
        #region Field
        private IAmmeterRepository ammeterRepository;
        #endregion //Field

        #region Constructor
        public AmmeterController()
        {
            ammeterRepository = new FakeAmmeterRepository();
        }
        #endregion //Constructor

        #region Action
        public List<Ammeter> GetByBuilding(int buildingId)
        {
            return this.ammeterRepository.GetByBuilding(buildingId).ToList();
        }
        #endregion //Action
    }
}
