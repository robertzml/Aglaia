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
    public class EnergyController : ApiController
    {
        #region Field
        private IEnergyRepository energyRepository;
        #endregion //Field

        #region Constructor
        public EnergyController()
        {
            this.energyRepository = new FakeEnergyRepository();
        }
        #endregion //Constructor

        #region Action
        public List<Energy> Get(DateTime date)
        {
            return this.energyRepository.GetHourRandom(date).ToList();
        }

        public List<Energy> GetDays(DateTime start, DateTime end)
        {
            return this.energyRepository.GetDayRandom(start, end).ToList();
        }
        #endregion //Action
    }
}
