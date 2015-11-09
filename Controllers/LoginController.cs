using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EasyFarm.Models;
namespace EasyFarm.Controllers
{
    
    public class LoginController : Controller
    {
        private EasyFarmContext db = new EasyFarmContext();
        // GET: /Login/
        public ActionResult Index()
        {
            //var data = (bool)TempData["Failed"];
            return View();
        }

        public ActionResult Login(User user) 
        {
            var result = db.Usuarios.Where(x => x.UserName == user.UserName && x.Password == user.Password);
            if (result.Count() > 0) 
            {
                return RedirectToAction("Index", "Invernadero");
            
            }else {
            TempData["Failed"] = true;
            return RedirectToAction("Index");
            }
        }
        public ActionResult Register() 
        {
            return View();
        }
        public ActionResult PostRegister(User user) 
        {
            db.Usuarios.Add(user);
            db.SaveChanges();
            return RedirectToAction("Index", "Invernadero");
        }
	}
}