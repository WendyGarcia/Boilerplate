using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;

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
