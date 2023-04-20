using GoNavals.Core;
using GoNavals.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GoNavals.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoUsosController : ControllerBase
    {
        private readonly ITipoUsoService _tipoUsoService;

        public TipoUsosController(ITipoUsoService tipoUsoService)
        {
           _tipoUsoService = tipoUsoService;
        }
        // GET: api/<TipoUsosController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Domain.TipoUso>>> GetTipoUsos()
        {
            return Ok(await _tipoUsoService.GetAllTipoUsos());
        }

        // GET api/<TipoUsosController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Domain.TipoUso>> GetTipoUso(int id)
        {
            var tipoUso = await _tipoUsoService.GetSingleTipoUso(id);

            if (tipoUso is null)
                return NotFound("Este tipo de uso no existe");

            return Ok(tipoUso);
        }

        // POST api/<TipoUsosController>
        [HttpPost]
        public async Task<ActionResult<Domain.TipoUso>> PostTipoUso(Domain.TipoUso tipoUso)
        {
            var tipoUsoResult = await _tipoUsoService.AddTipoUso(tipoUso);

            if (tipoUsoResult is null)
                return NotFound("Este tipo de uso no existe");

            return Ok(tipoUsoResult);
        }

        // PUT api/<TipoUsosController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Domain.TipoUso>> PutTipoUso(int id, Domain.TipoUso tipoUso)
        {
            var tipoUsoResult = await _tipoUsoService.UpdateTipoUso(id, tipoUso);

            if (tipoUsoResult is null)
                return NotFound("Este tipo de uso no existe");

            return Ok(tipoUsoResult);
        }

        // DELETE api/<TipoUsosController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Domain.TipoUso>> DeleteTipoUso(int id)
        {
            var tipoUso = await _tipoUsoService.DeleteTipoUso(id);

            if (tipoUso is null)
                return NotFound("Este tipo de uso no existe");

            return Ok(tipoUso);
        }
    }
}
