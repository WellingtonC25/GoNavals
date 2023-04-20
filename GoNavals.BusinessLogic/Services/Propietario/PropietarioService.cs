using GoNavals.Core;
using GoNavals.Core.Interfaces;
using GoNavals.Domain;
using Microsoft.EntityFrameworkCore;

namespace GoNavals.BusinessLogic.Services.Propietario
{
    public class PropietarioService : IPropietarioService
    {
        private readonly DataContext _dataContext;

        public PropietarioService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
       
        public async Task<Domain.Propietario?> AddPropietario(Domain.Propietario propietario)
        {

            var propietarioResult = await _dataContext.Propietario.AddAsync(propietario);

            if (propietarioResult is null)
                return null;

            await _dataContext.SaveChangesAsync();

            return propietarioResult.Entity;
        }
        public async Task<Domain.Propietario?> DeletePropietario(int id)
        {
            var propietario = await _dataContext.Propietario.FindAsync(id);

            if (propietario is null)
                return null;

            _dataContext.Propietario.Remove(propietario);
            await _dataContext.SaveChangesAsync();

            return propietario;
        }

        public async Task<IEnumerable<Domain.Propietario>?> GetAllPropietarios()
        {
            return await _dataContext.Propietario.ToListAsync();
        }

        public async Task<Domain.Propietario?> GetSinglePropietario(int id)
        {
            var propietario = await _dataContext.Propietario.FindAsync(id);

            if (propietario is null)
                return null;

            return propietario;
        }

        public async Task<Domain.Propietario?> UpdatePropietario(int id, Domain.Propietario propietario)
        {
            var propietarioResult = await _dataContext.Propietario.FindAsync(id);

            if (propietarioResult is null)
                return null;

            propietarioResult.Nombre = propietario.Nombre;
            propietarioResult.Apellidos = propietario.Apellidos;
            propietarioResult.Cedula_Pasaporte = propietario.Cedula_Pasaporte;
            propietarioResult.Celular = propietario.Celular;
            propietarioResult.Telefono = propietario.Telefono;
            propietarioResult.Direccion = propietario.Direccion;
            propietarioResult.Email = propietario.Email;
            propietarioResult.PaisId = propietario.PaisId;
            propietarioResult.Zip = propietario.Zip;

            await _dataContext.SaveChangesAsync();

            return propietarioResult;
        }

    }
}
