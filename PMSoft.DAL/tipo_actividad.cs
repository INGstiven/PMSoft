using System.ComponentModel.DataAnnotations;

namespace PMSoft.DAL
{
   public class tipo_actividad
   {
      [Key]
      public int id { get; set; }

      [Required]
      [StringLength(100)]
      [Display(Name = "Tipo de actividad")]
      public string nombre { get; set; }

      [Required]
      [Display(Name = "Estado")]
      public enumEstado estado { get; set; }
   }
}