using Microsoft.AspNetCore.Mvc;
using Modelo;
using Data.Repositorio;

namespace Aseguradora.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConductorController : ControllerBase
    {
        public readonly iempleadosRepository _empleadosRepository;

        public ConductorController(iempleadosRepository empleadosRepository)
        {
            _empleadosRepository = empleadosRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetConductores()
        {
            return Ok(await _empleadosRepository.getEmpleados());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetConductorById(int id)
        {
            return Ok(await _empleadosRepository.getEmpleadosbyID(id));
        }

        [HttpPost]
        public async Task<IActionResult> insertConductor([FromBody] empleados empleados)
        {
            if (empleados == null)
            {
                return BadRequest();
            }
            if (ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var created = await _empleadosRepository.insertEmpleado(empleados);
            return Ok(created);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateConductor([FromBody] empleados empleados)
        {
            if (empleados == null)
            {
                return BadRequest();
            }
            if (ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var update = await _empleadosRepository.updateEmpleado(empleados);
            return Ok(update);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteConductorById(int id)
        {
            return Ok(await _empleadosRepository.deleteEmpleado(id));
        }
    }
}
