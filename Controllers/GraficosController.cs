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



	}
}