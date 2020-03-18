using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Prueba.Models
{
    public class Vehiculo : FullAuditedEntity, IHasCreationTime
    {
        [Required]
        public string Placa { get; set; }

        [ForeignKey("Empleado")]
        public int EmpleadoId { get; set; }

        [ForeignKey("TipoVehiculo")]
        public int TipoVehiculoId { get; set; }

        public virtual Empleado Empleado {get; set;}

        public virtual TipoVehiculo TipoVehiculo { get; set; }
    }
}
