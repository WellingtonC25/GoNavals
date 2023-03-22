using Microsoft.AspNetCore.Mvc;
using GoNavals.Domain;

namespace GoNavals.API.Services.Ciudad
{
    public interface ICiudadService
    {
        Task <List<Domain.Ciudad>> GetAllCiudades();
        Task<Domain.Ciudad> GetSingleCiudad(int id);
        Task<List<Domain.Ciudad>> AddCiudad(Domain.Ciudad ciudadParameter);
        Task<List<Domain.Ciudad>> UpdateCiudad(int id, Domain.Ciudad requestCiudad);
        Task<List<Domain.Ciudad>> DeleteCiudad(int id);
    }
}
