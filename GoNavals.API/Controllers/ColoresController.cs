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
    public class ColoresController : ControllerBase
    {
        private readonly IColorService _color;

        public ColoresController(IColorService color)
        {
            _color = color;
        }

        // GET: api/Colores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Color>>> GetAllColores()
        {
            return Ok(await _color.GetAllColores());
        }

        // GET: api/Colores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Color>> GetColor(int id)
        {
            var color = await _color.GetSingleColor(id);
            return Ok(color);
        }

        // PUT: api/Colores/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutColor(int id, Color color)
        {
            var colorToUpdate = await _color.UpdateColor(id, color);

            if (colorToUpdate is null)
                return NotFound("Este color no existe");

            return Ok(colorToUpdate);
        }

        // POST: api/Colores
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Color>> PostColor(Color color)
        {
          var colorToPost = await _color.AddColor(color);
            return Ok(colorToPost);
        }

        // DELETE: api/Colores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteColor(int id)
        {
            var colorToDelete = await _color.DeleteColor(id);

            if (colorToDelete == null)
            {
                return NotFound("Este color no existe");
            }
            return Ok(colorToDelete);
        }
    }
}
