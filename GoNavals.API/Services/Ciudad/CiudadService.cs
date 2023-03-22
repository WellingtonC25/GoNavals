using GoNavals.Domain;
using Microsoft.EntityFrameworkCore;

namespace GoNavals.API.Services.Ciudad
{
    public class CiudadService : ICiudadService
    {
        private readonly Domain.DataContext _dbContext;
        List<Domain.Ciudad> _ciudad = new List<Domain.Ciudad>();

        public CiudadService(Domain.DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Domain.Ciudad>> AddCiudad(Domain.Ciudad ciudadParameter)
        {
            await _dbContext.Ciudad.AddAsync(ciudadParameter);

            await _dbContext.SaveChangesAsync();

            return _ciudad;
        }

        public async Task<List<Domain.Ciudad>> DeleteCiudad(int id)
        {
            var ciudad =  await _dbContext.Ciudad.FindAsync(id);

            if (ciudad is null)
                return null;

            _dbContext.Remove(ciudad);
            await _dbContext.SaveChangesAsync();

            return _ciudad;
        }
        //
        public async Task<List<Domain.Ciudad>> GetAllCiudades()
        {
            return await _dbContext.Ciudad.ToListAsync(); ;
        }

        public  async Task<Domain.Ciudad> GetSingleCiudad(int id)
        {
            var ciudad = await _dbContext.Ciudad.FindAsync(id);

            if (ciudad is null)
                return null;

            return ciudad;
        }

        public async Task<List<Domain.Ciudad>> UpdateCiudad(int id,Domain.Ciudad requestCiudad)
        {
            var ciudad = await _dbContext.Ciudad.FindAsync(id);
            if (ciudad is null)
                return null;

            ciudad.Nombre = requestCiudad.Nombre;
            ciudad.PaisId = requestCiudad.PaisId;

            await _dbContext.SaveChangesAsync();            

            return _ciudad;
        }
    }
}
