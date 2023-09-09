using Microsoft.AspNetCore.Mvc;
using Data.Repositorio;
using Modelo;

namespace Aseguradora.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ventasController : ControllerBase
    {
        public readonly iventasRepository _ventasRepository;

        public ventasController(iventasRepository ventasRepository)
        {
            _ventasRepository = ventasRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetVentas()
        {
            return Ok(await _ventasRepository.getVentas());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetVentasbyID(int id)
        {
            return Ok(await _ventasRepository.getVentasByID(id));
        }

        [HttpPost]
        public async Task<IActionResult> InsertVenta([FromBody] ventas ventas)
        {
            if (ventas == null)
            {
                return BadRequest();
            }

            var created = await _ventasRepository.insertVentas(ventas);
            return Ok(created);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateViaje([FromBody] ventas ventas)
        {
            if (ventas == null)
            {
                return BadRequest();
            }

            var update = await _ventasRepository.updateVentas(ventas);
            return Ok(update);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteVentasByID(int id)
        {
            return Ok(await _ventasRepository.deleteVenta(id));
        }

    }
}
