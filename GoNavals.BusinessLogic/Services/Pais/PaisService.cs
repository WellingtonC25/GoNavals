using GoNavals.Core;
using GoNavals.Core.Interfaces;
using GoNavals.Domain;
using Microsoft.EntityFrameworkCore;

namespace GoNavals.BusinessLogic.Services.Pais
{
    public class PaisService : IPaisService
    {
        private readonly DataContext _dataContext;

        public PaisService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<Domain.Pais?> AddPais(Domain.Pais pais)
        {
            var paisResult = await _dataContext.Pais.AddAsync(pais);

            if (paisResult is null)
                return null;

            await _dataContext.SaveChangesAsync();

            return paisResult.Entity;
        }

        public async Task<Domain.Pais?> DeletePais(int id)
        {
            var pais = await _dataContext.Pais.FindAsync(id);

            if (pais is null)
                return null;

            _dataContext.Pais.Remove(pais);
            await _dataContext.SaveChangesAsync();

            return pais;
        }

        public async Task<IEnumerable<Domain.Pais>?> GetAllPaises()
        {
            return await _dataContext.Pais.ToListAsync();
        }

        public async Task<Domain.Pais?> GetSinglePais(int id)
        {
            var pais = await _dataContext.Pais.FindAsync(id);

            if (pais is null)
                return null;

            return pais;
        }

        public async Task<Domain.Pais?> UpdatePais(int id, Domain.Pais pais)
        {
            var paisResult = await _dataContext.Pais.FindAsync(id);

            if (paisResult is null)
                return null;

            paisResult.Nombre = pais.Nombre;

            await _dataContext.SaveChangesAsync();

            return paisResult;
        }
    }
}
