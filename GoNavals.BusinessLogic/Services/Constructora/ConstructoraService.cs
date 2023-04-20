using GoNavals.Core;
using GoNavals.Core.Interfaces;
using GoNavals.Domain;
using Microsoft.EntityFrameworkCore;

namespace GoNavals.BusinessLogic.Services.Constructora
{
    public class ConstructoraService : IConstructoraService
    {
        private readonly DataContext _dataContext;

        public ConstructoraService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<Domain.Constructora?> AddConstructora(Domain.Constructora constructora)
        {
            var constructoraResult = await _dataContext.Constructora.AddAsync(constructora);

            if (constructoraResult is null)
                return null;

            await _dataContext.SaveChangesAsync();

           return constructoraResult.Entity;
        }

        public async Task<Domain.Constructora?> DeleteConstructora(int id)
        {
            var constructora = await _dataContext.Constructora.FindAsync(id);

            if (constructora is null)
                return null;

            _dataContext.Constructora.Remove(constructora);
            await _dataContext.SaveChangesAsync();

            return constructora;
        }

        public async Task<IEnumerable<Domain.Constructora>> GetAllConstructoras()
        {
            return await _dataContext.Constructora.ToListAsync();
        }

        public async Task<Domain.Constructora?> GetSingleConstructora(int id)
        {
            var constructora = await _dataContext.Constructora.FindAsync(id);

            if (constructora is null)
                return null;

            return constructora;
        }

        public async Task<Domain.Constructora?> UpdateConstructora(int id, Domain.Constructora constructora)
        {
            var constructoraResult = await _dataContext.Constructora.FindAsync(id);

            if (constructoraResult is null)
                return null;

            constructoraResult.RNC = constructora.RNC;
            constructoraResult.Descripcion = constructora.Direccion;
            constructoraResult.PaisId = constructora.PaisId;
            constructoraResult.Direccion = constructora.Direccion;
            constructoraResult.Telefono1 = constructora.Telefono1;
            constructoraResult.Telefono2 = constructora.Telefono2;
            constructoraResult.Celular = constructora.Celular;
            constructoraResult.Email = constructora.Email;

            await _dataContext.SaveChangesAsync();

            return constructoraResult;
        }
    }
}
