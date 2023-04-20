using GoNavals.Core;
using GoNavals.Core.Interfaces;
using GoNavals.Domain;
using Microsoft.EntityFrameworkCore;

namespace GoNavals.BusinessLogic.Services.Comandante
{
    public class ComandanteService : IComandanteService
    {
        private readonly DataContext _dataContext;

        public ComandanteService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<Domain.Comandante?> AddComandante(Domain.Comandante comandante)
        {
            var comandanteResult = await _dataContext.Comandante.AddAsync(comandante);

            await _dataContext.SaveChangesAsync();

            return comandanteResult.Entity;
        }

        public async Task<Domain.Comandante?> DeleteComandante(int id)
        {
            var comandante = await _dataContext.Comandante.FindAsync(id);

            if (comandante is null)
                return null;

            _dataContext.Comandante.Remove(comandante);
            await _dataContext.SaveChangesAsync();

            return comandante;
        }

        public async Task<IEnumerable<Domain.Comandante>?> GetAllComandantes()
        {
            return await _dataContext.Comandante.ToListAsync();
        }

        public async Task<Domain.Comandante?> GetSingleComandante(int id)
        {
            var comandante = await _dataContext.Comandante.FindAsync(id);
            return comandante;
        }

        public async Task<Domain.Comandante?> UpdateComandante(int id, Domain.Comandante comandante)
        {
            var comandanteResult = await _dataContext.Comandante.FindAsync(id);

            if (comandanteResult is null)
                return null;

            comandante.Nombre = comandante.Nombre;
            comandante.Apellidos = comandante.Apellidos;
            comandante.RangoId = comandante.RangoId;

            await _dataContext.SaveChangesAsync();

            return comandanteResult;
        }
    }
}
