using GoNavals.API.Services.Constructora;
using GoNavals.Domain;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GoNavals.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConstructorasController : ControllerBase
    {
        private readonly IConstructoraService _constructoraService;

        public ConstructorasController(IConstructoraService constructoraService)
        {
            _constructoraService = constructoraService;
        }
        // GET: api/<ConstructorasController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Domain.Constructora>>> GetConstructoras()
        {
            return Ok(await _constructoraService.GetAllConstructoras());
        }

        // GET api/<ConstructorasController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Domain.Constructora>> GetConstructora(int id)
        {
            var constructora = await _constructoraService.GetSingleConstructora(id);

            if (constructora is null)
                return NotFound("Esta constructora no existe");

            return Ok(constructora);
        }

        // POST api/<ConstructorasController>
        [HttpPost]
        public async Task<ActionResult<Domain.Constructora>> PostConstructora(Domain.Constructora constructora)
        {
            var constructoraResult = await _constructoraService.AddConstructora(constructora);

            if (constructoraResult is null)
                return NotFound("Esta constructora no existe");

            return constructoraResult;
        }

        // PUT api/<ConstructorasController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Domain.Constructora>> PutConstructora(int id, Domain.Constructora constructora)
        {
            var constructoraResult = await _constructoraService.UpdateConstructora(id, constructora);

            if (constructoraResult is null)
                return NotFound("Esta constructora no existe");

            return constructoraResult;

        }

        // DELETE api/<ConstructorasController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Domain.Constructora>> Delete(int id)
        {
            var constructora = await _constructoraService.DeleteConstructora(id);

            if (constructora is null)
                return NotFound("Esta constructora no existe");

            return constructora;
        }
    }
}
