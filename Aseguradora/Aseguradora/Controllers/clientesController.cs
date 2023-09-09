using Data.Repositorio;
using Microsoft.AspNetCore.Mvc;
using Modelo;


namespace Aseguradora.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        public readonly iclientesRepository _clienteRepsitory;
        public ClienteController(iclientesRepository clienteRepsitory)
        {
            _clienteRepsitory = clienteRepsitory;
        }
        [HttpGet]
        public async Task<IActionResult> getClientes()
        {
            return Ok(await _clienteRepsitory.getClientes());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> getClienteById(int id)
        {
            return Ok(await _clienteRepsitory.getClienteById(id));
        }
        [HttpPost]
        public async Task<IActionResult> InsertCliente([FromBody] clientes cliente)
        {
            if (cliente == null)
            {
                return BadRequest();
            }
 
            var created = await _clienteRepsitory.insertCliente(cliente);
            return Ok(created);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCliente([FromBody] clientes cliente)
        {
            if (cliente == null)
            {
                return BadRequest();
            }
            
            var update = await _clienteRepsitory.updateCliente(cliente);
            return Ok(update);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteCLienteById(int id)
        {
            return Ok(await _clienteRepsitory.deleteCliente(id));
        }
    }
}
