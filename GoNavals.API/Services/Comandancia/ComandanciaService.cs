using GoNavals.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace GoNavals.API.Services.Comandancia
{
    public class ComandanciaService : IComandanciaService
    {
        private readonly DataContext _dataContext;
       
        public ComandanciaService(Domain.DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<Domain.Comandancia?> AddComandancia(Domain.Comandancia comandancia)
        {
            var comandanciaResult = await _dataContext.Comandancia.AddAsync(comandancia);

            if (comandanciaResult is null)
                return null;

            await _dataContext.SaveChangesAsync();
            
            return comandanciaResult.Entity;
        }

        public async Task<Domain.Comandancia?> DeleteComandancia(int id)
        {
            var comandancia = await _dataContext.Comandancia.FindAsync(id);

            if (comandancia is null)
                return null;

            _dataContext.Remove(comandancia);
            await _dataContext.SaveChangesAsync();

            return comandancia;
        }

        public async Task<IEnumerable<Domain.Comandancia>?> GetAllComandancias()
        {
            if (_dataContext.Comandancia is null)
                return null;

          return await _dataContext.Comandancia.ToListAsync();
        }

        public async Task<Domain.Comandancia?> GetSingleComandancia(int id)
        {
            if (_dataContext.Comandancia is null)
                return null;
            
            var comandancia = await _dataContext.Comandancia.FindAsync(id);

            if (comandancia is null)
                return null;

            return comandancia;
        }

        public async Task<Domain.Comandancia?> UpdateComandancia(int id, Domain.Comandancia comandancia)
        {
            if (_dataContext.Comandancia is null)
                return null;

            var comandanciaResult = await _dataContext.Comandancia.FindAsync(id);

            if (comandanciaResult is null)
                return null;

            await _dataContext.SaveChangesAsync();

            return comandanciaResult;
        }
    }
}
