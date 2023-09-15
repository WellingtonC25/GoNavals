﻿using GoNavals.Domain;

namespace GoNavals.Core.Interfaces
{
    public interface ICiudadService
    {
        Task<IEnumerable<object>?> GetAllCiudades();
        Task<Domain.Ciudad?> GetSingleCiudad(int id);
        Task<Domain.Ciudad?> AddCiudad(Domain.Ciudad ciudadParameter);
        Task<Domain.Ciudad?> UpdateCiudad(int id, Domain.Ciudad requestCiudad);
        Task<Domain.Ciudad?> DeleteCiudad(int id);
    }
}
