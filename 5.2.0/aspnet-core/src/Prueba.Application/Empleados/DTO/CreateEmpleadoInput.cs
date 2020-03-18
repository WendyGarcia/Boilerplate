using Abp.AutoMapper;
using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba.Empleados.DTO
{
    [AutoMapFrom(typeof(Empleado)), AutoMapTo(typeof(Empleado))]
    public class CreateEmpleadoInput
    {
        public string Identificacion { get; set; }
        public DateTime CreationTime { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

    }
}
