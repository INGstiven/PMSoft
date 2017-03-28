using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PMSoft.DAL;

namespace PMSoftWeb
{
   [Authorize(Roles = "PMSoft_admin")]
   public class tipo_identificacionController : Controller
   {
      private PMSoftDB db = new PMSoftDB();

      // GET: tipo_identificacion
      public ActionResult Index()
      {
         return View(db.tipo_identificacion.ToList());
      }

      // GET: tipo_identificacion/Details/5
      public ActionResult Details(int? id)
      {
         if (id == null)
         {
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
         }
         tipo_identificacion tipo_identificacion = db.tipo_identificacion.Find(id);
         if (tipo_identificacion == null)
         {
            return HttpNotFound();
         }
         return View(tipo_identificacion);
      }

      // GET: tipo_identificacion/Create
      public ActionResult Create()
      {
         return View();
      }

      // POST: tipo_identificacion/Create
      // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
      // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
      [HttpPost]
      [ValidateAntiForgeryToken]
      public ActionResult Create([Bind(Include = "id,nombre")] tipo_identificacion tipo_identificacion)
      {
         if (ModelState.IsValid)
         {
            db.tipo_identificacion.Add(tipo_identificacion);
            db.SaveChanges();
            return RedirectToAction("Index");
         }

         return View(tipo_identificacion);
      }

      // GET: tipo_identificacion/Edit/5
      public ActionResult Edit(int? id)
      {
         if (id == null)
         {
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
         }
         tipo_identificacion tipo_identificacion = db.tipo_identificacion.Find(id);
         if (tipo_identificacion == null)
         {
            return HttpNotFound();
         }
         return View(tipo_identificacion);
      }

      // POST: tipo_identificacion/Edit/5
      // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
      // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
      [HttpPost]
      [ValidateAntiForgeryToken]
      public ActionResult Edit([Bind(Include = "id,nombre")] tipo_identificacion tipo_identificacion)
      {
         if (ModelState.IsValid)
         {
            db.Entry(tipo_identificacion).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
         }
         return View(tipo_identificacion);
      }

      // GET: tipo_identificacion/Delete/5
      public ActionResult Delete(int? id)
      {
         if (id == null)
         {
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
         }
         tipo_identificacion tipo_identificacion = db.tipo_identificacion.Find(id);
         if (tipo_identificacion == null)
         {
            return HttpNotFound();
         }
         return View(tipo_identificacion);
      }

      // POST: tipo_identificacion/Delete/5
      [HttpPost, ActionName("Delete")]
      [ValidateAntiForgeryToken]
      public ActionResult DeleteConfirmed(int id)
      {
         tipo_identificacion tipo_identificacion = db.tipo_identificacion.Find(id);
         db.tipo_identificacion.Remove(tipo_identificacion);
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
