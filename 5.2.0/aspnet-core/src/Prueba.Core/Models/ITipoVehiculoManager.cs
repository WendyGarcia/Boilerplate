using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Models
{
    public interface ITipoVehiculoManager:IDomainService
    {
        IEnumerable<TipoVehiculo> GetAllList();
        TipoVehiculo GetTipoVehiculoById(int Id);
        Task<TipoVehiculo> Create(TipoVehiculo entity);
        void Update(TipoVehiculo entity);
        void Delete(int Id);
    }
}
