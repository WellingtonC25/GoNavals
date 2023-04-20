using GoNavals.Core;
using GoNavals.Core.Interfaces;
using GoNavals.Domain;
using Microsoft.EntityFrameworkCore;

namespace GoNavals.BusinessLogic.Services.TipoUso
{
    public class TipoUsoService : ITipoUsoService
    {

        private readonly DataContext _dataContext;

        public TipoUsoService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Domain.TipoUso?> AddTipoUso(Domain.TipoUso tipoUso)
        {
            var tipoUsoResult = await _dataContext.TipoUso.AddAsync(tipoUso);

            if (tipoUsoResult is null)
                return null;

            await _dataContext.SaveChangesAsync();

            return tipoUsoResult.Entity;
        }
        public async Task<Domain.TipoUso?> DeleteTipoUso(int id)
        {
            var tipoUso = await _dataContext.TipoUso.FindAsync(id);

            if (tipoUso is null)
                return null;

            _dataContext.TipoUso.Remove(tipoUso);
            await _dataContext.SaveChangesAsync();

            return tipoUso;
        }

        public async Task<IEnumerable<Domain.TipoUso>?> GetAllTipoUsos()
        {
            return await _dataContext.TipoUso.ToListAsync();
        }

        public async Task<Domain.TipoUso?> GetSingleTipoUso(int id)
        {
            var tipoUso = await _dataContext.TipoUso.FindAsync(id);

            if (tipoUso is null)
                return null;

            return tipoUso;
        }

        public async Task<Domain.TipoUso?> UpdateTipoUso(int id, Domain.TipoUso tipoUso)
        {
            var tipoUsoResult = await _dataContext.TipoUso.FindAsync(id);

            if (tipoUsoResult is null)
                return null;

            tipoUsoResult.Descripcion = tipoUso.Descripcion;

            await _dataContext.SaveChangesAsync();

            return tipoUsoResult;
        }
    }
}
