using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Models
{
    class TipoVehiculoManager:DomainService,ITipoVehiculoManager
    {
        private readonly IRepository<TipoVehiculo> _repositoryTipoVehiculo;
        public TipoVehiculoManager(IRepository<TipoVehiculo> repositoryTipoVehiculo)
        {
            _repositoryTipoVehiculo = repositoryTipoVehiculo;
        }

        public async Task<TipoVehiculo> Create(TipoVehiculo entity)
        {
            var tipovehiculo = _repositoryTipoVehiculo.FirstOrDefault(x => x.Id == entity.Id);
            if (tipovehiculo != null)
            {
                throw new UserFriendlyException("Ya existe");
            }
            else
            {
                return await _repositoryTipoVehiculo.InsertAsync(entity);

            }
        }   

        public void Delete(int Id)
        {
            var tipovehiculo = _repositoryTipoVehiculo.FirstOrDefault(x => x.Id == Id);
            if (tipovehiculo != null)
            {
                throw new UserFriendlyException("No encontrado");
            }
            else
            {
                _repositoryTipoVehiculo.Delete(tipovehiculo);
            }
        }

        public IEnumerable<TipoVehiculo> GetAllList()
        {
            return _repositoryTipoVehiculo.GetAll();
        }

        public TipoVehiculo GetTipoVehiculoById(int Id)
        {
            return _repositoryTipoVehiculo.Get(Id);
        }

        public void Update(TipoVehiculo entity)
        {
            _repositoryTipoVehiculo.Update(entity);
        }
    }
}
