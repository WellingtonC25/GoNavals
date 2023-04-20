using GoNavals.Core;
using GoNavals.Core.Interfaces;
using GoNavals.Domain;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GoNavals.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PuertosController : ControllerBase
    {
        private readonly IPuertoService _puertoService;

        public PuertosController(IPuertoService puertoService)
        {
            _puertoService = puertoService;
        }
        // GET: api/<PuertosController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Domain.Puerto>>> GetPuertos()
        {
            return Ok(await _puertoService.GetAllPuertos());

        }

        // GET api/<PuertosController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Domain.Puerto>> GetPuerto(int id)
        {
            var puerto = await _puertoService.GetSinglePuerto(id);

            if (puerto is null)
                return NotFound("Este puerto no existe");

            return Ok(puerto);
        }

        // POST api/<PuertosController>
        [HttpPost]
        public async Task<ActionResult<Domain.Puerto>> AddPuerto(Domain.Puerto puerto)
        {
            var puertoResult = await _puertoService.AddPuerto(puerto);

            if (puertoResult is null)
                return NotFound("Este puerto no existe");

            return Ok(puertoResult);
        }

        // PUT api/<PuertosController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Domain.Puerto>> UpdatePuerto(int id, Domain.Puerto puerto)
        {
            var puertoResult = await _puertoService.UpdatePuerto(id,puerto);

            if (puertoResult is null)
                return NotFound("Este puerto no existe");

            return Ok(puertoResult);
        }

        // DELETE api/<PuertosController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Domain.Puerto>> DeletePuerto(int id)
        {
            var puerto = await _puertoService.DeletePuerto(id);

            if (puerto is null)
                return NotFound("Este puerto no existe");

            return Ok(puerto);
        }
    }
}
