using GoNavals.Core;
using GoNavals.Core.Interfaces;
using GoNavals.Domain;
using Microsoft.EntityFrameworkCore;

namespace GoNavals.BusinessLogic.Services.Zona
{
    public class ZonaService : IZonaService
    {

        private readonly DataContext _dataContext;

        public ZonaService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Domain.Zona?> AddZona(Domain.Zona zona)
        {
            var zonaResult = await _dataContext.Zona.AddAsync(zona);

            if (zonaResult is null)
                return null;

            await _dataContext.SaveChangesAsync();

            return zonaResult.Entity;
        }
        public async Task<Domain.Zona?> DeleteZona(int id)
        {
            var zona = await _dataContext.Zona.FindAsync(id);

            if (zona is null)
                return null;

            _dataContext.Zona.Remove(zona);
            await _dataContext.SaveChangesAsync();

            return zona;
        }

        public async Task<IEnumerable<Domain.Zona>?> GetAllZonas()
        {
            return await _dataContext.Zona.ToArrayAsync();
        }

        public async Task<Domain.Zona?> GetSingleZona(int id)
        {
            var zona = await _dataContext.Zona.FindAsync(id);

            if (zona is null)
                return null;

            return zona;
        }

        public async Task<Domain.Zona?> UpdateZona(int id, Domain.Zona zona)
        {
            var zonaResult = await _dataContext.Zona.FindAsync(id);

            if (zonaResult is null)
                return null;

            zonaResult.Descripcion = zona.Descripcion;

            await _dataContext.SaveChangesAsync();

            return zonaResult;
        }
    }
}
