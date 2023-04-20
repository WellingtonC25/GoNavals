using GoNavals.Domain;

namespace GoNavals.Core.Interfaces
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
