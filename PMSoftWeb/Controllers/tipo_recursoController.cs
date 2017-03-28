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
   public class tipo_recursoController : Controller
   {
      private PMSoftDB db = new PMSoftDB();

      // GET: tipo_recurso
      public ActionResult Index()
      {
         return View(db.tipo_recurso.ToList());
      }

      // GET: tipo_recurso/Details/5
      public ActionResult Details(int? id)
      {
         if (id == null)
         {
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
         }
         tipo_recurso tipo_recurso = db.tipo_recurso.Find(id);
         if (tipo_recurso == null)
         {
            return HttpNotFound();
         }
         return View(tipo_recurso);
      }

      // GET: tipo_recurso/Create
      public ActionResult Create()
      {
         return View();
      }

      // POST: tipo_recurso/Create
      // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
      // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
      [HttpPost]
      [ValidateAntiForgeryToken]
      public ActionResult Create([Bind(Include = "id,nombre,estado")] tipo_recurso tipo_recurso)
      {
         if (ModelState.IsValid)
         {
            db.tipo_recurso.Add(tipo_recurso);
            db.SaveChanges();
            return RedirectToAction("Index");
         }

         return View(tipo_recurso);
      }

      // GET: tipo_recurso/Edit/5
      public ActionResult Edit(int? id)
      {
         if (id == null)
         {
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
         }
         tipo_recurso tipo_recurso = db.tipo_recurso.Find(id);
         if (tipo_recurso == null)
         {
            return HttpNotFound();
         }
         return View(tipo_recurso);
      }

      // POST: tipo_recurso/Edit/5
      // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
      // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
      [HttpPost]
      [ValidateAntiForgeryToken]
      public ActionResult Edit([Bind(Include = "id,nombre,estado")] tipo_recurso tipo_recurso)
      {
         if (ModelState.IsValid)
         {
            db.Entry(tipo_recurso).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
         }
         return View(tipo_recurso);
      }

      // GET: tipo_recurso/Delete/5
      public ActionResult Delete(int? id)
      {
         if (id == null)
         {
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
         }
         tipo_recurso tipo_recurso = db.tipo_recurso.Find(id);
         if (tipo_recurso == null)
         {
            return HttpNotFound();
         }
         return View(tipo_recurso);
      }

      // POST: tipo_recurso/Delete/5
      [HttpPost, ActionName("Delete")]
      [ValidateAntiForgeryToken]
      public ActionResult DeleteConfirmed(int id)
      {
         tipo_recurso tipo_recurso = db.tipo_recurso.Find(id);
         db.tipo_recurso.Remove(tipo_recurso);
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
