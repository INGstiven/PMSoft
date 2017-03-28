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
using Respositories;

namespace PMSoftWeb.Controllers
{
    public class ProyectoController : Controller
    {

        public ActionResult proyecto()
        {

            return View();

        }

        [HttpPost]
        public ActionResult proyecto(PMSoftWeb.Models.Proyecto proyecto)
        {

            proyecto entityProject = new PMSoft.DAL.proyecto();
            entityProject.alcance = proyecto.alcance;
            entityProject.fecha_creacion = proyecto.fecha_creacion;
            entityProject.fecha_final = proyecto.fecha_final;
            entityProject.fecha_inicio = proyecto.fecha_inicio;
            entityProject.fecha_ult_modificacion = proyecto.fecha_ult_modificacion;
            entityProject.nombre = proyecto.nombre;
            entityProject.objeto = proyecto.objeto;
            entityProject.persona_responsable = proyecto.persona_responsable;
            entityProject.porcentaje_asignacion_responsable = proyecto.porcentaje_asignacion_responsable;
            entityProject.porcentaje_avance = proyecto.porcentaje_avance;
            entityProject.usuario_creacion = proyecto.usuario_creacion;
            entityProject.usuario_ult_modificacion = proyecto.usuario_ult_modificacion;

            Respositories.CommonRepository.CommonRepository<PMSoftDB, proyecto>  repo = new Respositories.CommonRepository.CommonRepository<PMSoftDB, proyecto>();
            repo.Add(entityProject);
            repo.Save();
            return View();
        }

        public ActionResult DeleteProject(int projectId){

            try
            {

                Respositories.CommonRepository.CommonRepository<PMSoftDB, proyecto> repo = new Respositories.CommonRepository.CommonRepository<PMSoftDB, proyecto>();
                proyecto entityProject = repo.FindBy(m => m.id == projectId).FirstOrDefault();
                if(entityProject != null)
                {

                    repo.Delete(entityProject);
                    repo.Save();
                }

                return Json(new { success = true, Message = "Se eliminó coreectamente el registro" },  JsonRequestBehavior.AllowGet);
            }
            catch(Exception ex)
            {

                return Json(new { success = true, Message = "Hubo un error eliminando el registro : " +  ex }, JsonRequestBehavior.AllowGet);
            }



        }
    }
}