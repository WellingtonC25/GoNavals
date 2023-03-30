using GoNavals.Domain;
using Microsoft.EntityFrameworkCore;

namespace GoNavals.API.Services.ComandanteComandancia
{
    public class ComandanteComandanciaService : IComandanteComandanciaService
    {
        private readonly DataContext _dataContext;

        public ComandanteComandanciaService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<Domain.ComandanteComandancia?> AddComandanteComandancia(Domain.ComandanteComandancia comandanteComandancia)
        {
            var comandanteComandanciaResult = await _dataContext.ComandanteComandancia.AddAsync(comandanteComandancia);

            if (comandanteComandanciaResult is null)
                return null;

            await _dataContext.SaveChangesAsync();

            return comandanteComandanciaResult.Entity;
        }

        public async Task<Domain.ComandanteComandancia?> DeleteComandanteComandancia(int id)
        {
            var comandanteComandancia = await _dataContext.ComandanteComandancia.FindAsync(id);

            if (comandanteComandancia is null)
                return null;

            _dataContext.ComandanteComandancia.Remove(comandanteComandancia);

            await _dataContext.SaveChangesAsync();

            return comandanteComandancia;
        }

        public async Task<IEnumerable<Domain.ComandanteComandancia>?> GetAllComandanteComandancias()
        {
            var comandanteComandancia =  await _dataContext.ComandanteComandancia.ToListAsync();

            if (comandanteComandancia is null)
                return null;

            return comandanteComandancia;
        }

        public async Task<Domain.ComandanteComandancia?> GetSingleComandanteComandancia(int id)
        {
            var comandanteComandancia = await _dataContext.ComandanteComandancia.FindAsync(id);

            if (comandanteComandancia is null)
                return null;

            return comandanteComandancia;
        }

        public async Task<Domain.ComandanteComandancia?> UpdateComandanteComandancia(int id, Domain.ComandanteComandancia comandanteComandancia)
        {
            var comandanteComandanciaResult = await _dataContext.ComandanteComandancia.FindAsync(id);

            if (comandanteComandanciaResult is null)
                return null;

            comandanteComandanciaResult.ComandanciaId = comandanteComandancia.ComandanciaId;
            comandanteComandanciaResult.ComandanteId = comandanteComandancia.ComandanteId;

            await _dataContext.SaveChangesAsync();

            return comandanteComandanciaResult;
        }
    }
}
