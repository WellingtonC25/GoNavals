using GoNavals.Core;
using GoNavals.Core.Interfaces;
using GoNavals.Domain;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GoNavals.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CursosController : ControllerBase
    {
        private readonly ICursoService _cursoService;

        public CursosController( ICursoService cursoService)
        {
            _cursoService = cursoService;
        }

        // GET: api/<CursosController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Domain.Curso>>> GetCursos()
        {
            var cursos = await _cursoService.GetAllCursos();

            if (cursos is null)
                return NotFound("Este curso no existe");

            return Ok(cursos);
        }

        // GET api/<CursosController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Domain.Curso>> GetCurso(int id)
        {
            var curso = await _cursoService.GetSingleCurso(id);

            if (curso is null)
                return NotFound("Este curso no existe");

            return Ok(curso);
        }

        // POST api/<CursosController>
        [HttpPost]
        public async Task<ActionResult<Domain.Curso>> Post(Domain.Curso curso)
        {
            var cursoResult = await _cursoService.AddCurso(curso);

            if (cursoResult is null)
                return NotFound("Este curso no existe");

            return Ok(cursoResult);
        }

        // PUT api/<CursosController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Domain.Curso>> Put(int id, Domain.Curso curso)
        {
            var cursoResult = await _cursoService.UpdateCurso(id,curso);

            if (cursoResult is null)
                return NotFound("Este curso no existe");

            return Ok(cursoResult);

        }

        // DELETE api/<CursosController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Domain.Curso>> Delete(int id)
        {
            var curso = await _cursoService.DeleteCurso(id);

            if (curso is null)
                return NotFound("Este curso no existe");

            return Ok(curso);
        }
    }
}
