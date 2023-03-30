using Microsoft.AspNetCore.Mvc;
using GoNavals.Domain;

namespace GoNavals.API.Services.Ciudad
{
    public interface ICiudadService
    {
        Task<IEnumerable<Domain.Ciudad>?> GetAllCiudades();
        Task<Domain.Ciudad?> GetSingleCiudad(int id);
        Task<Domain.Ciudad?> AddCiudad(Domain.Ciudad ciudadParameter);
        Task<Domain.Ciudad?> UpdateCiudad(int id, Domain.Ciudad requestCiudad);
        Task<Domain.Ciudad?> DeleteCiudad(int id);
    }
}
