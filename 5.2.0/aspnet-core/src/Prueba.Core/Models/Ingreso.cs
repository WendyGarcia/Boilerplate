using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Prueba.Models
{
    public class Ingreso:FullAuditedEntity
    {

        [ForeignKey("Vehiculo")]
        public int VehiculoId { get; set; }


        [Required]
        public DateTime HoraIngreso { get; set; }        

        public DateTime HoraSalida { get; set; }


        [ForeignKey("Celda") ]
        public int CeldaId { get; set; }

        
        public virtual Vehiculo Vehiculo { get; set; }

        public virtual Empleado Empleado { get; set; }

        public virtual Celda Celda { get; set; }
    }
}
  