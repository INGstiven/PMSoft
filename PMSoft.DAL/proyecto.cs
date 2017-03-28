using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMSoft.DAL
{
   [Table("proyecto")]
   public class proyecto
   {
      [Key]
      public int id { get; set; }

      [Required]
      [StringLength(200)]
      [Display(Name = "Nombre del proyecto")]
      public string nombre { get; set; }

      [Required]
      [StringLength(200)]
      [Display(Name = "Objeto del proyecto")]
      public string objeto { get; set; }

      [Required]
      [Display(Name = "Responsable del proyecto")]
      public int persona_responsable { get; set; }

      [Display(Name = "% de asignación del responsable")]
      public double porcentaje_asignacion_responsable { get; set; }

      [Required]
      [Display(Name = "Fecha de inicio")]
      public DateTime fecha_inicio { get; set; }

      [Display(Name = "Fecha de terminación")]
      public DateTime fecha_final { get; set; }

      [Required]
      [Display(Name = "% de avance")]
      public float porcentaje_avance { get; set; }

      [Required]
      //[Column(TypeName = "nvarchar(vax)")]
      [Display(Name = "Alcance")]
      public string alcance { get; set; }

      [Required]
      [Display(Name = "Fecha de creación")]
      public DateTime fecha_creacion { get; set; }

      [Required]
      [StringLength(30)]
      [Display(Name = "Usuario quien lo creó")]
      public string usuario_creacion { get; set; }

      [Display(Name = "Fecha ult modificación")]
      public DateTime fecha_ult_modificacion { get; set; }

      [StringLength(30)]
      [Display(Name = "Usuario quien modificó")]
      public string usuario_ult_modificacion { get; set; }
   }
}