using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PMSoft.DAL
{
   [Table("tipo_identificacion")]
   public class tipo_identificacion
   {
      [Key]
      public int id { get; set; }
      [Required]
      [StringLength(100)]
      [Display(Name = "Tipo de identificación")]
      public string nombre { get; set; }
   }
}