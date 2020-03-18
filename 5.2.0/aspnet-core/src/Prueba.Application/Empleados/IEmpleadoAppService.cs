using Abp.Application.Services;
using Prueba.Empleados.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Empleados
{
    interface IEmpleadoAppService:IApplicationService
    {
        IEnumerable<GetEmpleadoOutput> ListAll();
        Task Create(CreateEmpleadoInput input);
        void Update(UpdateEmpleadoInput input);
        void Delete(DeleteEmpleadoInput input);

        GetEmpleadoOutput GetEmpleadoById(GetEmpleadoInput input);

    }
}
