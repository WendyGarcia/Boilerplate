using Abp.Application.Services;
using Abp.ObjectMapping;
using Prueba.Empleados.DTO;
using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task Create(CreateEmpleadoInput input)
        {            
            var Empleado = _objectMapper.Map<Empleado>(input);
            await _empleadoManager.Create(Empleado);
        }

        public void Delete(DeleteEmpleadoInput input)
        {
            _empleadoManager.Delete(input.Id);
        }

        public GetEmpleadoOutput GetEmpleadoById(GetEmpleadoInput input)
        {
            var getEmpleado = _empleadoManager.GetEmpleadoById(input.Id);
           GetEmpleadoOutput output = _objectMapper.Map<GetEmpleadoOutput>(getEmpleado);
            return output;
        }

        public IEnumerable<GetEmpleadoOutput> ListAll()
        {
            var getAll = _empleadoManager.GetAllList().ToList();
            List<GetEmpleadoOutput> output = _objectMapper.Map<List<GetEmpleadoOutput>>(getAll);
            return output;
        }

        public void Update(UpdateEmpleadoInput input)
        {
            Empleado output = _objectMapper.Map<Empleado>(input);
            _empleadoManager.Update(output); 
        }
    }
    
}
