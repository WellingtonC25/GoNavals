using GoNavals.Core;
using GoNavals.Core.Interfaces;
using GoNavals.Domain;
using Microsoft.EntityFrameworkCore;

namespace GoNavals.BusinessLogic.Services.Ciudad
{
    public class CiudadService : ICiudadService
    {
        private readonly Domain.DataContext _dbContext;
        List<GoNavals.Domain.Ciudad>  ciudades = new List<GoNavals.Domain.Ciudad>();
        List<GoNavals.Domain.Pais>  paises = new List<GoNavals.Domain.Pais>();

        //Subir cambios a GitHub

        public CiudadService(Domain.DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Domain.Ciudad?> AddCiudad(Domain.Ciudad ciudad)
        {
           var ciudadResult = await _dbContext.Ciudad.AddAsync(ciudad);

            if (ciudadResult is null)
                return null;

            await _dbContext.SaveChangesAsync();

            return ciudadResult.Entity;
        }

        public async Task<Domain.Ciudad?> DeleteCiudad(int id)
        {
            var ciudad =  await _dbContext.Ciudad.FindAsync(id);

            if (ciudad is null)
                return null;

            _dbContext.Remove(ciudad);
            await _dbContext.SaveChangesAsync();

            return ciudad;
        }
       
        public async Task< IEnumerable<object>?> GetAllCiudades()
        {
            var ciudadPais = _dbContext.Ciudad.Join(_dbContext.Pais, c => c.PaisId, p => p.Id, (ciudad,pais) => new
            {
                Ciudad = ciudad,
                Pais = pais
            });

            return await ciudadPais.ToListAsync();
        }

        public  async Task<Domain.Ciudad?> GetSingleCiudad(int id)
        {
            var ciudad = await _dbContext.Ciudad.FindAsync(id);

            if (ciudad is null)
                return null;

            return ciudad;
        }

        public async Task<Domain.Ciudad?> UpdateCiudad(int id,Domain.Ciudad requestCiudad)
        {
            var ciudad = await _dbContext.Ciudad.FindAsync(id);

            if (ciudad is null)
                return null;

            ciudad.Nombre = requestCiudad.Nombre;
            ciudad.PaisId = requestCiudad.PaisId;

            await _dbContext.SaveChangesAsync();            

            return ciudad;
        }
    }
}
