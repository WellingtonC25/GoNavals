using GoNavals.Core;
using GoNavals.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GoNavals.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RangosController : ControllerBase
    {
        private readonly IRangoService _rangoService;

        public RangosController(IRangoService rangoService)
        {
            _rangoService = rangoService;
        }
        // GET: api/<RangosController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Domain.Rango>>> GetRangos()
        {
            return Ok(await _rangoService.GetAllRangos());
        }

        // GET api/<RangosController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Domain.Rango>> GetRango(int id)
        {
            var rango = await _rangoService.GetSingleRango(id);

            if (rango is null)
                return NotFound("Este rango no se existe");

            return Ok(rango);
        }

        // POST api/<RangosController>
        [HttpPost]
        public async Task<ActionResult<Domain.Rango>> PostRango(Domain.Rango rango)
        {
            var rangoResult = await _rangoService.AddRango(rango);

            if (rangoResult is null)
                return NotFound("Este rango no se existe");

            return Ok(rangoResult);
        }

        // PUT api/<RangosController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Domain.Rango>> PutRango(int id,Domain.Rango rango)
        {
            var rangoResult = await _rangoService.UpdateRango(id, rango);

            if (rangoResult is null)
                return NotFound("Este rango no se existe");

            return Ok(rangoResult);
        }

        // DELETE api/<RangosController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Domain.Rango>> DeleteRango(int id)
        {
            var rango = await _rangoService.DeleteRango(id);

            if (rango is null)
                return NotFound("Este rango no se existe");

            return Ok(rango);
        }
    }
}
