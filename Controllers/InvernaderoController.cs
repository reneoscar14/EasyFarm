using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EasyFarm.Models;

namespace EasyFarm.Controllers
{
    public class InvernaderoController : Controller
    {
        private EasyFarmContext db = new EasyFarmContext();

        // GET: /Invernadero/
        public ActionResult Index()
        {
            return View(db.Invernaderoes.OrderByDescending(x => x.date).Take(10).ToList());
        }
        public List<Invernadero> getData() 
        {
            return (db.Invernaderoes.ToList());
        }
        public void envio(string TipoCultivo, string Modo, double Temperatura, double HumedadRelativa, double HumedadSuelo, string parametros, string Riego, int TemporizadorRiego, int Flujo) 
        {
            var invernadero = new Util().getInvernadero(TipoCultivo, Modo, Temperatura, HumedadRelativa, HumedadSuelo, parametros, Riego, TemporizadorRiego, Flujo);
            db.Invernaderoes.Add(invernadero);
            db.SaveChanges();
        }

        // GET: /Invernadero/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Invernadero invernadero = db.Invernaderoes.Find(id);
            if (invernadero == null)
            {
                return HttpNotFound();
            }
            return View(invernadero);
        }

        // GET: /Invernadero/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Invernadero/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="InvernaderoId,TipoCultivo,Modo,Temperatura,HumedadRelativa,HumedadSuelo,Calefaccion,Ventilador,Extractor,Iluminacion,Riego,CondicionRiego,TemporizadorRiego,Flujo,date")] Invernadero invernadero)
        {
            if (ModelState.IsValid)
            {
                db.Invernaderoes.Add(invernadero);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(invernadero);
        }

        // GET: /Invernadero/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Invernadero invernadero = db.Invernaderoes.Find(id);
            if (invernadero == null)
            {
                return HttpNotFound();
            }
            return View(invernadero);
        }

        // POST: /Invernadero/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="InvernaderoId,TipoCultivo,Modo,Temperatura,HumedadRelativa,HumedadSuelo,Calefaccion,Ventilador,Extractor,Iluminacion,Riego,CondicionRiego,TemporizadorRiego,Flujo,date")] Invernadero invernadero)
        {
            if (ModelState.IsValid)
            {
                db.Entry(invernadero).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(invernadero);
        }

        // GET: /Invernadero/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Invernadero invernadero = db.Invernaderoes.Find(id);
            if (invernadero == null)
            {
                return HttpNotFound();
            }
            return View(invernadero);
        }

        // POST: /Invernadero/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Invernadero invernadero = db.Invernaderoes.Find(id);
            db.Invernaderoes.Remove(invernadero);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
