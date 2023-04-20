using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GoNavals.Domain;
using GoNavals.Core;
using GoNavals.Core.Interfaces;

namespace GoNavals.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComandanciasController : ControllerBase
    {
        private readonly IComandanciaService _comandancia;

        public ComandanciasController(IComandanciaService comandancia)
        {
            _comandancia = comandancia;
        }

        // GET: api/Comandancias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Comandancia>>> GetComandancia()
        {
            return Ok(await _comandancia.GetAllComandancias()); 
        }

        // GET: api/Comandancias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Comandancia>> GetComandancia(int id)
        {
            var comandancia = await _comandancia.GetSingleComandancia(id);

            if (comandancia == null)
            {
                return NotFound();
            }

            return Ok(comandancia);
        }

        // PUT: api/Comandancias/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutComandancia(int id, Comandancia comandancia)
        {
            var comandanciaResult = await _comandancia.UpdateComandancia(id, comandancia);

            if (comandanciaResult is null)

                return NotFound("Esta comandancia no existe");

            return Ok(comandanciaResult);
        }

        // POST: api/Comandancias
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Comandancia>> PostComandancia(Comandancia comandancia)
        {
            var comandanciaResult = await _comandancia.AddComandancia(comandancia);

            if (comandanciaResult == null)
            {
                return NotFound("Esta comandancia no existe o es vacia");
            }
            return Ok(comandanciaResult);
        }

        // DELETE: api/Comandancias/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComandancia(int id)
        {
            var comandciaResult = await _comandancia.DeleteComandancia(id);

            if (comandciaResult == null)
            {
                return NotFound("Esta comandancia no existe");
            }
            return Ok(comandciaResult);
        }

    }
}
