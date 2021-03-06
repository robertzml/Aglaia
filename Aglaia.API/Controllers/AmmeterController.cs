﻿using System;
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
    public class AmmeterController : ApiController
    {
        #region Field
        private IAmmeterRepository ammeterRepository;
        #endregion //Field

        #region Constructor
        public AmmeterController()
        {
            this.ammeterRepository = new FakeAmmeterRepository();
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
        #endregion //Action
    }
}
