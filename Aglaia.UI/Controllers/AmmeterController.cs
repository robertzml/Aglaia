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

        private IEnergyRepository energyRepository;
        #endregion //Field

        #region Constructor
        public AmmeterController()
        {
            this.ammeterRepository = new FakeAmmeterRepository();
            this.energyRepository = new FakeEnergyRepository();
        }
        #endregion //Constructor

        #region Action
        public List<Ammeter> GetByBuilding(int buildingId)
        {
            return this.ammeterRepository.GetByBuilding(buildingId).ToList();
        }

        public Ammeter Get(int id)
        {
            return this.ammeterRepository.Get(id);
        }

        public List<Energy> GetEnergy(DateTime date)
        {
            return this.energyRepository.GetHourRandom(date).ToList();
        }
        #endregion //Action
    }
}
