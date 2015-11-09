using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aglaia.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 导航菜单
        /// </summary>
        /// <returns></returns>
        [ChildActionOnly]
        public ActionResult Menu()
        {
            return View();
        }

        /// <summary>
        /// 楼层页面
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Building(int id)
        {
            return View();
        }

        /// <summary>
        /// 房间页面
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Room(int id)
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

    }
}