using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Prueba.Models
{
    public class Empleado : FullAuditedEntity
    {
        [Required]
        [Display(Name = "Identificación")]
        public string Indentificacion { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }


        [Required]
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }
    }
}
