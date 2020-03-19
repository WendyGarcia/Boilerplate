using Abp.Application.Services;
using Abp.ObjectMapping;
using Prueba.Empleados.DTO;
using Prueba.Models;
using Prueba.Vehiculos.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Vehiculos
{
    public class VehiculoAppService: ApplicationService, IVehiculoAppService
    {
        private readonly IObjectMapper _objectMapper;
        private readonly IVehiculoManager _vehiculoManager;
        public VehiculoAppService(IVehiculoManager vehiculoManager, IObjectMapper objectMapper)
        {
            _vehiculoManager = vehiculoManager;
            _objectMapper = objectMapper;
        }

        public async Task Create(CreateVehiculoInput input)
        {
            var Vehiculo = _objectMapper.Map<Vehiculo>(input);
            await _vehiculoManager.Create(Vehiculo);
        }

        public void Delete(DeleteVehiculoInput input)
        {
            _vehiculoManager.Delete(input.Id);
        }

        public GetVehiculoOutput GetVehiculoById(GetVehiculoInput input)
        {
            var getVehiculo = _vehiculoManager.GetVehiculoById(input.Id);
            GetVehiculoOutput output = _objectMapper.Map<GetVehiculoOutput>(getVehiculo);
            return output;
        }

        public IEnumerable<GetVehiculoOutput> ListAll()
        {
            var getAll = _vehiculoManager.GetAllList().ToList();
            List<GetVehiculoOutput> output = _objectMapper.Map<List<GetVehiculoOutput>>(getAll);
            return output;
        }

        public void Update(UpdateVehiculoInput input)
        {
            Vehiculo output = _objectMapper.Map<Vehiculo>(input);
            _vehiculoManager.Update(output);
        }
    }
}
