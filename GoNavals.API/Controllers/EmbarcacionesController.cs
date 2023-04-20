using GoNavals.Core;
using GoNavals.Core.Interfaces;
using GoNavals.Domain;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GoNavals.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmbarcacionesController : ControllerBase
    {
        private readonly IEmbarcacionService _embarcacionService;

        public EmbarcacionesController(IEmbarcacionService embarcacionService)
        {
            _embarcacionService = embarcacionService;
        }

        // GET: api/<EmbarcacionesController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Domain.Embarcacion>>> GetEmbarcaciones()
        {
            return Ok(await _embarcacionService.GetAllEmbarcaciones());
        }

        // GET api/<EmbarcacionesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Domain.Embarcacion>> GetEmbarcacion(int id)
        {
            var embarcacion = await _embarcacionService.GetSingleEmbarcacion(id);

            if (embarcacion is null)
                return NotFound("Esta embarcacion no existe");

            return Ok(embarcacion);
        }

        // POST api/<EmbarcacionesController>
        [HttpPost]
        public async Task<ActionResult<Domain.Embarcacion>> PostEmbarcacion(Domain.Embarcacion embarcacion)
        {

            var embarcacionResult = await _embarcacionService.AddEmbarcacion(embarcacion);

            if (embarcacionResult is null)
                return NotFound("Esta embarcacion no existe");

            return Ok(embarcacionResult);
        }

        // PUT api/<EmbarcacionesController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Domain.Embarcacion>> PutEmbarcacion(int id, Domain.Embarcacion embarcacion)
        {
            var embarcacionResult = await _embarcacionService.UpdateEmbarcacion(id,embarcacion);

            if (embarcacionResult is null)
                return NotFound("Esta embarcacion no existe");

            return Ok(embarcacionResult);
        }

        // DELETE api/<EmbarcacionesController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Domain.Embarcacion>> DeleteEmbarcacion(int id)
        {
            var embarcacionResult = await _embarcacionService.DeleteEmbarcacion(id);

            if (embarcacionResult is null)
                return NotFound("Esta embarcacion no existe");

            return Ok(embarcacionResult);
        }
    }
}
