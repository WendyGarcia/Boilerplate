using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Prueba.Models
{
    public class Celda:FullAuditedEntity
    {
        [Required]
        [Display(Name = "Número de celda")]
        public string NumeroCelda { get; set; }

        public string Estado { get; set; }
    }
}
