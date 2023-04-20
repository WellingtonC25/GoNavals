using GoNavals.Core;
using GoNavals.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GoNavals.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZonasController : ControllerBase
    {
        private readonly IZonaService _zonaService;

        public ZonasController(IZonaService zonaService)
        {
            _zonaService = zonaService;
        }
        // GET: api/<ZonasController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Domain.Zona>>> GetZonas()
        {
            return Ok(await _zonaService.GetAllZonas());
        }

        // GET api/<ZonasController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Domain.Zona>> GetZona(int id)
        {
            var zona = await _zonaService.GetSingleZona(id);

            if (zona is null)
                return NotFound("Esta zona no existe");

            return Ok(zona);
        }

        // POST api/<ZonasController>
        [HttpPost]
        public async Task<ActionResult<Domain.Zona>> PostZona(Domain.Zona zona)
        {
            var zonaResult = await _zonaService.AddZona(zona);

            if (zonaResult is null)
                return NotFound("Esta zona no existe");

            return Ok(zonaResult);
        }

        // PUT api/<ZonasController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Domain.Zona>> PutZona(int id, Domain.Zona zona)
        {
            var zonaResult = await _zonaService.UpdateZona(id, zona);

            if (zonaResult is null)
                return NotFound("Esta zona no existe");

            return Ok(zonaResult);
        }

        // DELETE api/<ZonasController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Domain.Zona>> DeleteZona(int id)
        {
            var zona = await _zonaService.DeleteZona(id);

            if (zona is null)
                return NotFound("Esta zona no existe");

            return Ok(zona);
        }
    }
}
