using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba.Vehiculos.DTO
{
    public class CreateVehiculoInput
    {
        public string Placa { get; set; }
        public int EmpleadoId { get; set; }
        public int TipoVehiculoId { get; set; }
    }
}
