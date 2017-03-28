using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSoft.DAL
{
   public enum enumEstado
   {
      [Display(Name = "Activo")]
      Activo,
      [Display(Name = "Inactivo")]
      Inactivo
   }
}
