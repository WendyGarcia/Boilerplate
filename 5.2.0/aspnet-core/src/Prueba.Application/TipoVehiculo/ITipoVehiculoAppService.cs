using Abp.Application.Services;
using Prueba.TipoVehiculo.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.TipoVehiculo
{
    public interface ITipoVehiculoAppService:IApplicationService
    {
        IEnumerable<GetTipoVehiculoOutput> ListAll();
        Task Create(CreateTipoVehiculoInput input);
        void Update(UpdateTipoVehiculoInput input);
        void Delete(DeleteTipoVehiculoInput input);

        GetTipoVehiculoOutput GetVehiculoById(GetTipoVehiculoInput input);
    }
}
