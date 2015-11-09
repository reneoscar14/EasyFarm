using EasyFarm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace EasyFarm.Controllers
{
    public class HistoryController : Controller
    {
        private EasyFarmContext db = new EasyFarmContext();

        public ActionResult Index() 
        {
            return View(db.Invernaderoes.OrderByDescending(x => x.date).FirstOrDefault());
        }

        public JsonResult Update() 
        {
            return Json(db.Invernaderoes.OrderByDescending(x => x.date).FirstOrDefault(), JsonRequestBehavior.AllowGet);
        }

    }
}
