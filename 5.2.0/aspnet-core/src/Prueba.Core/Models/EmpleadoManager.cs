using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Models
{
    public class EmpleadoManager:DomainService,IEmpleadoManager
    {
        private readonly IRepository<Empleado> _repositoryEmpleado;
        public EmpleadoManager(IRepository<Empleado> repositoryEmpleado)
        {
            _repositoryEmpleado = repositoryEmpleado;
        }

        public async Task<Empleado> Create(Empleado entity)
        {
            var Empleado = _repositoryEmpleado.FirstOrDefault(x => x.Id == entity.Id);
            if (Empleado != null)
            {
                throw new UserFriendlyException("Ya existe");
            }
            else
            {
                return await _repositoryEmpleado.InsertAsync(entity);

            }
        }

        public void Delete(int Id)
        {
            var empleado = _repositoryEmpleado.FirstOrDefault(x => x.Id == Id);
            if (empleado != null)
            {
                throw new UserFriendlyException("No encontrado");
            }
            else
            {
                _repositoryEmpleado.Delete(empleado);
            }
        }

        public IEnumerable<Empleado> GetAllList()
        {
            throw new NotImplementedException();
        }

        public Empleado GetEmpleadoById(int Id)
        {
            return _repositoryEmpleado.Get(Id);
        }

        public void Update(Empleado entity)
        {
            _repositoryEmpleado.Update(entity);
        }
    }
}
