using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PMSoft.DAL;
using PMSoftWeb;

namespace PMSoftWeb.Controllers
{
   [Authorize(Roles = "PMSoft_admin")]
   public class tipo_actividadController : Controller
   {
      private PMSoftDB db = new PMSoftDB();

      // GET: tipo_actividad
      public ActionResult Index()
      {
         return View(db.tipo_actividad.ToList());
      }

      // GET: tipo_actividad/Details/5
      public ActionResult Details(int? id)
      {
         if (id == null)
         {
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
         }
         tipo_actividad tipo_actividad = db.tipo_actividad.Find(id);
         if (tipo_actividad == null)
         {
            return HttpNotFound();
         }
         return View(tipo_actividad);
      }

      // GET: tipo_actividad/Create
      public ActionResult Create()
      {
         return View();
      }

      // POST: tipo_actividad/Create
      // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
      // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
      [HttpPost]
      [ValidateAntiForgeryToken]
      public ActionResult Create([Bind(Include = "id,nombre,estado")] tipo_actividad tipo_actividad)
      {
         if (ModelState.IsValid)
         {
            db.tipo_actividad.Add(tipo_actividad);
            db.SaveChanges();
            return RedirectToAction("Index");
         }

         return View(tipo_actividad);
      }

      // GET: tipo_actividad/Edit/5
      public ActionResult Edit(int? id)
      {
         if (id == null)
         {
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
         }
         tipo_actividad tipo_actividad = db.tipo_actividad.Find(id);
         if (tipo_actividad == null)
         {
            return HttpNotFound();
         }
         return View(tipo_actividad);
      }

      // POST: tipo_actividad/Edit/5
      // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
      // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
      [HttpPost]
      [ValidateAntiForgeryToken]
      public ActionResult Edit([Bind(Include = "id,nombre,estado")] tipo_actividad tipo_actividad)
      {
         if (ModelState.IsValid)
         {
            db.Entry(tipo_actividad).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
         }
         return View(tipo_actividad);
      }

      // GET: tipo_actividad/Delete/5
      public ActionResult Delete(int? id)
      {
         if (id == null)
         {
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
         }
         tipo_actividad tipo_actividad = db.tipo_actividad.Find(id);
         if (tipo_actividad == null)
         {
            return HttpNotFound();
         }
         return View(tipo_actividad);
      }

      // POST: tipo_actividad/Delete/5
      [HttpPost, ActionName("Delete")]
      [ValidateAntiForgeryToken]
      public ActionResult DeleteConfirmed(int id)
      {
         tipo_actividad tipo_actividad = db.tipo_actividad.Find(id);
         db.tipo_actividad.Remove(tipo_actividad);
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
