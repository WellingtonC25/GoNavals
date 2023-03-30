using GoNavals.API.Services.Comandante;
using GoNavals.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GoNavals.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComandantesController : ControllerBase
    {
        private readonly IComandanteService _comandanteService;

        public ComandantesController(IComandanteService comandanteService)
        {
            _comandanteService = comandanteService;
        }
        // GET: api/<ComandantesController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Domain.Comandante>>> Get()
        {
            return Ok(await _comandanteService.GetAllComandantes());
        }

        // GET api/<ComandantesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Domain.Comandante>> GetComandante(int id)
        {
            return Ok(await _comandanteService.GetSingleComandante(id));
        }

        // POST api/<ComandantesController>
        [HttpPost]
        public async Task<ActionResult<Domain.Comandante>> Post(Domain.Comandante comandante)
        {
           var comandanteResult = await _comandanteService.AddComandante(comandante);

            if (comandanteResult is null)
                return NotFound("Este comandante no se encuentra en la lista.");

            return Ok(comandanteResult);
        }

        // PUT api/<ComandantesController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Domain.Comandante>> Put(int id, Domain.Comandante comandante)
        {
            var comandanteResult = await _comandanteService.UpdateComandante(id, comandante);

            if (comandanteResult is null)
                return NotFound("Este comandante no se encuentra en la lista.");

            return Ok(comandanteResult);
        }

        // DELETE api/<ComandantesController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Domain.Comandante>> Delete(int id)
        {
            var comandante = await _comandanteService.DeleteComandante(id);

            if (comandante is null)
                return NotFound("Este comandante no se encuentra en la lista.");

            return Ok(comandante);
        }
    }
}
