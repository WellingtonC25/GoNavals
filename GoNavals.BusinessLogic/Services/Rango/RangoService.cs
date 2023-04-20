using GoNavals.Core;
using GoNavals.Core.Interfaces;
using GoNavals.Domain;
using Microsoft.EntityFrameworkCore;

namespace GoNavals.BusinessLogic.Services.Rango
{
    public class RangoService : IRangoService
    {
        private readonly DataContext _dataContext;

        public RangoService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Domain.Rango?> AddRango(Domain.Rango rango)
        {
            var rangoResult = await _dataContext.Rango.AddAsync(rango);

            if (rangoResult is null)
                return null;

            await _dataContext.SaveChangesAsync();

            return rangoResult.Entity;
        }
        public async Task<Domain.Rango?> DeleteRango(int id)
        {
            var rango = await _dataContext.Rango.FindAsync(id);

            if (rango is null)
                return null;

            _dataContext.Rango.Remove(rango);
            await _dataContext.SaveChangesAsync();

            return rango;
        }

        public async Task<IEnumerable<Domain.Rango>?> GetAllRangos()
        {
            return await _dataContext.Rango.ToListAsync();
        }

        public async Task<Domain.Rango?> GetSingleRango(int id)
        {
            var rango = await _dataContext.Rango.FindAsync(id);

            if (rango is null)
                return null;

            return rango;
        }

        public async Task<Domain.Rango?> UpdateRango(int id, Domain.Rango rango)
        {
            var rangoResult = await _dataContext.Rango.FindAsync(id);

            if (rangoResult is null)
                return null;

            rangoResult.Descripcion = rango.Descripcion;

            await _dataContext.SaveChangesAsync();

            return rangoResult;
        }
    }
}
