using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba.Empleados.DTO
{
    public class UpdateEmpleadoInput
    {
        public int Id { get; set; }
        public string Indentificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }    
    }
}
