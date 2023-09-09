using Microsoft.AspNetCore.Mvc;
using Modelo;
using Data.Repositorio;

namespace Aseguradora.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        public readonly iempleadosRepository _empleadosRepository;

        public EmpleadoController(iempleadosRepository empleadosRepository)
        {
            _empleadosRepository = empleadosRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetEmpleados()
        {
            return Ok(await _empleadosRepository.getEmpleados());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmpleadosById(int id)
        {
            return Ok(await _empleadosRepository.getEmpleadosbyID(id));
        }

        [HttpPost]
        public async Task<IActionResult> insertEmpleado([FromBody] empleados empleados)
        {
            if (empleados == null)
            {
                return BadRequest();
            }
 
            var created = await _empleadosRepository.insertEmpleado(empleados);
            return Ok(created);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateEmpleado([FromBody] empleados empleados)
        {
            if (empleados == null)
            {
                return BadRequest();
            }

            var update = await _empleadosRepository.updateEmpleado(empleados);
            return Ok(update);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteEmpleadoById(int id)
        {
            return Ok(await _empleadosRepository.deleteEmpleado(id));
        }
    }
}
