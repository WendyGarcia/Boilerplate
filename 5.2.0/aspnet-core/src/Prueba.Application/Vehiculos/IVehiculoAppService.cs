using Abp.Application.Services;
using Prueba.Vehiculos.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Empleados.DTO
{
    public interface IVehiculoAppService:IApplicationService
    {
        IEnumerable<GetVehiculoOutput> ListAll();
        Task Create(CreateVehiculoInput input);
        void Update(UpdateVehiculoInput input);
        void Delete(DeleteVehiculoInput input);

        GetVehiculoOutput GetVehiculoById(GetVehiculoInput input);
    }
}
