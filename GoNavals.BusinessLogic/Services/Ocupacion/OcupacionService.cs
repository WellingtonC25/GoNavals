using GoNavals.Core;
using GoNavals.Core.Interfaces;
using GoNavals.Domain;
using Microsoft.EntityFrameworkCore;

namespace GoNavals.BusinessLogic.Services.Ocupacion
{
    public class OcupacionService : IOcupacionService
    {
        private readonly DataContext _dataContext;

        public OcupacionService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<Domain.Ocupacion?> AddOcupacion(Domain.Ocupacion ocupacion)
        {
            var ocupacionResult = await _dataContext.Ocupacion.AddAsync(ocupacion);

            if (ocupacionResult is null)
                return null;

            await _dataContext.SaveChangesAsync();

            return ocupacionResult.Entity;
        }

        public async Task<Domain.Ocupacion?> DeleteOcupacion(int id)
        {
            var ocupacion = await _dataContext.Ocupacion.FindAsync(id);

            if (ocupacion is null)
                return null;

            _dataContext.Ocupacion.Remove(ocupacion);
            await _dataContext.SaveChangesAsync();

            return ocupacion;
        }

        public async Task<IEnumerable<Domain.Ocupacion>?> GetAllOcupaciones()
        {
            return await _dataContext.Ocupacion.ToListAsync();
        }

        public async Task<Domain.Ocupacion?> GetSingleOcupacion(int id)
        {
            var ocupacion = await _dataContext.Ocupacion.FindAsync(id);

            if (ocupacion is null)
                return null;

            return ocupacion;
        }

        public async Task<Domain.Ocupacion?> UpdateOcupacion(int id, Domain.Ocupacion ocupacion)
        {
            var ocupacionResult = await _dataContext.Ocupacion.FindAsync(id);

            if (ocupacionResult is null)
                return null;

            ocupacionResult.Descripcion = ocupacion.Descripcion;

            await _dataContext.SaveChangesAsync();

            return ocupacionResult;
        }
    }
}
