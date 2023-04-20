using GoNavals.Core;
using GoNavals.Core.Interfaces;
using GoNavals.Domain;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GoNavals.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CiudadController : ControllerBase
    {
        private readonly ICiudadService _ciudad;

        public CiudadController(ICiudadService ciudad)
        {
            _ciudad = ciudad;
        }

        // GET: api/<CiudadController>
        [HttpGet]
        public async Task<ActionResult<List<Ciudad>>> GetAllCiudades()
        {
            return Ok( await _ciudad.GetAllCiudades()) ;
        }

        // GET api/<CiudadController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ciudad>> GetSingleCiudad(int id)
        {
           var ciudad = await _ciudad.GetSingleCiudad(id);
            
            if(ciudad is null)
                return NotFound("Esta ciudad no existe");
            
            return Ok(ciudad) ;
        }

        // POST api/<CiudadController>
        [HttpPost]
        public async Task<ActionResult<List<Ciudad>>> AddCiudad(Ciudad ciudadParameter)
        {
            var ciudad = await _ciudad.AddCiudad(ciudadParameter);
            if (ciudad is null)

                return NotFound("Esta ciudad no existe");

            return Ok(ciudad);
        }

        // PUT api/<CiudadController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<List<Ciudad>>> UpdateCiudad( int id, Ciudad requestCiudad)
        {
            var ciudad = await _ciudad.UpdateCiudad(id, requestCiudad);

            if (ciudad is null)
                return NotFound("Esta ciudad no existe");

            return Ok(ciudad);
        }

        // DELETE api/<CiudadController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Ciudad>>> DeleteCiudad(int id)
        {
            var ciudad = await _ciudad.DeleteCiudad(id);

            if (ciudad is null)
                return NotFound("Esta ciudad no existe");

            return Ok(ciudad);
        }
    }
}
