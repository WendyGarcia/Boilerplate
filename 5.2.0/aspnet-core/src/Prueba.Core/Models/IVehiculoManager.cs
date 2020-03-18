using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Models
{
    public interface IVehiculoManager:IDomainService
    {
        IEnumerable<Vehiculo> GetAllList();
        Vehiculo GetVehiculoById(int Id);
        Task<Vehiculo> Create(Vehiculo entity);
        void Update(Vehiculo entity);
        void Delete(int Id);

    }
}
