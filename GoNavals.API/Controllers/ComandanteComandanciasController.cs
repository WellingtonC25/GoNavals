using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GoNavals.Domain;
using GoNavals.API.Services.ComandanteComandancia;

namespace GoNavals.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComandanteComandanciasController : ControllerBase
    {
        private readonly IComandanteComandanciaService _comandanteComandancia;

        public ComandanteComandanciasController(IComandanteComandanciaService comandanteComandancia)
        {
            _comandanteComandancia = comandanteComandancia;
        }

        // GET: api/ComandanteComandancias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ComandanteComandancia>>> GetAllComandanteComandancias()
        {
            return Ok(await _comandanteComandancia.GetAllComandanteComandancias());

        }

        // GET: api/ComandanteComandancias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ComandanteComandancia>> GetComandanteComandancia(int id)
        {
            var comandanteComandancia = await _comandanteComandancia.GetSingleComandanteComandancia(id);

            if (comandanteComandancia is null)
                return NotFound("Este articulo no existe.");

            return Ok(comandanteComandancia);
        }

        // PUT: api/ComandanteComandancias/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutComandanteComandancia(int id, ComandanteComandancia comandanteComandancia)
        {
            var comandanteComandanciaResult = await _comandanteComandancia.UpdateComandanteComandancia(id, comandanteComandancia);

            if (comandanteComandanciaResult is null)
                return NotFound("Este articulo no existe");

            return Ok(comandanteComandanciaResult);

        }

        // POST: api/ComandanteComandancias
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ComandanteComandancia>> PostComandanteComandancia(ComandanteComandancia comandanteComandancia)
        {
            var comandanteComandiaResult = await _comandanteComandancia.AddComandanteComandancia(comandanteComandancia);

            if (comandanteComandiaResult is null)
                return NotFound("Este articulo no existe");

            return Ok(comandanteComandiaResult);
        }

        // DELETE: api/ComandanteComandancias/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComandanteComandancia(int id)
        {
            var comandanteComandiaResult = await _comandanteComandancia.DeleteComandanteComandancia(id);

            if (comandanteComandiaResult is null)
                return NotFound("Este articulo no existe");

            return Ok(comandanteComandiaResult);
        }
    }
}
