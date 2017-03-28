using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PMSoftWeb.Models
{
    public class Proyecto
    {

        public int id { get; set; }

        public string nombre { get; set; }

        public string objeto { get; set; }

        public int persona_responsable { get; set; }

        public double porcentaje_asignacion_responsable { get; set; }

        public DateTime fecha_inicio { get; set; }

        public DateTime fecha_final { get; set; }

        public float porcentaje_avance { get; set; }

        public string alcance { get; set; }

        public DateTime fecha_creacion { get; set; }

        public string usuario_creacion { get; set; }

        public DateTime fecha_ult_modificacion { get; set; }

        public string usuario_ult_modificacion { get; set; }
    }
}