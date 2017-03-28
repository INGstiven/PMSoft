using PMSoft.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PMSoftWeb
{
   public class PMSoftDB : DbContext
   {
      public PMSoftDB() : base("PMSoftDB")
      {

      }

      public DbSet<tipo_identificacion> tipo_identificacion { get; set; }
      public DbSet<tipo_actividad> tipo_actividad { get; set; }
      public DbSet<tipo_recurso> tipo_recurso { get; set; }
      public DbSet<rol> rol { get; set; }
      public DbSet<proyecto> proyecto { get; set; }

        public System.Data.Entity.DbSet<PMSoftWeb.Models.Proyecto> Proyectoes { get; set; }
    }
}