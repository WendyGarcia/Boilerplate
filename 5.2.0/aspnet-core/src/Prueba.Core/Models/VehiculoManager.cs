using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Models
{
    public class VehiculoManager:DomainService, IVehiculoManager
    {
        private readonly IRepository<Vehiculo> _repositoryVehiculo;
        public VehiculoManager(IRepository<Vehiculo> repositoryVehiculo)
        {
            _repositoryVehiculo = repositoryVehiculo;
        }

        public async Task<Vehiculo> Create(Vehiculo entity)
        {
            var vehiculo = _repositoryVehiculo.FirstOrDefault(x => x.Id == entity.Id);
            if (vehiculo != null)
            {
                throw new UserFriendlyException("Ya existe");
            }
            else
            {
                return await _repositoryVehiculo.InsertAsync(entity);

            }
        }

        public void Delete(int Id)
        {
            var vehiculo = _repositoryVehiculo.FirstOrDefault(x => x.Id == Id);
            if (vehiculo != null)
            {
                throw new UserFriendlyException("No encontrado");
            }
            else
            {
                _repositoryVehiculo.Delete(vehiculo);
            }

        }

        public IEnumerable<Vehiculo> GetAllList()
        {
            return _repositoryVehiculo.GetAll();
        }

        public Vehiculo GetVehiculoById(int Id)
        {
            return _repositoryVehiculo.Get(Id);
        }

        public void Update(Vehiculo entity)
        {
            _repositoryVehiculo.Update(entity);
        }
    }
}
