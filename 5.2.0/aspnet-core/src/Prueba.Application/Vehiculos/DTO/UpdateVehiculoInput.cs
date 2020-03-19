using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba.Vehiculos.DTO
{
    public class UpdateVehiculoInput
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public int EmpleadoId { get; set; }
        public int TipoVehiculoId { get; set; }
    }
}
