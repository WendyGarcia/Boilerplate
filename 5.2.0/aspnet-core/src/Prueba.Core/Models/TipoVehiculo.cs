using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Prueba.Models
{
    public class TipoVehiculo:FullAuditedEntity
    {
        [Required]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
    }
}
