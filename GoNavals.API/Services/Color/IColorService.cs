using Microsoft.AspNetCore.Mvc;
using GoNavals.Domain;

namespace GoNavals.API.Services.Color
{
    public interface IColorService
    {
        Task<IEnumerable<Domain.Color>?> GetAllColores();
        Task<Domain.Color?> GetSingleColor(int id);
        Task<Domain.Color?> UpdateColor(int id, Domain.Color color);
        Task<Domain.Color?> AddColor(Domain.Color color);
        Task<Domain.Color?> DeleteColor(int id);
    }
}
