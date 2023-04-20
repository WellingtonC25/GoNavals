using GoNavals.Core;
using GoNavals.Core.Interfaces;
using GoNavals.Domain;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GoNavals.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropietariosController : ControllerBase
    {
        private readonly IPropietarioService _propietarioService;

        public PropietariosController(IPropietarioService propietarioService)
        {
            _propietarioService = propietarioService;
        }

        // GET: api/<PropietariosController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Domain.Propietario>>> GetPropietarios()
        {
            return Ok(await _propietarioService.GetAllPropietarios());
        }

        // GET api/<PropietariosController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Domain.Propietario>> GetPropietario(int id)
        {
            var propietario = await _propietarioService.GetSinglePropietario(id);

            if (propietario is null)
                return NotFound("Este propietario no existe");

            return Ok(propietario);
        }

        // POST api/<PropietariosController>
        [HttpPost]
        public async Task<ActionResult<Domain.Propietario>> PostPropietario(Domain.Propietario propietario)
        {
            var propietarioResult = await _propietarioService.AddPropietario(propietario);

            if (propietarioResult is null)
                return NotFound("Este propietario no existe");

            return Ok(propietarioResult);
        }

        // PUT api/<PropietariosController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Domain.Propietario>> PutPropietario(int id, Domain.Propietario propietario)
        {
            var propietarioResult = await _propietarioService.UpdatePropietario(id, propietario);

            if (propietarioResult is null)
                return NotFound("Este propietario no existe");

            return Ok(propietarioResult);
        }
        [HttpDelete("{id}")]
        // DELETE api/<PropietariosController>/5
        public async Task<ActionResult<Domain.Propietario>> DeletePropietario(int id)
        {
            var propietarioResult = await _propietarioService.DeletePropietario(id);

            if (propietarioResult is null)
                return NotFound("Este propietario no existe");

            return Ok(propietarioResult);
        }
    }
}
