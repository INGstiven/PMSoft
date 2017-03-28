using System.ComponentModel.DataAnnotations;

namespace PMSoft.DAL
{
   public class rol
   {
      [Key]
      public int id { get; set; }

      [Required]
      [StringLength(100)]
      [Display(Name = "Rol")]
      public string nombre { get; set; }
   }
}