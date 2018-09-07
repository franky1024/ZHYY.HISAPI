using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace zhyy.his.Controllers
{
    /// <summary>
    /// 主页控制器1
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// 主页控制器
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
