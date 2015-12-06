using EasyFarm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyFarm.Controllers
{
    public class GraficosController : Controller
    {
        private EasyFarmContext db = new EasyFarmContext();
        //
        // GET: /Graficos/
        public ActionResult Index()
        {

            return View();
        }
        public JsonResult getTemp() 
        {
            var last10 = db.Invernaderoes.OrderByDescending(x => x.InvernaderoId).Take(10).Select(x=> 
                new {
                        Date = x.date,
                        Temp = x.Temperatura
                    });
            return Json(last10,JsonRequestBehavior.AllowGet);
        }
        public JsonResult getHumRelativa() 
        {
            var last10 = db.Invernaderoes.OrderByDescending(x => x.InvernaderoId).Take(10).Select(x=> 
                new {
                        Date = x.date,
                        Temp = x.HumedadRelativa
                    });
            return Json(last10,JsonRequestBehavior.AllowGet);
        }
        public JsonResult getHumSuelo()
        {
            var last10 = db.Invernaderoes.OrderByDescending(x => x.InvernaderoId).Take(10).Select(x =>
                new
                {
                    Date = x.date,
                    Temp = x.HumedadSuelo
                });
            return Json(last10, JsonRequestBehavior.AllowGet);
        }
        public JsonResult getFlujo()
        {
            var last10 = db.Invernaderoes.OrderByDescending(x => x.InvernaderoId).Take(10).Select(x =>
                new
                {
                    Date = x.date,
                    Temp = x.Flujo
                });
            return Json(last10, JsonRequestBehavior.AllowGet);
        }
        

	}
}