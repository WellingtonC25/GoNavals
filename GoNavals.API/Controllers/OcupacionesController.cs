using GoNavals.Core;
using GoNavals.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GoNavals.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OcupacionesController : ControllerBase
    {
        private readonly IOcupacionService _ocupacionService;

        public OcupacionesController( IOcupacionService ocupacionService)
        {
            _ocupacionService = ocupacionService;
        }

        // GET: api/<OcupacionesController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Domain.Ocupacion>>> GetOcupaciones()
        {
            return Ok(await _ocupacionService.GetAllOcupaciones());
        }

        // GET api/<OcupacionesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Domain.Ocupacion>> GetEmbarcacion(int id)
        {
            var ocupacion = await _ocupacionService.GetSingleOcupacion(id);

            if (ocupacion is null)
                return NotFound("Esta ocupacion no existe");

            return ocupacion;
        }

        // POST api/<OcupacionesController>
        [HttpPost]
        public async Task<ActionResult<Domain.Ocupacion>> PostEmbarcacion(Domain.Ocupacion ocupacion)
        {
            var ocupacionResult = await _ocupacionService.AddOcupacion(ocupacion);

            if (ocupacionResult is null)
                return NotFound("Esta ocupacion no existe");

            return Ok( ocupacionResult);
        }

        // PUT api/<OcupacionesController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Domain.Ocupacion>>  PutEmbarcacion(int id, Domain.Ocupacion ocupacion)
        {
            var ocupacionResult = await _ocupacionService.UpdateOcupacion(id, ocupacion);

            if (ocupacionResult is null)
                return NotFound("Esta ocupacion no existe");

            return Ok(ocupacionResult);
        }

        // DELETE api/<OcupacionesController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Domain.Ocupacion>> DeleteEmbarcacion(int id)
        {
            var ocupacion= await _ocupacionService.DeleteOcupacion(id);

            if (ocupacion is null)
                return NotFound("Esta ocupacion no existe");

            return Ok(ocupacion);
        }
    }
}
