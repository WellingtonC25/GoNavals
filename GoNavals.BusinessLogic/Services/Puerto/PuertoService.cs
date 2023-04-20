using GoNavals.Core;
using GoNavals.Core.Interfaces;
using GoNavals.Domain;
using Microsoft.EntityFrameworkCore;

namespace GoNavals.BusinessLogic.Services.Puerto
{
    public class PuertoService : IPuertoService
    {
        private readonly DataContext _dataContext;

        public PuertoService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Domain.Puerto?> AddPuerto(Domain.Puerto puerto)
        {
            var puertoResult = await _dataContext.Puerto.AddAsync(puerto);

            if (puertoResult is null)
                return null;

            await _dataContext.SaveChangesAsync();

            return puertoResult.Entity;
        }
        public async Task<Domain.Puerto?> DeletePuerto(int id)
        {
            var puerto = await _dataContext.Puerto.FindAsync(id);

            if (puerto is null)
                return null;

            _dataContext.Puerto.Remove(puerto);
            await _dataContext.SaveChangesAsync();

            return puerto;
        }
        public async Task<IEnumerable<Domain.Puerto>?> GetAllPuertos()
        {
            return await _dataContext.Puerto.ToListAsync();
        }
        public async Task<Domain.Puerto?> GetSinglePuerto(int id)
        {
            var puerto = await _dataContext.Puerto.FindAsync(id);

            if (puerto is null)
                return null;

            return puerto;
        }
        public async Task<Domain.Puerto?> UpdatePuerto(int id, Domain.Puerto puerto)
        {
            var puertoResult = await _dataContext.Puerto.FindAsync(id);

            if (puertoResult is null)
                return null;

            puertoResult.Descripcion = puerto.Descripcion;
            puertoResult.Direccion = puerto.Direccion;
            puertoResult.CiudadId = puerto.CiudadId;
            puertoResult.ZonaId = puerto.ZonaId;
            puertoResult.Telefono1 = puerto.Telefono1;
            puertoResult.Telefono2 = puerto.Telefono2;
            puertoResult.Celular = puerto.Celular;
            puertoResult.Email = puerto.Email;

            await _dataContext.SaveChangesAsync();

            return puertoResult;
        }

    }
}
