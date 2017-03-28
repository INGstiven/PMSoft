using System.ComponentModel.DataAnnotations;

namespace PMSoft.DAL
{
   public class tipo_recurso
   {
      [Key]
      public int id { get; set; }

      [Required]
      [StringLength(100)]
      [Display(Name = "Tipo de recurso")]
      public string nombre { get; set; }

      [Required]
      [Display(Name = "Estado")]
      public enumEstado estado { get; set; }
   }
}