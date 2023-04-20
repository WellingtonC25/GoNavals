using GoNavals.Core;
using GoNavals.Core.Interfaces;
using GoNavals.Domain;
using Microsoft.EntityFrameworkCore;

namespace GoNavals.BusinessLogic.Services.Embarcacion
{
    public class EmbarcacionService : IEmbarcacionService
    {
        private readonly DataContext _dataContext;

        public EmbarcacionService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Domain.Embarcacion?> AddEmbarcacion(Domain.Embarcacion embarcacion)
        {
            var embarcacionResult = await _dataContext.Embarcacion.AddAsync(embarcacion);

            if (embarcacionResult is null)
                return null;

            await _dataContext.SaveChangesAsync();

            return embarcacionResult.Entity;
        }

        public async Task<Domain.Embarcacion?> DeleteEmbarcacion(int id)
        {
            var embarcacion = await _dataContext.Embarcacion.FindAsync(id);

            if (embarcacion is null)
                return null;

            _dataContext.Embarcacion.Remove(embarcacion);
            await _dataContext.SaveChangesAsync();

            return embarcacion;
        }

        public async Task<IEnumerable<Domain.Embarcacion>?> GetAllEmbarcaciones()
        {
            return await _dataContext.Embarcacion.ToListAsync();
        }

        public async Task<Domain.Embarcacion?> GetSingleEmbarcacion(int id)
        {
            var embarcacion = await _dataContext.Embarcacion.FindAsync(id);

            if (embarcacion is null)
                return null;

            return embarcacion;
        }

        public async Task<Domain.Embarcacion?> UpdateEmbarcacion(int id, Domain.Embarcacion embarcacion)
        {
            var embarcacionResult = await _dataContext.Embarcacion.FindAsync(id);

            if (embarcacionResult is null)
                return null;

            embarcacionResult.Descripcion = embarcacion.Descripcion;

            await _dataContext.SaveChangesAsync();

            return embarcacionResult;
        }
    }
}
