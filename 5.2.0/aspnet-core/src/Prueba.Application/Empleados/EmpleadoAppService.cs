using Abp.Application.Services;
using Abp.ObjectMapping;
using Prueba.Empleados.DTO;
using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Empleados
{
    public class EmpleadoAppService:ApplicationService, IEmpleadoAppService
    {
        private readonly IObjectMapper _objectMapper;
        private readonly IEmpleadoManager _empleadoManager;
        public EmpleadoAppService(IEmpleadoManager empleadoManager, IObjectMapper objectMapper)
        {
            _empleadoManager = empleadoManager;
            _objectMapper = objectMapper;
        }

        public void Create(CreateEmpleadoInput input)
        {            
            var Empleado = _objectMapper.Map<Empleado>(input);
            _empleadoManager.Create(Empleado);
        }

        public void Delete(DeleteEmpleadoInput input)
        {
            _empleadoManager.Delete(input.Id);
        }

        public GetEmpleadoOutput GetEmpleadoById(GetEmpleadoInput input)
        {
            var getEmpleado = _empleadoManager.GetEmpleadoById(input.Id);
            GetEmpleadoOutput output = Mapper.Map<Empleados, GetEmpleadoOutput>(getEmpleado);
            return output;
        }

        public IEnumerable<GetEmpleadoOutput> ListAll()
        {
            throw new NotImplementedException();
        }

        public void Update(UpdateEmpleadoInput input)
        {
            throw new NotImplementedException();
        }
    }
    
}
