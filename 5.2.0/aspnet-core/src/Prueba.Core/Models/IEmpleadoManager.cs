using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Models
{
    public interface IEmpleadoManager : IDomainService
    {
        IEnumerable<Empleado> GetAllList();
        Empleado GetEmpleadoById(int Id);
        Task<Empleado> Create(Empleado entity);
        void Update(Empleado entity);
        void Delete(int Id);



    }
}
