using GoNavals.Core;
using GoNavals.Core.Interfaces;
using GoNavals.Domain;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GoNavals.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaisesController : ControllerBase
    {
        private readonly IPaisService _paisService;

        public PaisesController(IPaisService paisService)
        {
            _paisService = paisService;
        }
        // GET: api/<PaisesController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Domain.Pais>>> GetPaises()
        {
           return Ok(await _paisService.GetAllPaises());
        }

        // GET api/<PaisesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Domain.Pais>> GetPais(int id)
        {
            var pais = await _paisService.GetSinglePais(id);

            if (pais is null)
                return NotFound("Este pais no existe");

            return Ok(pais);
        }

        // POST api/<PaisesController>
        [HttpPost]
        public async Task<ActionResult<Domain.Pais>> PostPais(Domain.Pais pais)
        {
            var paisResult = await _paisService.AddPais(pais);

            if (paisResult is null)
                return NotFound("Este pais no existe");

            return Ok(paisResult);
        }

        // PUT api/<PaisesController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Domain.Pais>> EditPais([FromRoute]  int id,[FromBody] Domain.Pais pais)
        {
            var paisResult = await _paisService.UpdatePais(id, pais);

            if (paisResult is null)
                return NotFound("Este pais no existe");

            return Ok(paisResult);
        }

        // DELETE api/<PaisesController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Domain.Pais>> DeletePais(int id)
        {
            var paisResult = await _paisService.DeletePais(id);

            if (paisResult is null)
                return NotFound("Este pais no existe");

            return Ok(paisResult);
        }
    }
}
